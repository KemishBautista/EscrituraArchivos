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
        public class ListaAnimes
        {
            string[] Animes = new string[5];
            int[] Años = new int[5];

            public ListaAnimes(string[] Animes, int[] Años)
            {
                this.Animes = Animes;
                this.Años = Años;
            }
            
            public void DesplegarDatos()
            {
                for (int j=0;j<2;j++)
                {
                    Console.WriteLine("El anime a ver es " + Animes[j] + " del año " + Años[j]);
                }
            }
        }

        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Animes.txt", true);

            string[] Animes = new string[2];
            int[] Años = new int[2]; 

            for (int i=0;i<2;i++)
            {
                Console.Write("Nombre del anime: ");
                Animes[i] = Console.ReadLine();

                Console.Write("Año del anime: ");
                Años[i] = int.Parse(Console.ReadLine());
            }

            foreach (string anime in Animes)
            {
               foreach(int año in Años)
               {
                    sw.WriteLine(anime + " de " + año);
               }
            }

            sw.Close();//El archivo siempre se cierra

            ListaAnimes Nombres = new ListaAnimes(Animes, Años);
            Nombres.DesplegarDatos();

            Console.WriteLine("Escribiendo archivo...");
            Console.ReadKey();
        }
    }
}
