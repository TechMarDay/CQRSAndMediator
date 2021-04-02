using System;

namespace SampleCQRSAndMediator.Order.Models
{
    public class OrderModel
    {
         public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal Total { get; set; }
    }
}