using System;
using ZooManagement.DAL.Entities;

namespace ZooManagement.DAL.Interfaces
{
    public interface IAttractionRepository
    {
        void Add(Attraction attraction);

        List<Attraction> GetAll();

        void Update(Attraction attraction);

        void Delete(int id);


    } 
}