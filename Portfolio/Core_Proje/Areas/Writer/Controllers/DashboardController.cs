using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Linq;
using Core_Proje.Areas.Writer.Models;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Day = DateTime.Now.ToShortDateString();
            ViewBag.UserValues = user.Name + " " + user.Surname;

            // Statistics
            Context context = new Context();
            ViewBag.GMS = context.WriterMessages.Where(x => x.Receiver == user.Email).Count();
            ViewBag.DS = context.Announcements.Count();
            ViewBag.KS = context.Users.Count();
            ViewBag.PS = context.Portfolios.Count();

            //Weather API
    //        WeatherViewModel weatherViewModel = new WeatherViewModel();

    //        var client = new HttpClient();
    //        var request = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("/weather?city=Bursa"),
    //            Headers =
    //{
    //    { "X-RapidAPI-Key", "" },
    //    { "X-RapidAPI-Host", "weather-by-api-ninjas.p.rapidapi.com" },
    //},
    //        };
    //        using (var response = await client.SendAsync(request))
    //        {
    //            response.EnsureSuccessStatusCode();
    //            var body = await response.Content.ReadAsStringAsync();
    //            weatherViewModel = JsonConvert.DeserializeObject<WeatherViewModel>(body);
    //            return View(weatherViewModel);
    //        }
            return View();
        }
    }
}
