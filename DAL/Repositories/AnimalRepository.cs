using ZooManagement.Domain.Entities;
using ZooManagement.Domain.Interfaces;
// using ZooManagement.DAL.Data;

namespace ZooManagement.DAL.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private static List<Animal> animals = new List<Animal>();

        public List<Animal> GetAll()
        {
            return animals;
        }

        public void Add(Animal animal)
        {
            animal.Id = animals.Count + 1;
            animals.Add(animal);
        }
    }
}