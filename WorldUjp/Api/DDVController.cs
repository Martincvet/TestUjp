using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Data.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WorldUjp.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DDVController : ControllerBase
    {
        private readonly IDDVRepository ddvRepository;
        public DDVController(IDDVRepository ddvRepository)
        {
            this.ddvRepository = ddvRepository;
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult GetAll()
        {
            return Ok(ddvRepository.GetAll());
        }
    }
}