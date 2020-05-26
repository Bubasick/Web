using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;

        }

        [HttpPost]
        public async Task<ActionResult<OrderDTO>> CreeateOrder([FromQuery]ICollection<PartDTO> partsForReplacement, decimal price)
        {
            await _orderService.CreateOrder(partsForReplacement, price);
            return Ok();
        }
     

    }
}
