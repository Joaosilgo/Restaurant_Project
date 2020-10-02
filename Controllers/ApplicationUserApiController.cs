using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using retaurant_info.Data;
using retaurant_info.Models;

namespace retaurant_info.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserApiController : ControllerBase
    {


        private readonly ApplicationDbContext _context;

        public ApplicationUserApiController(ApplicationDbContext context)
        {
            _context = context;
        }



        // GET: api/ApplicationUserApi

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetApplicationUsers()
        {
            return await _context.ApplicationUsers.ToListAsync();
        }
        /*
        // GET: api/ApplicationUserApi
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        */

        // GET: api/ApplicationUserApi/60bdf27e-ae4d-4729-93c5-ca27b855ff54
        [HttpGet("{id}", Name = "GetApplicationUser")]
        public async Task<ActionResult<ApplicationUser>> GetApplicationUser(string id)
        {
            var applicationUser = await _context.ApplicationUsers.FindAsync(id);

            if (applicationUser == null)
            {
                return NotFound();
            }

            return applicationUser;
        }



        /*

    // GET: api/ApplicationUserApi/5
    [HttpGet("{id}", Name = "Get")]
    public string Get(int id)
    {
        return "value";
    }

*/

        // POST: api/ApplicationUserApi
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ApplicationUserApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
