using System;
using ZooManagement.Domain.Entities;

namespace ZooManagement.Domain.Interfaces
{
    public interface IAnimalRepository
    {
        List<Animal> GetAll();
        // Animal GetById(int id);
        void Add(Animal animal);
        // void Delete(int id);
    }
}