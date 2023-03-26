using Microsoft.AspNetCore.Mvc;
using RestarantMVC.Models;

namespace RestarantMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
            //return View("Index");
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
