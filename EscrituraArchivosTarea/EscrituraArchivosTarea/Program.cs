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
        //Clase ListaAnimales
        public class ListaAnimes
        {
            //Declaracion de campos
            string[] Animes = new string[5];
            int[] Años = new int[5];


            //Constructor de la clase
            public ListaAnimes(string[] Animes, int[] Años)
            {
                this.Animes = Animes;
                this.Años = Años;
            }
            
            //Metodo para desplegar la informacion escrita
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
            //Codigo dentro de un Try en caso de error
            try
            {
                //Creacion del StreamWriter para el archivo
                StreamWriter sw = new StreamWriter("Animes.txt", true);

                //Declaracion de variables
                string[] Animes = new string[2];
                int[] Años = new int[2];

                //Ciclo for para introducir los datos
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("Nombre del anime: ");
                    Animes[i] = Console.ReadLine();

                    Console.Write("Año del anime: ");
                    Años[i] = int.Parse(Console.ReadLine());

                    Console.Clear();
                }

                //Creacion del objeto e invocacion del metodo para desplegar
                ListaAnimes Nombres = new ListaAnimes(Animes, Años);
                Nombres.DesplegarDatos();

                //Ciclo foreach para guardar el archivo
                foreach (var registro in Animes.Zip(Años, Tuple.Create)) //En el registro me salian duplicados los datos, encontre este codigo para que salgan bien ambos datos
                {

                    sw.WriteLine(registro.Item1 + " de " + registro.Item2);

                }

                sw.Close();//El archivo siempre se cierra


                Console.WriteLine("Escribiendo archivo...");
                Console.ReadKey();
            }
            //Catch para detectar el error e imprimir el mensaje
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
