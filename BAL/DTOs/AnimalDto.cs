using System;
using ZooManagement.Domain.Entities;

namespace ZooManagement.BAL.DTOs
{
    public class AnimalDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}