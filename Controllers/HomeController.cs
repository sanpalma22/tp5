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
        ViewBag.numSala=val;
        return View("Habitacion"+ val);
    }
    public IActionResult Habitacion(int sala, string clave)
    {
        bool correcto=Escape.ResolverSala(sala,clave);
        if(correcto){
            return View("Habitacion"+Escape.GetEstadoJuego());
        }else return View("Habitacion"+sala);
    }

}
