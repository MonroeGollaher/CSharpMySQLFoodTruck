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
    public class BurgerController : ControllerBase
    {
        private readonly BurgerService _bs;

        public BurgerController(BurgerService bs)
        {
            _bs = bs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Burger>> GetAll()
        {
            try
            {
                return Ok(_bs.GetAll()); 
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Burger>> GetById(int id)
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
        public ActionResult<Burger> Create([FromBody] Burger burger)
        {
            try
            {
                return Ok(_bs.Create(burger));
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Burger> Delete(int id)
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