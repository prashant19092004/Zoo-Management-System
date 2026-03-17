using System;

namespace ZooManagement.Domain.Entities
{
    public class Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
    }
}