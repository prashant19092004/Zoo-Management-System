using System;

namespace ZooManagement.DAL.Entities
{
    public class Feedback
    {
        public int Id { get; set; }
        public required string Content {  get; set; }
        public int VisitorId { get; set; }
    }
}