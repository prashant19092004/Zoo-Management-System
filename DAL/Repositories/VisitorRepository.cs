using System;
using ZooManagement.DAL.Data;
using ZooManagement.DAL.Entities;
using ZooManagement.DAL.Interfaces;
using ZooManagement.Shared;

namespace ZooManagement.DAL.Repositories
{
    class VisitorRepository : IVisitorRepository
    {
        private readonly ZooDbContext _context;

        public VisitorRepository(ZooDbContext context)
        {
            _context = context;
        }

        public void Register(Visitor visitor)
        {
            _context.Visitors.Add(visitor);
            _context.SaveChanges();
        }

        public Visitor? Login(string email, string password)
        {
            var visitorData = _context.Visitors.FirstOrDefault(n => n.Email == email);

            if(visitorData != null)
            {
                if(visitorData.Password == password)
                {
                    return visitorData;
                }
            }

            return null;
        }

        public Visitor? GetById(int? id)
        {
            var visitorQuery = from n in _context.Visitors
                                where n.Id == id
                                select n;
            
            return visitorQuery.FirstOrDefault();
                                 
        }

        public bool BuyMembership(Memberships type, int id)
        {
            var visitorQuery = from n in _context.Visitors
                                where n.Id == id
                                select n;
            
            var visitor = visitorQuery.FirstOrDefault();
            if(visitor == null)
            {
                return false;
            }

            if(type == Memberships.Basic)
            {
                visitor?.Balance -= 20;
            }
            else
            {
                visitor?.Balance -= 50;
            }
            visitor?.Membership = type.ToString();
            _context.SaveChanges();

            return true;
        }
    }
}