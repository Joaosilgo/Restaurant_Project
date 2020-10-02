using Microsoft.AspNetCore.Hosting;
using retaurant_info.Data;
using retaurant_info.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace retaurant_info.Services
{
    public class UserServices
    {
        private readonly ApplicationDbContext _context;// base dados applicação
        public UserServices(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }

        public IEnumerable<ApplicationUser> GetUsers()
        {
            return _context.ApplicationUsers.ToList();
        }
    }
}
