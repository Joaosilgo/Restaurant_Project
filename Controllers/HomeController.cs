using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using retaurant_info.Models;

namespace retaurant_info.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       

        public HomeController(ILogger<HomeController> logger)
        {
            
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            /*
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.github.com/users/Joaosilgo/repos");
            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            var client = _clientFactory.CreateClient();

            var response =  client.SendAsync(request);
            */


            /*
                  using (var httpClient = new HttpClient())
                  {
                      using (var response = await httpClient.GetAsync("https://www.pinterest.pt/joaosilgo96/casas.rss"))
                      {
                          string apiResponse = await response.Content.ReadAsStringAsync();
                          Console.WriteLine(apiResponse);


                          //dynamic resultado = JsonConvert.DeserializeObject(apiResponse);

                         // Console.WriteL.ine(resultado);
                      }
                  }


          */


            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://www.pinterest.pt/joaosilgo96/casas.rss"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    
                    Console.WriteLine(apiResponse);

                    var user = new ApplicationUser();

                    user.Name = "João";
                    

                    Restaurant restaurant = new Restaurant();
                    restaurant.Id = 1;
                    restaurant.Name = apiResponse;
                    restaurant.Owner = user;

                  //  XmlSerializer serializer = new XmlSerializer();
                    //dynamic resultado = JsonConvert.DeserializeObject(apiResponse);

                    // Console.WriteL.ine(resultado);
                }
            }
















          


            /*
            using (var fileStream = File.Open("https://www.pinterest.pt/joaosilgo96/casas.rss", FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer();
                var myDocument = (MyDocument)serializer.Deserialize(fileStream);

                Console.WriteLine($"My Property : {myDocument.MyProperty}");
                Console.WriteLine($"My Attribute : {myDocument.MyAttributeProperty.Value}");

                foreach (var item in myDocument.MyList)
                {
                    Console.WriteLine(item);
                }
            }
            */


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
