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
    }
}