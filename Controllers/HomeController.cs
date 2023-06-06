using Microsoft.AspNetCore.Mvc;
namespace tp5.Controllers;
using tp5.Models;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Tutorial()
    {
        return View();
    }
    public IActionResult Creditos(){
        return View();
    }
    public IActionResult Comenzar()
    {
        int val = Escape.GetEstadoJuego();
        return View("Habitacion"+ val);
    }
   /* public IActionResult Habitacion()
    {

    }*/

}
