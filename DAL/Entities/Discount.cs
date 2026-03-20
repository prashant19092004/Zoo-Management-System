using System;

namespace ZooManagement.DAL.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        public required string Category { get; set; }
        public decimal Percentage { get; set; }
        public required string Code { get; set; }
    }
}