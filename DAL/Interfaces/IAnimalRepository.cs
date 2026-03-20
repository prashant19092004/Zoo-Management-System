using System;
using ZooManagement.DAL.Entities;

namespace ZooManagement.DAL.Interfaces
{
    public interface IAnimalRepository
    {
        List<Animal> GetAll();
        Animal GetById(int id);
        void Add(Animal animal);
        void UpdateById(Animal animal);
        void Delete(int id);
    }
}