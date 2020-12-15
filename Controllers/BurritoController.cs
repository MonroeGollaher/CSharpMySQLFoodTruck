using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharpfoodtruck.Models;
using csharpfoodtruck.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace csharpfoodtruck.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BurritoController : ControllerBase
    {
        private readonly BurritoService _bs;

        public BurritoController(BurritoService bs)
        {
            _bs = bs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Burrito>> Get()
        {
            try
            {
                return Ok(_bs.Get());
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Burrito>> GetById(int id)
        {
            try
            {
                return Ok(_bs.GetById(id));
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Burrito> CreateBurrito([FromBody] Burrito burrito)
        {
            try
            {
                return Ok(_bs.Create(burrito));
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Burrito> Delete(int id)
        {
            try
            {
                return Ok(_bs.Delete(id));
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}