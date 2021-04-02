using SampleCQRSAndMediator.Order.Models;
using System.Threading.Tasks;

namespace SampleCQRSAndMediator.Order.Services.Interfaces
{
    public interface IOrderService
    {
        Task<OrderModel> GetOrderByIdAsync(int id);

        Task<int> AddOrderAsync(AddOrderModel addOrderModel);
    }
}