using System;

namespace ZooManagement.DAL.Entities
{
    public class Attraction
    {
        public int Id{ get; set; }

        public required string Name{ get; set; }
        public required string Description{ get; set; }
        public decimal Price { get; set; }
    }
}