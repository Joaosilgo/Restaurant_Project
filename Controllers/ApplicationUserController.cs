using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using retaurant_info.Data;
using retaurant_info.Models;

namespace retaurant_info.Controllers
{
    public class ApplicationUserController : Controller
    {
        private readonly ApplicationDbContext _context;// base dados applicação
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUserController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ApplicationUser
        public ActionResult Index()
        {

            return View(_context.ApplicationUsers.ToList());//lista users   
        }


      

        // GET: ApplicationUser/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users
                .FirstOrDefaultAsync(m => m.Id.Equals(id));
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }
        // GET: ApplicationUser/Create
        // public ActionResult Create()
        public IActionResult Create()
        {
            var model = new ApplicationUser();
            model.Links.Add(new Links());
            return View(model);
           // return View();
        }


        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,DOB,Email,Links")] ApplicationUser applicationUser)
        {
            if (ModelState.IsValid)
            {
               
                    applicationUser.UserName = applicationUser.Email;
                    applicationUser.EmailConfirmed = true;
                       // applicationUser.Links.ToList().Add();
                var result = await _userManager.CreateAsync(applicationUser, applicationUser.Name);//Fica o Nome a Password
                    if (result.Succeeded)
                    {
                        Console.WriteLine("User created a new account with password.");
                        // _logger.LogInformation("User created a new account with password.");
                        //  _context.Add(applicationUser);
                       
                          await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                else 
                {
                    ModelState.Clear();
                    ViewBag.Message = "Sorry we are facing Problem here {result}";
                    Console.WriteLine("User created a new account with password.");

                }

            }
            return View(applicationUser);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddLinks([Bind("Links")] ApplicationUser user, Links link)
        {
            // var link = new Links();
           // if (link.Titulo != null)
          // {
                user.Links.Add(link);
                return PartialView("Links", user);

           // }
            //return View(user);

        }












        // GET: ApplicationUser/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var u = await _context.Users
                  .FirstOrDefaultAsync(m => m.Id.Equals(id));
            if (u == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: ApplicationUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }




    }
}