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

		[HttpGet("/dogs/create")]
		public IActionResult Create()
		{ 
			return View();
		}

		[HttpPost("/dogs/create")]
		public IActionResult Create(Dog dog) 
		{
			dataService.AddDog(dog);
			return RedirectToAction(nameof(Index));
		}

		[HttpGet("Edit/{id}")]
		public IActionResult Edit(int id)
		{ 
			var dog = dataService.GetDogById(id);
			return View(dog);
		
		}
		


	}
}
