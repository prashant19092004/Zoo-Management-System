namespace ZooManagement.BAL.DTOs
{
    public class DiscountDto
    {
        public int Id { get; set; }
        public required string Category { get; set; }

        public required decimal Percentage { get; set; }
        public required string Code { get; set; }
    }
}