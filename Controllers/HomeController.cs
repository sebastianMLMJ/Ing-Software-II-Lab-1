using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Inyeccion_de_dependencias_Prueba.Models;

namespace Inyeccion_de_dependencias_Prueba.Controllers;

public class HomeController : Controller
{
    /*private readonly ITransient _transient;
    private readonly IScoped _scoped;
    private readonly ISingleton _singleton;
    private readonly ITransient _transient2;
    private readonly IScoped _scoped2;
    private readonly ISingleton _singleton2;


    public HomeController (ITransient transient, IScoped scoped, ISingleton singleton ,
    ITransient transient2, IScoped scoped2, ISingleton singleton2 ){
        _transient = transient;
        _scoped = scoped;
        _singleton = singleton;
        _transient2 = transient2;
        _scoped2 = scoped2;
        _singleton2 = singleton2;
    }
*/

    public IActionResult Index(
    [FromServices] ITransient transient, 
    [FromServices] IScoped scoped,
    [FromServices] ISingleton singleton,
    [FromServices] ITransient transient2, 
    [FromServices]IScoped scoped2, 
    [FromServices]ISingleton singleton2)
    {       
        Aleatorio nuevo = new Aleatorio(transient, scoped, singleton,
        transient2, scoped2, singleton2);
        
        ViewBag.transient = nuevo.carrotransient;

        ViewBag.scoped = nuevo.carroscoped;
        ViewBag.singleton = nuevo.carrosingleton;
        
        ViewBag.transient2 = nuevo.carrotransient2;
        ViewBag.scoped2 = nuevo.carroscoped2;
        ViewBag.singleton2 = nuevo.carrosingleton2;
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
