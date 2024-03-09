using CarSeller.Controllers;
using CarSeller.Entities;
using CarSeller.Seeddatas;
using Microsoft.AspNetCore.Mvc;

namespace CarSeller.Views.Shared.Component
{
    public class CarListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(SeedData.Cars.ToList());
        }


    }
}
