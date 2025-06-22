using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Clases
{
    public class Juego
    {
        public int IDJuego { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Clasificacion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public Juego() { }

        public Juego(int idJuego, string nombre, string categoria, string clasificacion, decimal precio, int stock)
        {
            IDJuego = idJuego;
            Nombre = nombre;
            Categoria = categoria;
            Clasificacion = clasificacion;
            Precio = precio;
            Stock = stock;
        }
    }
}
