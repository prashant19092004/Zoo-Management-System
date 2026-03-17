using System;

namespace ZooManagement.Domain.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public decimal Percentage { get; set; }
        public string Code { get; set; }
    }
}