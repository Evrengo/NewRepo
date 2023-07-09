using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class PersonelController1 : Controller
    {
        public IActionResult Index()
        {
            PersonelController1 p1 = new PersonelController1() { Ad = "Selami", Soyad = "Şahin", Departman = "Müzik", Aktif = true };
            return View();
        }
    }
}
