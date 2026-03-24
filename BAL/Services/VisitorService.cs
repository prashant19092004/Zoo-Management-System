using System;
using ZooManagement.BAL.Interfaces;
using ZooManagement.DAL.Entities;
using ZooManagement.DAL.Interfaces;
using ZooManagement.Shared;

namespace ZooManagement.BAL.Services
{
    public class VisitorService : IVisitorService
    {
        private readonly IVisitorRepository _repository;

        public VisitorService(IVisitorRepository repository)
        {
            _repository = repository;
        }

        public void RegisterVisitor(VisitorDto visitorDto)
        {
            var visitor = new Visitor
            {
                Id = visitorDto.Id,
                Name = visitorDto.Name,
                Age = visitorDto.Age,
                Balance = visitorDto.Balance,
                Phone = visitorDto.Phone,
                Email = visitorDto.Email,
                Password = visitorDto.Password
            };

            _repository.Register(visitor);
        }

        public VisitorDto? LoginVisitor(string email, string password)
        {
            var visitor = _repository.Login(email, password);

            if(visitor == null)
            {
                return null;
            }

            return new VisitorDto
            {
                Id = visitor.Id,
                Name = visitor.Name,
                Age = visitor.Age,
                Balance = visitor.Balance,
                Phone = visitor.Phone,
                Email = visitor.Email,
                Password = visitor.Password
            }; 
        }
        public VisitorDto? GetVisitor(int id)
        {
            var visitor = _repository.GetById(id);

            if(visitor == null)
            {
                return null;
            }

            return new VisitorDto
            {
                Id = visitor.Id,
                Name = visitor.Name,
                Age = visitor.Age,
                Balance = visitor.Balance,
                Phone = visitor.Phone,
                Email = visitor.Email,
                Password = visitor.Password
            };
        }

        public bool BuyMembership(Memberships type, int id)
        {
            return _repository.BuyMembership(type, id);
        }
    }
}