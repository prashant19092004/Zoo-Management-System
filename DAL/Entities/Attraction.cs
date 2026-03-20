using System;

namespace ZooManagement.DAL.Entities
{
    public class Attraction
    {
        public int Id{ get; set; }
        public required string Description{ get; set; }
        public decimal price { get; set; }
    }
}