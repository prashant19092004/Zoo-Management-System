using ZooManagement.BAL.DTOs;


namespace ZooManagement.BAL.Interfaces
{
    public interface IDiscountService
    {
        void AddDiscount(DiscountDto discountDto);
        void UpdateDiscount(DiscountDto discountDto);
        void DeleteDiscount(int id);
        List<DiscountDto> GetDiscounts();
    }
}