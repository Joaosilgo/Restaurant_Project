using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace retaurant_info.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Required]
        public string Name { get; set; }

        [PersonalData]
        public DateTime DOB { get; set; }
        /*
        public List<Link> Links { get; set; }
       
        


        public ApplicationUser()
        {
            Links = new List<Link>();
        }
        */

        public List<Links> Links { get; set; }

        public ApplicationUser()
        {
            Links = new List<Links>();
        }
    }

    public class Links
    {
        public int Id { get; set; }

        
        public string Url { get; set; }

       
        public string Titulo { get; set; }

    }







}


