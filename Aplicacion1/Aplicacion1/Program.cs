using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            string nombre;
            //int edad;
            //edad = 30;
            int edad;
            //float sueldo1;
            //decimal sueldo2;
            double sueldo;


            Console.WriteLine("Ya se programar en C#");
            Console.WriteLine("¿Cual es tu nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine("¿Cual es tu edad?");
            //string cad = Console.ReadLine();
            //edad = int.Parse(cad);
            //edad = int.Parse(Console.ReadLine());
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu sueldo");
            //sueldo = Convert.ToDouble(Console.ReadLine());
            sueldo = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("Tu edad es " + edad);
            Console.WriteLine("Tu sueldo es " + sueldo.ToString("C"));


            if (edad >= 18)
            {
                //instrucciones
                Console.WriteLine("eres mayor de edad");

            }
            else
            {
                Console.WriteLine("eres menor de edad");
            }

            Console.ReadKey();

        }
    }
}
