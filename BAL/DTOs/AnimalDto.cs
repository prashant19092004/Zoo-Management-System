using System;
using ZooManagement.DAL.Entities;

namespace ZooManagement.BAL.DTOs
{
    public class AnimalDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Type { get; set; }
    }
}