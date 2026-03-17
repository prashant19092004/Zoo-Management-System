using System;

namespace ZooManagement.Domain.Entities
{
    public class Feedback
    {
        public int id { get; set; }
        public string content {  get; set; }
        public int VisitorId { get; set; }
    }
}