using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Revista:MaterialBibliografico
    {
        public int volumen { get; set; }      

     
        public Revista()
        {
        }        

        public Revista(string titulo, string autor, int editorial,int volumen) : base(titulo, autor, editorial)
        {
            this.volumen = volumen;
        }
        

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Volumen: {volumen}");
        }
    }
}
