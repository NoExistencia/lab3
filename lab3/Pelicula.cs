using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3
{
    public class Pelicula
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public string Titulo { get; set; }
        public Genero Genero { get; set; }
        public Director Director { get; set; }
        public DateTime FchLanzamiento { get; set; }
        public int Duracion { get; set; }

        //public string TipoCombustible { get; set; }


        //  public Auto()
        //{
        //  Id = UltimoId;
        //UltimoId++;
        //FechaConstruccion = DateTime.Now;
        //}

        public Pelicula(string titulo, Genero genero, Director director, DateTime fechalanzamiento, int duracion)
        {
            Id = UltimoId;
            UltimoId++;
            Titulo = titulo;
            Genero = genero;
            Director = director;
            FchLanzamiento = fechalanzamiento;
            Duracion = duracion;
        }

        public Pelicula()
        {
            Id = UltimoId;
            UltimoId++;
        }

        public DateTime fchbaja()
        {
            var fecha = this.FchLanzamiento;
            fecha = fecha.AddDays(90);
            return fecha;
        }

        public bool esApta()
        {
            var gen = this.Genero;
            if (gen == Genero.terror || gen == Genero.thriller || gen == Genero.suspenso)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}



        //public Auto(string marca, DateTime fechaConstruccion)
        //{
        //    Id = UltimoId;
        //    UltimoId++;
        //    Marca = marca;
        //    FechaConstruccion = fechaConstruccion;
        //}
