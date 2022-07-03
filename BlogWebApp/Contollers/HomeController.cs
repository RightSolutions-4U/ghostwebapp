using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogWebApp.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace BlogWebApp.Contoller
{
    public class HomeController : Controller
    {
        public  async Task<ActionResult> Index()
        {
            Rootobject root = new Rootobject();
            var clientF = new HttpClient();

            var urlF = "https://demo.ghost.io/ghost/api/content/posts/?key=22444f78447824223cefc48062";
            /*var urlF = env + "/api/Products/GetFeatuedProducts";*/

            var responseF = await clientF.GetAsync(urlF);
            var FeaturedProduct = responseF.Content.ReadAsStringAsync().Result;
            root = JsonConvert.DeserializeObject<Rootobject>(FeaturedProduct);
            return View(root);
        }
    }
}

