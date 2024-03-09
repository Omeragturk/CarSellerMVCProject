using CarSeller.Entities;
using CarSeller.Seeddatas;
using Microsoft.AspNetCore.Mvc;

namespace CarSeller.Controllers
{

    public class CarController : Controller
    {
        

        public IActionResult Index()
        {
            return View(SeedData.Cars.ToList());
        }

        public IActionResult Create()
        {
            Car car = new Car();
            return View(car);
        }
        [HttpPost]
        public IActionResult Create(Car car)
        {
            Car newCar = SeedData.Cars.ToList().Where(x => x.Id == car.Id).FirstOrDefault();
            newCar.Brand = car.Brand;
            newCar.Model = car.Model;
            newCar.ImageUrl = car.ImageUrl;
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var car = SeedData.Cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }
        public IActionResult Edit(int id)
        {
            Car car = SeedData.Cars.ToList().Where(x => x.Id == id).FirstOrDefault();
            if (car != null)
            {
                return View(car);
            }
            return View("Error");
        }
        [HttpPost]
        public IActionResult Edit(Car car)
        {
            Car carupdate = SeedData.Cars.ToList().Where(x => x.Id == car.Id).FirstOrDefault();
            carupdate.Brand = car.Brand;
            carupdate.Model = car.Model;
            carupdate.ImageUrl = car.ImageUrl;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var car = SeedData.Cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            SeedData.Cars.Remove(car);
            return RedirectToAction("Index");
        }
       




    }




}
