using Microsoft.AspNetCore.Mvc;
using MvcCoreVistasParciales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.Controllers
{
    public class CochesController : Controller
    {
        private List<Coche> Cars;

        public CochesController()
        {
            this.Cars = new List<Coche>
            {
                new Coche{ IdCoche = 1, Marca = "Pontiac", Modelo = "FireBird"
                , VelocidadMaxima = 320 },
                new Coche { IdCoche = 2, Marca = "Lamborghini", Modelo = "Diablo"
                , VelocidadMaxima = 340},
                new Coche { IdCoche = 3, Marca = "Ferrari", Modelo= "Testarrossa"
                , VelocidadMaxima = 300},
                new Coche { IdCoche = 4, Marca = "Fiat", Modelo = "Panda"
                , VelocidadMaxima = 95},
                new Coche { IdCoche = 5, Marca = "Ford", Modelo = "Mustang GT"
                , VelocidadMaxima = 290}
            };
        }

        public IActionResult Index()
        {
            return View(this.Cars);
        }

        //ESTA VISTA NO TENDRA NADA AL CARGAR
        //EN SU INTERIOR, CARGAREMOS VISTAS PARCIALES
        //CON JQUERY
        //TENDREMOS UNA VISTA PARCIAL CON TODOS LOS COCHES
        public IActionResult PeticionAsincrona()
        {
            return View();
        }

        //NECESITAMOS UN METODO QUE SERA LLAMADO MEDIANTE 
        //load() DE JQUERY
        //LOS METODOS IACTIONRESULT SIEMPRE DEVUELVEN 
        //PartialView
        public IActionResult _CochesPartial()
        {
            return PartialView("_CochesPartial", this.Cars);
        }

        //PODEMOS TENER METODOS QUE RECIBAN PARAMETROS
        //DEBEMOS ENVIAR SIEMPRE PRIMITIVOS
        public IActionResult _CochesDetailsPartial(int idcoche)
        {
            Coche car =
                this.Cars.SingleOrDefault(z => z.IdCoche == idcoche);
            return PartialView("_CochesDetailsPartial", car);
        }
    }
}
