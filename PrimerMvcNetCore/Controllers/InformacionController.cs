using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ControladorVista()
        {
            //VAMOS A ENVIAR INFORMACION SIMPLE A NUESTRA VISTA
            ViewData["NOMBRE"]="Alumno";
            ViewData["EDAD"]=24;
            ViewBag.DiaSemana="Lunes";
            return View();

        }
        public IActionResult ControladorVistaModel()
        {
            Persona pers = new Persona();
            pers.Nombre="Rodrigo";
            pers.Email="rodr@gmail.com";
            pers.Edad=21;
            return View(pers);
        }

        //VAMOS A RECIBIR DOS PARAMS
        public IActionResult VistaControllerGet
            (string saludo, int? year)
        {
            if (year!=null)
            {
                ViewData["DATA"]="Hola "+saludo+" en el año "+year;
            }
            else
            {
                ViewData["DATA"]="Aqui no tenemos tiempo...";
            }
            //Para comprobar que los hemos recibido guardamos los parametros en viewdata para ver la informacion
            
            return View();
        }

        public IActionResult VistaControllerPost()
        {
            return View();
        }


        [HttpPost]
        public IActionResult VistaControllerPost
            (Persona persona,string aficiones)
        {
            
            ViewData["DATA"]="Nombre: "+persona.Nombre+", email: "+persona.Email+", Edad "+persona.Edad+", Aficiones: "+aficiones;

            return View();
        }
    }
}
