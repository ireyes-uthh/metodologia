using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int contador1=0;
            //Console.WriteLine("Contador1");
            //contador1 = contador1 + 4;//4
            //Console.WriteLine(contador1);
            //contador1 = contador1 + 4;//8
            //Console.WriteLine(contador1);
            //contador1 = contador1 + 4; //12
            //Console.WriteLine(contador1);
            //contador1 = contador1 + 4; //16
            //Console.WriteLine(contador1);
            //contador1 = contador1 + 4; //20
            //Console.WriteLine(contador1);

            //Console.WriteLine("Contador2");
            //int contador2 = 10;
            //contador2 = contador2 - 1;//9
            //Console.WriteLine(contador2);
            //contador2 = contador2 - 1;//8
            //Console.WriteLine(contador2);
            //contador2 = contador2 - 1;//7
            //Console.WriteLine(contador2);
            //contador2 = contador2 - 1;//6
            //Console.WriteLine(contador2);

            //int acumulador = 0;
            //Console.WriteLine("Acumulador");
            //acumulador = acumulador + 2;//2
            //Console.WriteLine(acumulador);
            //acumulador = acumulador + 10;//12
            //Console.WriteLine(acumulador);
            //acumulador = acumulador + 2;//14
            //Console.WriteLine(acumulador);
            //acumulador = acumulador + 4;//18
            //Console.WriteLine(acumulador);

            //calcular el promedio de 5 calificaciones sin ciclos
            //int c1, c2, c3, c4, c5, promedio;

            //Console.WriteLine("Ingresa C1");
            //c1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingresa C2");
            //c2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingresa C3");
            //c3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingresa C4");
            //c4 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingresa C5");
            //c5 = int.Parse(Console.ReadLine());

            //promedio = (c1 + c2 + c3 + c4 + c5) / 5;

            //Console.WriteLine("tu promedio es "+promedio);

            //ciclo for
            int Ncalificaciones =0;
            Console.WriteLine("Cuantas calificaciones va a promediar");
            Ncalificaciones = Convert.ToInt32(Console.ReadLine());


            int cal=0, prom=0;
            for (int i = 1; i <= Ncalificaciones; i++)
            {
                //instrucciones que se repiten
                Console.WriteLine("Ingresa Calificacion " + i);
                cal = int.Parse(Console.ReadLine());
                prom = prom + cal;
               // i = i+2;
               //i += 10;
            }
            prom = prom / Ncalificaciones;
            Console.WriteLine("tu promedio es " + prom);
            Console.ReadKey();
        }
    }
}
