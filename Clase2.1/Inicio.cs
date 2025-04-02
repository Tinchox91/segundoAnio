using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Clases;
namespace Clase2._1
{
    internal class Inicio
    {
     static  private MaterialBibliografico mt = new MaterialBibliografico();
        //Crear la clase Ebook y LibroFísico, que son hijas de MaterialBibliografico y cuentan con los atributos pesoMB y cantidadHojas, respectivamente.

        //Además, hacen override del método que muestra los datos y le agregan los atributos propios.


        //CREAR CONSTRUCTORES, GETTER y SETTER DE TODAS.


        static void Main(string[] args)
        {
            bool salir ;
            do
            {
                
                salir = mostrarMenu();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
            } while (!salir);
            
        }
      static  public bool mostrarMenu()
        {
           
            string resp = "";
            bool salir = false;
            Console.WriteLine("1. Agregar Ebook");           
            Console.WriteLine("2. Agregar Libro Fisico");
            Console.WriteLine("3. Agregar Revista");
            Console.WriteLine("4. Mostrar Ebooks");
            Console.WriteLine("5. Mostrar Libros Fisicos");
            Console.WriteLine("6. Mostrar Revistas");
            Console.WriteLine("7. Salir");
            resp = Console.ReadLine();
            switch (resp)
            {
                case "1":
                    Console.WriteLine("Agregando Ebook");
                    mt.agregarEbook();                    
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Creado con exito!");
                    Console.ResetColor();
                    break; 
                case "2": Console.WriteLine("Agregando Libro Fisico ");
                    mt.agregarLibroFisico();                   
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Creado con exito!");
                    Console.ResetColor();
                    break;
                case "3": Console.WriteLine("Agregando Revista");
                    mt.agregarRevista();                    
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Creado con exito!");
                    Console.ResetColor();
                    break;
                case "4":
                    mt.mostrarEbooks();
                    break;
                case "5":
                    mt.mostrarLibrosFisicos();
                    break;
                case "6":
                    mt.mostrarRevistas();
                    break;
                default:
                    salir = true;
                    break;
            }
            return salir;
        }
    }
}
