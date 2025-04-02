using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Ebook: MaterialBibliografico
  
    {
        public double pesoMB {  get; set; }
        public int cantidadHojas { get; set; }

        public Ebook(double pesoMB, int cantidadHojas)
        {
            this.pesoMB = pesoMB;
            this.cantidadHojas = cantidadHojas;
        }

        public Ebook()
        {
        }
        public override void MostrarDatos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.MostrarDatos();
            Console.WriteLine($"Peso: {pesoMB}, Cantidad de Hojas: {cantidadHojas}");
            Console.ResetColor();
        }
    }
}
