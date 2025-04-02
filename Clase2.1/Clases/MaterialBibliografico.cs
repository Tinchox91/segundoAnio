using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class MaterialBibliografico
    {
        //        Creación:
        //Crear la clase "MaterialBibliografico" que tiene los atributos título, autor y editorial.
        //Tiene un método virtual que muestra esos datos.
        protected string titulo { get; set; }
        protected string autor { get; set; }
        protected int año { get; set; }
        private List<LibroFisico> librosFisicos = new List<LibroFisico>();
        private List<Ebook> ebooks = new List<Ebook>();
        private List<Revista> revistas = new List<Revista>();
        public MaterialBibliografico(string titulo, string autor, int año)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.año = año;
        }

        public MaterialBibliografico()
        {
        }

        // Método virtual que se puede sobrescribir en clases derivadas
        public virtual void MostrarDatos()
        {
            Console.WriteLine($"Título: {titulo}, Autor: {autor}, Año: {año}");
        }

        public void agregarEbook()
        {
            bool salir = false;
            //agregar un metodo "agregar hojas" para el contro de errores y pasar el try catch ahi
            try
            {
                Ebook ebook = new Ebook();
                Console.Write("Ingrese el Titulo: ");
                ebook.titulo = Console.ReadLine();
                Console.Write("Ingrese el Autor: ");
                ebook.autor = Console.ReadLine();
                Console.Write("Ingrese el Año: ");
                ebook.año = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese Cantidad de hojas: ");
                ebook.cantidadHojas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el Peso en MB: ");
                ebook.pesoMB = Convert.ToDouble(Console.ReadLine());
                ebooks.Add(ebook);

            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                Console.ReadKey();
                
            }
      
        }               
        public void agregarLibroFisico()
        {
          
            try
            {
                LibroFisico libroFisico = new LibroFisico();
                Console.Write("Ingrese el Titulo: ");
                libroFisico.titulo = Console.ReadLine();
                Console.Write("Ingrese el Autor: ");
                libroFisico.autor = Console.ReadLine();
                Console.Write("Ingrese el Año: ");
                libroFisico.año = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese Cantidad de hojas: ");
                libroFisico.agregarHojas(Convert.ToInt32(Console.ReadLine()));
                librosFisicos.Add(libroFisico);
            }
            catch (Exception e)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                Console.ReadKey();
                
            }
        }
        public void agregarRevista()
        {
            try
            {
                Revista revista = new Revista();
                Console.Write("Ingrese el Titulo: ");
                revista.titulo = Console.ReadLine();
                Console.Write("Ingrese el Autor: ");
                revista.autor = Console.ReadLine();
                Console.Write("Ingrese el Año: ");
                revista.año = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el Volumen: ");
                revista.volumen = Convert.ToInt32(Console.ReadLine());
                revistas.Add(revista);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                Console.ReadKey();
            }
            
        }
        public void mostrarEbooks()
        {
            if (ebooks.Count > 0)
            {
                foreach (var item in ebooks)
                {

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    item.MostrarDatos();
                    Console.ResetColor();
                    Console.WriteLine("------------------");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay Ebooks");
                Console.ResetColor();
            }
         
        }
        public void mostrarLibrosFisicos()
        {

            if (librosFisicos.Count > 0)
            {
                foreach (var item in librosFisicos)
                {

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    item.MostrarDatos();
                    Console.ResetColor();
                    Console.WriteLine("------------------");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay Libros Fisicos");
                Console.ResetColor();
            }
        }
        public void mostrarRevistas()
        {
            if (revistas.Count > 0)
            {
                foreach (var item in revistas)
                {

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    item.MostrarDatos();
                    Console.ResetColor();
                    Console.WriteLine("------------------");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay revistas");
                Console.ResetColor();
            }

        }
        //private double cargarHojas(string temp)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
     
    }
}
