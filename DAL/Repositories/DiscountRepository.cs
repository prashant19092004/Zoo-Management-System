using System;
using ZooManagement.DAL.Data;
using ZooManagement.DAL.Entities;
using ZooManagement.DAL.Interfaces;

namespace ZooManagement.DAL.Repositories
{

    public class DiscountRepository : IDiscountRepository
    {
        private readonly ZooDbContext _context;

        public DiscountRepository(ZooDbContext context)
        {
            _context = context;
        }

        public void Add(Discount discount)
        {
            _context.Discounts.Add(discount);
            _context.SaveChanges();
        }

        public void Update(Discount discount)
        {
            var existingDiscount = _context.Discounts.FirstOrDefault(n => n.Id == discount.Id);

            if(existingDiscount != null)
            {
                existingDiscount.Category = discount.Category;
                existingDiscount.Percentage = discount.Percentage;
                existingDiscount.Code = discount.Code;
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Invalid Id");
            }
        }

        public void Delete(int id)
        {
            var existingDiscount = _context.Discounts.Find(id);

            if(existingDiscount != null)
            {
                _context.Discounts.Remove(existingDiscount);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Invalid Id.");
            }
        }

        public List<Discount> GetAll()
        {
            List<Discount> discounts = _context.Discounts.ToList();

            return discounts;
        }
    }
}