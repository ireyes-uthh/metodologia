using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaufragoSatisfecho
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tipo;
            int Cantidad;
            string FPago;
            double Total=0;

            Console.WriteLine("Lista de hamburgesas");
            Console.WriteLine("1 Sencilla");
            Console.WriteLine("2 Doble");
            Console.WriteLine("3 Triple");
            Console.WriteLine("Selecciona un tipo de hamburgesa");
            Tipo = int.Parse(Console.ReadLine());

            if (Tipo<1 || Tipo>3)//(Tipo!=1 && Tipo!=2 && Tipo!=3)
            {
                Console.WriteLine("La opcion no es valida");
            }
            else
            {
                Console.WriteLine("¿Cuantas hamburgesas requieres?");
                Cantidad = int.Parse(Console.ReadLine());
                switch (Tipo)
                {
                    case 1:
                        Total = Cantidad * 20;
                        break;
                    case 2:
                        Total = Cantidad * 25;
                        break;
                    case 3:
                        Total = Cantidad * 28;
                        break;
                }
                /*
                if (Tipo == 1)
                {
                    Total = Cantidad * 20;
                }
                else if (Tipo.Equals(2))
                {
                    Total = Cantidad * 25;
                }
                else if (Tipo is 3)
                {
                    Total = Cantidad * 28;
                }
                */
                Console.WriteLine("Cual es tu forma de pago? (E) Efectivo (T) Tarjeta");
                FPago = Console.ReadLine();
                if (FPago != "T" && FPago !="t" && FPago!="E" && FPago != "e")
                {
                    Console.WriteLine("La forma de pago es incorrecta");
                }
                else
                {
                    if (FPago == "T" || FPago.Equals("t"))
                    {
                        double cargo = Total * .05;
                        Total = Total + cargo;
                        Console.WriteLine("Tiene un cargo por pago con tarjeta de: " + cargo.ToString("C"));
                    }
                    else
                    {
                        Console.WriteLine("No tiene cargo extra");
                    }

                    Console.WriteLine("El total a pagar es de: " + Total.ToString("C"));
                }
            }

           
            Console.ReadKey();
        }
    }
}
