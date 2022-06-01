namespace CandyShop.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
