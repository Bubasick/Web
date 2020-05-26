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
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<OwnerDTO>> GetAll()
        {
            return Ok(_ownerService.GetAll());
        }

        [HttpGet("GetByOwnerName/{name}")]
        public ActionResult<OwnerDTO> GetByOwnerName(string name)
        {
            return Ok(_ownerService.Find(name));
        }
        [HttpGet("GetByPartName/{partName}")]
        public ActionResult<OwnerDTO> GetByPartName(string partName)
        {
            return Ok(_ownerService.FindByPartName(partName));
        }


        [HttpGet("GetByOrderId/{id}")]
        public ActionResult<PartDTO> GetByOrderId(int id)
        {
            return Ok(_ownerService.Find(id));
        }
        [HttpGet("GetByOrderDate/{date}")]
        public ActionResult<PartDTO> GetByOrderDate(DateTime date)
        {
            return Ok(_ownerService.Find(date));
        }
        [HttpGet("GetByComputerModel/{computerName}")]
        public ActionResult<PartDTO> GetByComputerModel(string computerName)
        {
            return Ok(_ownerService.FindByComputerModel(computerName));
        }
    }
}