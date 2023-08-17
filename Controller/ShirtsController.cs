using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAPINet8.Models;
using DemoAPINet8.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPINet8.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetShirts ()
        {
            return Ok("Reading all shirts.");
        }

        [HttpGet("{id}")]
        public IActionResult GetShirtByID(int id)
        {
            if (id < 0 )
                return BadRequest();
            var shirt = ShirtRepository.getShirtById(id);
            if (shirt == null)
                return NotFound();
            return Ok(shirt);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateShirt(int id)
        {
            return Ok($"Updating shirt with ID : {id}");
        }

        [HttpPost]
        public IActionResult CreateShirt([FromBody]Shirt shirt)
        {
            System.Console.WriteLine("lahdla");
            return Ok("Create shirt");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteShirt(int id)
        {
            return Ok($"Deleting shirt with ID : {id}");
        }
    }
}