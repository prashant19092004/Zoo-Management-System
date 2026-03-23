

using ZooManagement.DAL.Data;
using ZooManagement.DAL.Entities;
using ZooManagement.DAL.Interfaces;

namespace ZooManagement.DAL.Repositories
{
    public class AttractionRepository : IAttractionRepository
    {
        private readonly ZooDbContext _context;

        public AttractionRepository(ZooDbContext context)
        {
            _context = context;
        }

        public void Add(Attraction attraction)
        {
            _context.Attractions.Add(attraction);
            _context.SaveChanges();
        }

        public List<Attraction> GetAll()
        {
            return _context.Attractions.ToList();
        }

        public void Update(Attraction attraction)
        {
            var existingAttraction = _context.Attractions.FirstOrDefault(n => n.Id == attraction.Id);

            if(existingAttraction != null)
            {
                existingAttraction.Name = attraction.Name;
                existingAttraction.Description = attraction.Description;
                existingAttraction.Price = attraction.Price;

                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var existingAttraction = _context.Attractions.Find(id);

            if(existingAttraction != null)
            {
                _context.Attractions.Remove(existingAttraction);
                _context.SaveChanges();
            }
        }
    }
}