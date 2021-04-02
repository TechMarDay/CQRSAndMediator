using MediatR;
using SampleCQRSAndMediator.Order.Domain.ResponeModels;

namespace SampleCQRSAndMediator.Order.Domain.RequestModels
{
    public class GetOrderByIdRequestModel : IRequest<GetOrderByIdResponseModel>
    {
        public int Id { get; set; }
    }
}