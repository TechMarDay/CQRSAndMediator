using MediatR;
using SampleCQRSAndMediator.Order.Domain.ResponeModels;

namespace SampleCQRSAndMediator.Order.Domain.RequestModels
{
    public class AddOrderRequestModel: IRequest<AddOrderResponseModel>
    {
        public int Id { get; set; }

        public decimal Total { get; set; }
    }
}