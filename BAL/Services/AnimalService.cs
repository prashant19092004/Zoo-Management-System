using System;

using ZooManagement.DAL.Entities;
using ZooManagement.DAL.Interfaces;
using ZooManagement.BAL.DTOs;
using ZooManagement.BAL.Interfaces;

namespace ZooManagement.BAL.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _repository;

        public AnimalService(IAnimalRepository repository)
        {
            _repository = repository;
        }

        public List<AnimalDto> GetAnimals()
        {
            var animals = _repository.GetAll();

            return animals.Select(n => new AnimalDto
            {
                Id = n.Id,
                Name = n.Name,
                Type = n.Type
            }).ToList();
        }

        public AnimalDto GetAnimal(int id)
        {
            var animal = _repository.GetById(id);

            return new AnimalDto
            {
                Id = animal.Id,
                Name = animal.Name,
                Type = animal.Type
            };
        }

        public void AddAnimal(AnimalDto dto)
        {
            var animal = new Animal
            {
                Name = dto.Name,
                Type = dto.Type
            };

            _repository.Add(animal);
        }

        public void UpdateAnimal(AnimalDto dto)
        {
            var animal = new Animal
            {
                Id = dto.Id,
                Name = dto.Name,
                Type = dto.Type
            };

            _repository.UpdateById(animal);
        }

        public void DeleteAnimal(int id)
        {
            _repository.Delete(id);
        }
    }
}