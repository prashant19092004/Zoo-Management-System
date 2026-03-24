using System;
using ZooManagement.BAL.DTOs;
using ZooManagement.BAL.Interfaces;
using ZooManagement.DAL.Entities;
using ZooManagement.DAL.Interfaces;

namespace ZooManagement.BAL.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IDiscountRepository _repository;

        public DiscountService(IDiscountRepository repository)
        {
            _repository = repository;
        }

        public void AddDiscount(DiscountDto discountDto)
        {
            var discount = new Discount
            {
                Category = discountDto.Category,
                Percentage = discountDto.Percentage,
                Code = discountDto.Code
            };

            _repository.Add(discount);
        }

        public void UpdateDiscount(DiscountDto discountDto)
        {
            var discount = new Discount
            {
                Category = discountDto.Category,
                Percentage = discountDto.Percentage,
                Code = discountDto.Code
            };

            _repository.Update(discount);
        }

        public void DeleteDiscount(int id)
        {
            _repository.Delete(id);
        }

        public List<DiscountDto> GetDiscounts()
        {
            var discounts = _repository.GetAll();

            return discounts.Select(n => new DiscountDto
            {
                Id = n.Id,
                Category = n.Category,
                Percentage = n.Percentage,
                Code = n.Code
            }).ToList();
        }
    }
}