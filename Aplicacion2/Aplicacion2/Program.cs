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
            int contador1=0;
            Console.WriteLine("Contador1");
            contador1 = contador1 + 4;//4
            Console.WriteLine(contador1);
            contador1 = contador1 + 4;//8
            Console.WriteLine(contador1);
            contador1 = contador1 + 4; //12
            Console.WriteLine(contador1);
            contador1 = contador1 + 4; //16
            Console.WriteLine(contador1);
            contador1 = contador1 + 4; //20
            Console.WriteLine(contador1);

            Console.WriteLine("Contador2");
            int contador2 = 10;
            contador2 = contador2 - 1;//9
            Console.WriteLine(contador2);
            contador2 = contador2 - 1;//8
            Console.WriteLine(contador2);
            contador2 = contador2 - 1;//7
            Console.WriteLine(contador2);
            contador2 = contador2 - 1;//6
            Console.WriteLine(contador2);

            int acumulador = 0;
            Console.WriteLine("Acumulador");
            acumulador = acumulador + 2;//2
            Console.WriteLine(acumulador);
            acumulador = acumulador + 10;//12
            Console.WriteLine(acumulador);
            acumulador = acumulador + 2;//14
            Console.WriteLine(acumulador);
            acumulador = acumulador + 4;//18
            Console.WriteLine(acumulador);

            Console.ReadKey();
        }
    }
}
