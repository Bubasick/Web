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
    public class PartController : ControllerBase
    {
        private readonly IPartService _partService;


        public PartController(IPartService partService)
        {
            _partService = partService;
        }
        [HttpGet("GetByPartName/{name}")]
        public ActionResult<PartDTO> GetByPartName(string name)
        {
            return Ok(_partService.Find(name));
        }

       
        [HttpGet("GetPartByOrderId/{id}")]
        public ActionResult<PartDTO> GetPartByOrderId(int id)
        {
            return Ok(_partService.Find(id));
        }
        [HttpGet("GetByPartDate/{date}")]
        public ActionResult<PartDTO> GetByPartDate(DateTime date)
        {
            return Ok(_partService.Find(date));
        }

       
    }
}
