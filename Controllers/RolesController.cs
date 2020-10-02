using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using retaurant_info.Data;
using retaurant_info.Models;

namespace retaurant_info.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class RolesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }


        public ActionResult Index()
        {
            var roles = _context.Roles.ToList();
            var users = _context.Users.ToList();
            var userRoles = _context.UserRoles.ToList();

            var convertedUsers = users.Select(x => new UsersViewModel
            {
                Email = x.Email,
                Roles = roles
              .Where(y => userRoles.Any(z => z.UserId == x.Id && z.RoleId == y.Id))
              .Select(y => new UsersRole
              {
                  Name = y.NormalizedName,
                  Id= y.Id 
                  
                  
              })
            });


            return View(new DisplayViewModel
            {
                Roles = roles.Select(x => x.NormalizedName),
              
                Users = convertedUsers
            });

           // return View();//lista users   
        }













        [HttpPost]
        public async Task<IActionResult> CreateUser(string email)
        {
            var user = new ApplicationUser
            {
                UserName = email,
                Email = email,
                DOB= DateTime.Now,
                EmailConfirmed=true
            };

            await _userManager.CreateAsync(user, "password");

            return RedirectToAction("Index");
        }




        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel vm)
        {
            await _roleManager.CreateAsync(new IdentityRole { Name = vm.Name });

            return RedirectToAction("Index");
        }





        [HttpPost]
        public async Task<IActionResult> UpdateUserRole(UpdateUserRoleViewModel vm)
        {
            var user = await _userManager.FindByEmailAsync(vm.UserEmail);

            if (user != null)
            {

                if (vm.Delete)
                    await _userManager.RemoveFromRoleAsync(user, vm.Role);
                else
                    await _userManager.AddToRoleAsync(user, vm.Role);

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    


    public class UpdateUserRoleViewModel
    {
        public IEnumerable<UsersViewModel> Users { get; set; }
        public IEnumerable<string> Roles { get; set; }

        public string UserEmail { get; set; }
        public string Role { get; set; }
        public bool Delete { get; set; }
    }


    public class RoleViewModel
        {
            public string Name { get; set; }
        }















        public class UsersViewModel
        {
            public string Email { get; set; }
            public IEnumerable<UsersRole> Roles { get; set; }
        }

        /// <summary>
        /// Classe que representa o Role.
        /// </summary>
        public class UsersRole
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }


        public class DisplayViewModel
        {
            public IEnumerable<string> Roles { get; set; }
            public IEnumerable<UsersViewModel> Users { get; set; }
        }




    }
}