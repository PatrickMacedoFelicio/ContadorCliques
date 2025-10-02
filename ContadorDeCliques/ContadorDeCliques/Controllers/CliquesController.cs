using Microsoft.AspNetCore.Mvc;
using ContadorDeCliques.Models;

namespace ContadorDeCliques.Controllers;

public class CliquesController : Controller
{
    private static int _contadorDeCliques = 0;
    // GET
    public IActionResult Index()
    {
        var model = new ContadorModel
        {
            Cliques = _contadorDeCliques
        };
        return View(model);
    }
    
    
    [HttpPost]
    public IActionResult Contar()
    {
        _contadorDeCliques++;
        return RedirectToAction("Index");
    }
}