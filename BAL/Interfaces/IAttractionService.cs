

using ZooManagement.BAL.DTOs;
using ZooManagement.DAL.Entities;

namespace ZooManagement.BAL.Interfaces
{
    public interface IAttractionService
    {
        void AddAttraction(AttractionDto dto);

        List<AttractionDto> GetAttractions();
        void UpdateAttraction(AttractionDto dto);
        void DeleteAttraction(int id);
    }
}