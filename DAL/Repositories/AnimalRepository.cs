using ZooManagement.DAL.Entities;
using ZooManagement.DAL.Interfaces;
using ZooManagement.DAL.Data;

namespace ZooManagement.DAL.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        // private static List<Animal> animals = new List<Animal>();
        private readonly ZooDbContext _context;
        public AnimalRepository(ZooDbContext context)
        {
            _context = context;
        }



        public List<Animal> GetAll()
        {    
            var animalQuery = from a in _context.Animals
                            orderby a.Name
                            select new Animal
                            {
                               Id = a.Id,
                               Name = a.Name,
                               Type = a.Type 
                            };

            List<Animal> animals = animalQuery.ToList();
            
            return animals;
        }

        public Animal GetById(int id)
        {
            return _context.Animals.Find(id);
        }
        public void Add(Animal animal)
        {
            _context.Animals.Add(animal);
            _context.SaveChanges();
        }

        public void UpdateById(Animal animal)
        {
            var ExistingAnimal = _context.Animals.FirstOrDefault(n => n.Id == animal.Id);

            if(ExistingAnimal != null)
            {
                ExistingAnimal.Name = animal.Name;
                ExistingAnimal.Type = animal.Type;

                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var animalData = _context.Animals.Find(id);

            if(animalData != null)
            {
                _context.Animals.Remove(animalData);
                _context.SaveChanges();
            }
        }
    }
}