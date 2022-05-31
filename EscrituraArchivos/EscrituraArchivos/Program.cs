using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //Si el archivo no existe creara el documento, si ya existe escribira en el 
            //True es para agregar y sobreescribir 

            string[] lineas =
            { "primera linea ", 
              "segunda linea", 
              "tercera linea" 
            };

            //Recorre el arreglo 
            foreach (string line in lineas)
            {
                sw.WriteLine(line);
            }
            sw.Close();

            Console.WriteLine("Escribiendo archivo...");
            Console.ReadKey();
        }
    }
}
