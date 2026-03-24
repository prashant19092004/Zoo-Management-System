using System;
using ZooManagement.Shared;

namespace ZooManagement.BAL.Interfaces
{
    public interface IVisitorService
    {
        void RegisterVisitor(VisitorDto visitorDto);
        VisitorDto? LoginVisitor(string email, string password);
        VisitorDto? GetVisitor(int id);
        bool BuyMembership(Memberships type, int id);
    }
}