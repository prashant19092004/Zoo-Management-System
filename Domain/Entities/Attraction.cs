using System;

namespace ZooManagement.Domain.Entities
{
    public class Attraction
    {
        public int Id{ get; set; }
        public string Description{ get; set; }
        public decimal price { get; set; }
    }
}