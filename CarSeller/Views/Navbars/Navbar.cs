using Microsoft.AspNetCore.Mvc;

namespace CarSeller.Views.Navbar
{
    public class Navbar : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
