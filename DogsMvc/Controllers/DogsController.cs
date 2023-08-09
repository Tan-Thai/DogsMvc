using DogsMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DogsMvc.Controllers
{
	public class DogsController : Controller
	{
		static DataService dataService = new DataService();
        public DogsController()
        {
        }

        //public BandsController()
        //{
        //    dataService = new DataService();
        //}

        [HttpGet("")]
        //[HttpGet("index.php")]
		public IActionResult Index()
		{
			var viewDogList = dataService.GetAllDogs();
			return View(viewDogList);
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
