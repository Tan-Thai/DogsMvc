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

        [HttpGet("")]
		public IActionResult Index()
		{
			var viewDogList = dataService.GetAllDogs();
			return View(viewDogList);
		}
	}
}
