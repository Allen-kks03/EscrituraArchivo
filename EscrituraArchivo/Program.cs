using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nom;
            StreamWriter sw = new StreamWriter("Ejemplo.txt", true);

            Console.Write("Dame el nombre: ");
            Nom = Convert.ToString(Console.ReadLine());

            string[] Lines ={
                Nom
            };

            foreach (string Line in Lines)
            {
                sw.WriteLine(Line);
            }
            sw.Close();//se debe cerrare el archivo

            Console.ReadLine();
        }
    }
}
