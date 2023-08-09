using DogsMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandsMvc.Controllers
{
    public class BandsController : Controller
    {
        static DataService dataService = new DataService();

        //public BandsController()
        //{
        //    dataService = new DataService();
        //}

        [HttpGet("")]
        //[HttpGet("index.php")]
        public IActionResult Index()
        {
            var band = dataService.GetAllDogs();
            return View(band);
        }

        //[HttpGet("detail/{id}")]
        //public IActionResult Detail(int id)
        //{
        //    var band = dataService.GetDogById(id);
        //    return View(band);
        //    //return Content($"ID:{band.Id}, Band:{band.Name}, Genre:{band.Description}");
        //}
    }
}
