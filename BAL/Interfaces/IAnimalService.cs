using System;
using ZooManagement.BAL.DTOs;

namespace ZooManagement.BAL.Interfaces
{
    public interface IAnimalService
    {
        List<AnimalDto> GetAnimals();
        // AnimalDto GetAnimal(int id);
        void AddAnimal(AnimalDto animal);
        // void DeleteAnimal(int id);
    }
}