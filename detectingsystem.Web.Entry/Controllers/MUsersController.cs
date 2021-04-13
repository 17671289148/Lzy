using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using detectingsystem.Application;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace detectingsystem.Web.Entry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MUsersController : ControllerBase
    {

        //public ISystemService _systemService { get; }
        //public MUsersController(ISystemService systemService) {
        //    _systemService = systemService;


        //}
        // GET: api/<MUsersController>
        //[HttpGet]
        //public IActionResult Get(string id)
        //{
        //    var result = _systemService.Musers(id);
        //    return Ok(result);
        //}

        // GET api/<MUsersController>/5

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MUsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MUsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MUsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
