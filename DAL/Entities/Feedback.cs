using System;

namespace ZooManagement.DAL.Entities
{
    public class Feedback
    {
        public int id { get; set; }
        public required string content {  get; set; }
        public int VisitorId { get; set; }
    }
}