using SampleCQRSAndMediator.Order.Models;
using SampleCQRSAndMediator.Order.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace SampleCQRSAndMediator.Order.Services.Handlers
{
    public class OrderService : IOrderService
    {

        public Task<OrderModel> GetOrderByIdAsync(int id)
        {
            //For demo
            OrderModel orderModel = new OrderModel { 
                Id = id,
                OrderDate = DateTime.UtcNow,
                Total = 100
            };
            return Task.FromResult<OrderModel>(orderModel);
        }
        public Task<int> AddOrderAsync(AddOrderModel addOrderModel)
        {
            //For demo
            addOrderModel.Id = 1;
            return Task.FromResult<int>(addOrderModel.Id);
        }
    }
}