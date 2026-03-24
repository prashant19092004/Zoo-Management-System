using System;
using ZooManagement.DAL.Entities;
using ZooManagement.Shared;

namespace ZooManagement.DAL.Interfaces
{
    public interface IVisitorRepository
    {
        void Register(Visitor visitor);
        Visitor? Login(string email, string password);
        Visitor? GetById(int id);
        bool BuyMembership(Memberships type, int id);
    }
}