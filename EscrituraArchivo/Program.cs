﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivo
{
    class Program
    {
        public class Clientes
        {
            //Campos de la clase
            public string Nombre;
            public string Apellido;
            public int ID;

            public Clientes(string Nombre, string Apellido, int ID)
            {
                this.Nombre = Nombre;
                this.Apellido = Apellido;
                this.ID = ID;
            }
            ~Clientes()
            {
                Console.WriteLine("Memoria liberada de la clase clientes");
            }
        }
        static void Main(string[] args)
        {
            string Nombre;
            string Apellido;
            int ID;

            StreamWriter sw = new StreamWriter("usuarios.txt", true); //Texto de registro de clientes
            //si el archivo no existe lo creara
            //si ya existe, escribira en el

            Console.Write("Dame el nombre: ");
            Nombre = Convert.ToString(Console.ReadLine());
            Console.Write("Dame el apellido: ");
            Apellido = Convert.ToString(Console.ReadLine());
            Console.Write("Dame el ID: ");
            ID = int.Parse(Console.ReadLine());

            //Creacion de un objeto
            Clientes C1 = new Clientes(Nombre, Apellido, ID);

            //Es el texto que se escribira despues del texto que ya esta en el archivo
            string[] Lines ={
               "Nombre: "+C1.Nombre
               ,"Apellido: "+C1.Apellido
               ,"ID: "+C1.ID.ToString()
               ,"\n"
            };

            //Se escribe en el archivo
            foreach (string Line in Lines)
            {
                sw.WriteLine(Line);
            }
            sw.Close();//se debe cerrare el archivo

            Console.WriteLine("Escrbiendo en el archivo.....");
            Console.ReadLine();
        }
    }
}
