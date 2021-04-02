using MediatR;
using SampleCQRSAndMediator.Order.Domain.RequestModels;
using SampleCQRSAndMediator.Order.Domain.ResponeModels;
using SampleCQRSAndMediator.Order.Services.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace SampleCQRSAndMediator.Order.Domain.Handlers.QueryHandlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdRequestModel, GetOrderByIdResponseModel>
    {
        private IOrderService orderServiceInterface;

        public GetOrderByIdQueryHandler(IOrderService orderServiceInterface)
        {
            this.orderServiceInterface = orderServiceInterface;
        }

        public async Task<GetOrderByIdResponseModel> Handle(GetOrderByIdRequestModel request, CancellationToken cancellationToken)
        {
            var order = await orderServiceInterface.GetOrderByIdAsync(request.Id);
            //Mapping
            var oderResult = new GetOrderByIdResponseModel
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                Total = order.Total
            };
            return await Task.FromResult<GetOrderByIdResponseModel>(oderResult);
        }
    }
}