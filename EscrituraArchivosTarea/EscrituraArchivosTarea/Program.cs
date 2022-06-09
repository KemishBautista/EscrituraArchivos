using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EscrituraArchivosTarea
{
    class Program
    {
        //Clase ListaAnimes
        public class ListaAnimes
        {
            public string NombreAnimes;
            public int Año;

            public ListaAnimes(string NombreAnimes, int Año)
            {
                this.NombreAnimes = NombreAnimes;
                this.Año = Año;
            }

            public void DesplegarDatos()
            {
                Console.WriteLine("El anime visto es " + NombreAnimes + ", del año " + Año);
            }
        }

        static void Main(string[] args)
        {
            string NombreAnimes;
            int Año;

            StreamWriter sw = new StreamWriter("Animes.txt", true);
            char opcion;

            do
            {

                Console.WriteLine("Para continuar presione S, de lo contrario presione N");
                Console.Write("Desea continuar?: ");
                opcion = char.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 'S':
                        {
                            Console.Write("Nombre del anime: ");
                            NombreAnimes = Console.ReadLine();
                            Console.Write("Año del anime: ");
                            Año = int.Parse(Console.ReadLine());
                            ListaAnimes Datos = new ListaAnimes(NombreAnimes,Año);
                            
                            sw.WriteLine(Datos.NombreAnimes + "\t\t" + Datos.Año);
                            Datos.DesplegarDatos();

                            Console.WriteLine("Escribiendo archivo...");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;

                    case 'N':
                        {
                            Console.WriteLine("Presione ENTER para salir del programa");
                            sw.Close();//El archivo siempre se cierra
                        }
                        break;

                    default:
                        Console.WriteLine("OPCION INCORRECTA, PRESIONE S O N (CON MAYUSCULA)");
                        break;
                }
            } while (opcion != 'N');
        }
    }
}
