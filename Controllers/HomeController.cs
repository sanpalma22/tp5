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
    public IActionResult Creditos()
    {
        return View();
    }
    public IActionResult Comenzar()
    {
        return View("Habitacion" + Escape.GetEstadoJuego());
    }
    public IActionResult Habitacion(int sala, string clave)
    {
        if (sala == Escape.GetEstadoJuego())
        {
            bool correcto= clave!=null && Escape.ResolverSala(sala - 1, clave.ToUpper());
            if (correcto) return View("Habitacion" + Escape.GetEstadoJuego());
            else return View("Habitacion" + sala);
        } else return View("Habitacion" + Escape.GetEstadoJuego());

    }

}
