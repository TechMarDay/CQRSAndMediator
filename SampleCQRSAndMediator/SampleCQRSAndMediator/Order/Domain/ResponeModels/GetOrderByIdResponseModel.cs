using System;

namespace SampleCQRSAndMediator.Order.Domain.ResponeModels
{
    public class GetOrderByIdResponseModel
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal Total { get; set; }
    }
}