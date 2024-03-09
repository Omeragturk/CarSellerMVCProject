using CarSeller.Entities;
using CarSeller.Seeddatas;
using Microsoft.AspNetCore.Mvc;

namespace CarSeller.Controllers
{

    public class SellerController : Controller
    {
        List<Car> _cars = SeedData.Cars.ToList();

        public IActionResult Index()
        {
            return View(SeedData.Sellers.ToList());
        }

        public IActionResult Create()
        {
            Seller createSeller = new Seller();
            createSeller.Cars = new List<Car>();
            createSeller.Cars.Add(new Car());

            ViewBag.Cars = SeedData.Cars.Where(x => x.Seller == null).ToList();
            return View(createSeller);
        }

        [HttpPost]
        public IActionResult Create(Seller seller)
        {
            Seller sellers= SeedData.Sellers.ToList().Where(x => x.Id == seller.Id).FirstOrDefault();
            sellers.Name = seller.Name;
            sellers.ContactEmail = seller.ContactEmail;
            sellers.Cars = seller.Cars;
            return RedirectToAction("Index");

        }

        public IActionResult Details(int id)
        {
            Seller SellerDetails = SeedData.Sellers.ToList().Where(x => x.Id == id).FirstOrDefault();
            if (SellerDetails != null)
            {
                return View(SellerDetails);
            }
            return View("Error");
        }

        public IActionResult Edit(int id)
        {
            Seller sellerDetails = SeedData.Sellers.FirstOrDefault(x => x.Id == id);
            if (sellerDetails != null)
            {
                return View(sellerDetails);
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult Edit(Seller seller)
        {
            Seller sellerupdate = SeedData.Sellers.ToList().Where(x => x.Id == seller.Id).FirstOrDefault();
            sellerupdate.Name = seller.Name;
            sellerupdate.ContactEmail = seller.ContactEmail;
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            var seller = SeedData.Sellers.FirstOrDefault(x => x.Id == id);
            if (seller != null)
            {
                SeedData.Sellers.Remove(seller);
                return RedirectToAction("Index");
            }
            return View("Error");
        }
    }
}
