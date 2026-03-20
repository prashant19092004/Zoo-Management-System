using System;

namespace ZooManagement.DAL.Entities
{
    public class Animal
    {
        public int Id{get; set;}

        public required string Name{ get; set; }
        public required string Type { get; set; }
    }
}