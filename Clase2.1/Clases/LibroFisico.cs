using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class LibroFisico:MaterialBibliografico

    {
       
        private int cantidadHojas { get; set; }

        public LibroFisico( int cantidadHojas)
        {
          
            this.cantidadHojas = cantidadHojas;
        }


        public LibroFisico()
        {
        }
        public override void MostrarDatos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.MostrarDatos();
            Console.WriteLine($" Cantidad de Hojas: {cantidadHojas}");
            Console.ResetColor();
        }
        public void agregarHojas(int temp)
        {
            cantidadHojas = temp; ;
        }
    }
}
