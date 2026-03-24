using System;

namespace ZooManagement.DAL.Entities
{
    public class Visitor
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public decimal? Balance { get; set; }
        public long Phone { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? Membership { get; set; }
    }
}