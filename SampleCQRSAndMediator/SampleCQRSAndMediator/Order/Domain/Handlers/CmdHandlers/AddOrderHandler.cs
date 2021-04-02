using MediatR;
using SampleCQRSAndMediator.Order.Domain.RequestModels;
using SampleCQRSAndMediator.Order.Domain.ResponeModels;
using SampleCQRSAndMediator.Order.Services.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace SampleCQRSAndMediator.Order.Domain.Handlers.CmdHandlers
{
    public class AddOrderHandler : IRequestHandler<AddOrderRequestModel, AddOrderResponseModel>
    {
        private IOrderService orderServiceInterface;

        public AddOrderHandler(IOrderService orderServiceInterface)
        {
            this.orderServiceInterface = orderServiceInterface;
        }

        public async Task<AddOrderResponseModel> Handle(AddOrderRequestModel request, CancellationToken cancellationToken)
        {
            var orderId = await orderServiceInterface.AddOrderAsync(new Models.AddOrderModel { 
                Id = request.Id,
                Total = request.Total
            });

            //Mapping
            var oderResult = new AddOrderResponseModel
            {
                Id = orderId
            };
            return await Task.FromResult<AddOrderResponseModel>(oderResult);
        }
    }
}