using MvcCoreVistasParciales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.Repositories
{
    public class RepositoryCoches
    {
        private List<Coche> Cars;

        public RepositoryCoches() {
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

        public List<Coche> GetCoches()
        {
            return this.Cars;
        }

        public Coche FindCoche(int idcoche)
        {
            Coche car =
                this.Cars.SingleOrDefault(z => z.IdCoche == idcoche);
            return car;
        }
    }
}
