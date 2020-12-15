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
    public class TacoController : ControllerBase
    {
        private readonly TacoService _ts;
        public TacoController(TacoService ts)
        {
            _ts = ts;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Taco>> Get()
        {
            try
            {
                return Ok(_ts.Get());
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Taco>> GetById(int id)
        {
            try
            {
                return Ok(_ts.GetById(id));
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Taco> Create([FromBody]Taco taco)
        {
            try
            {
                return Ok(_ts.Create(taco));
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Taco> Delete(int id)
        {
            try
            {
                return Ok(_ts.Delete(id));
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}