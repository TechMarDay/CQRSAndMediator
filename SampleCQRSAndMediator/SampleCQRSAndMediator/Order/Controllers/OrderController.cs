using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleCQRSAndMediator.Order.Domain.RequestModels;

namespace SampleCQRSAndMediator.Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator mediator;

        public OrderController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public IActionResult GetOrderByIdAsync([FromQuery] GetOrderByIdRequestModel requestModel)
        {
            var response = mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult AddOrderAsync([FromBody] AddOrderRequestModel addOrderRequestModel)
        {
            var response = mediator.Send(addOrderRequestModel);
            return Ok(response);
        }
    }
}