using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using retaurant_info.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace retaurant_info.Models
{
    public class DbInitializer
    {
        /*
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public DbInitializer( UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            
            
        }*/

        public static void Initialize(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            context.Database.EnsureCreated();

            if (!context.ApplicationUsers.Any())
            {

                /*
                var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                Task<ApplicationUser> checkAppUser = userManager.FindByEmailAsync("joaosilgo96@gmai.com");
                checkAppUser.Wait();


                ApplicationUser appUser = checkAppUser.Result;


                if (checkAppUser.Result == null)
                {
                    ApplicationUser newAppUser = new ApplicationUser
                    {
                        DOB = DateTime.Now,
                        Name = "ADMIN",
                        NormalizedEmail = "JOAOSILGO96@GMAIL.COM",
                        Email = "joaosilgo96@gmail.com",
                        UserName = "joaosilgo96@gmail.com",
                       

                    };
                    newAppUser.EmailConfirmed = true;
                    Task<IdentityResult> taskCreateAppUser = userManager.CreateAsync(newAppUser, "Admin");
                    taskCreateAppUser.Wait();

                    if (taskCreateAppUser.Result.Succeeded)
                    {
                        appUser = newAppUser;
                    }
                }
                //aspnet-retaurant_info-B7CCD879-0BA3-4D72-BE94-2D065B3CB1D9
                context.SaveChanges();
                //  Task<IdentityResult> newUserRole = userManager.AddToRoleAsync(appUser, roleName);
                //  newUserRole.Wait();


            */

                /*
                context.ApplicationUsers.Add(new ApplicationUser
                {

                    DOB = DateTime.Now,
                    Name = "ADMIN",
                    NormalizedEmail = "JOAOSILGO96@GMAIL.COM",
                    Email = "joaosilgo96@gmail.com",
                    UserName = "joaosilgo96@gmail.com",
                    EmailConfirmed = true

                }); */


                var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                Task<bool> roleExists = roleManager.RoleExistsAsync("Administrator");
                roleExists.Wait();

                if (!roleExists.Result)
                {
                    Task<IdentityResult> roleResult = roleManager.CreateAsync(new IdentityRole("Administrator"));
                    roleResult.Wait();
                }





                var superUser = new ApplicationUser
                {
                    DOB = DateTime.Now,
                    Name = "ADMIN",
                    NormalizedEmail = "JOAOSILGO96@GMAIL.COM",
                    Email = "joaosilgo96@gmail.com",
                    UserName = "joaosilgo96@gmail.com",
                    EmailConfirmed = true
                    
                };

                var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                Task<IdentityResult> result = userManager.CreateAsync(superUser, "Jo@oGomes");
                result.Wait();

                if (result.Result.Succeeded)
                {
                    
                    
                    Console.Write("Create User");
                    Console.Write("Create User");
                    context.SaveChanges();
                }
                else
                {

                    Console.Write("Not Create User 🛑");
                    
                }

                Task<IdentityResult> newUserRole = userManager.AddToRoleAsync(superUser, "Administrator");
                newUserRole.Wait();

                //context.SaveChangesAsync();



                 context.SaveChanges();



            }
        }




       



    }
}
