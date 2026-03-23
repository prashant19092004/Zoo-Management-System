using System;

namespace ZooManagement.BAL.DTOs
{
    public class AttractionDto
    {
        public int Id{ get; set; }
        public required string Name{ get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
    }
}