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
            StreamWriter sw = new StreamWriter("Ejemplo.txt", true);
            //Si el archivo no existe creara el documento, si ya existe escribira en el 
            //True es para agregar y sobreescribir 

            string[] lineas = new string[2];

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Escribe un nombre: ");
                lineas[i] = Console.ReadLine();
            }

            //Recorre el arreglo 
            foreach (string line in lineas)
            {
                sw.WriteLine(line);
            }
            sw.Close();//El archivo siempre se cierra

            Console.WriteLine("Escribiendo archivo...");
            Console.ReadKey();
        }
    }
}
