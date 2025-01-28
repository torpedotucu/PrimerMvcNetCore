using Microsoft.AspNetCore.Mvc;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SumarNumerosGet(int numero1,int numero2)
        {
            int suma = numero1+numero2;
            ViewData["DATA"]=numero1+" + "+numero2+" = "+suma;
            return View();
        }

        public IActionResult SumarNumerosPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SumarNumerosPost(int numero1, int numero2)
        {
            int suma = numero1+numero2;
            ViewData["DATA"]=numero1+" + "+numero2+" = "+suma;
            return View();
        }
    }

}
