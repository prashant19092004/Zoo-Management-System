using System;
using ZooManagement.DAL.Entities;

namespace ZooManagement.DAL.Interfaces
{
    public interface IDiscountRepository
    {
        void Add(Discount discount);
        void Update(Discount discount);
        void Delete(int id);
        List<Discount> GetAll();
    }
}