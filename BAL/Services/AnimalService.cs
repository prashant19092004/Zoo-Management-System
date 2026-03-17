using System;

using ZooManagement.Domain.Entities;
using ZooManagement.Domain.Interfaces;
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

        public void AddAnimal(AnimalDto dto)
        {
            var animal = new Animal
            {
                Name = dto.Name,
                Type = dto.Type
            };

            _repository.Add(animal);
        }
    }
}