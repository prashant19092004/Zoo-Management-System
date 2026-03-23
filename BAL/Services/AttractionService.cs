using System;
using ZooManagement.BAL.DTOs;
using ZooManagement.BAL.Interfaces;
using ZooManagement.DAL.Entities;
using ZooManagement.DAL.Interfaces;

namespace ZooManagement.BAL.Services
{
    public class AttractionService : IAttractionService
    {
        private readonly IAttractionRepository _repository;

        public AttractionService(IAttractionRepository repository)
        {
            _repository = repository;
        }

        public void AddAttraction(AttractionDto dto)
        {
            var attraction = new Attraction
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price  
            };
            _repository.Add(attraction);
        }

        public List<AttractionDto> GetAttractions()
        {
            var attractions = _repository.GetAll();

            return attractions.Select(n => new AttractionDto
            {
               Id = n.Id,
               Name = n.Name,
               Description = n.Description,
               Price = n.Price 
            }).ToList();
        }

        public void UpdateAttraction(AttractionDto dto)
        {
            var attraction = new Attraction
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price
            };

            _repository.Update(attraction);
        }

        public void DeleteAttraction(int id)
        {
            _repository.Delete(id);
        }

    }
}