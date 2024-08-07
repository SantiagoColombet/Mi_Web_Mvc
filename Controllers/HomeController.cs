using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mi_Web_Mvc.Models;

namespace Mi_Web_Mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }




    public IActionResult Index()
    {
        ViewBag.cartasIndex = Mi_Web_Mvc.Models.Info.cartasIndex;
        ViewBag.TituloIndex = Mi_Web_Mvc.Models.Info.TituloIndex;
        ViewBag.SubtituloIndex = Mi_Web_Mvc.Models.Info.SubtituloIndex;
        return View();   
    }
    public IActionResult Actividades()
    {
        ViewBag.cartasActividades = Mi_Web_Mvc.Models.Info.cartasActividades;
        ViewBag.TituloActividades = Mi_Web_Mvc.Models.Info.TituloActividades;
        return View();
    }
        public IActionResult Ciudades()
    {
        ViewBag.cartasCiudades = Mi_Web_Mvc.Models.Info.cartasCiudades;
        ViewBag.TituloCiudades = Mi_Web_Mvc.Models.Info.TituloCiudades;
        return View();
    }
        public IActionResult Contactanos()
    {
        return View();
    }
    public IActionResult Form(string Nombre, string Apellido, string DNI, string FechaNacimiento, string Email, string Pais, string Ciudad, string Telefono, string DudasAclaraciones, string MotivoContacto)
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
