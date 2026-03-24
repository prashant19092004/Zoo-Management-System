using System;

namespace ZooManagement.DAL.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public int AttractionId { get; set; }
        public int VisitorId { get; set; }
    }
}