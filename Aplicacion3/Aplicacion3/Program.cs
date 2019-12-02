/*
 * Created by SharpDevelop.
 * User: Innego
 * Date: 26/11/2019
 * Time: 10:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Aplicacion3
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombres="";
			string n1="";
			string sexo="";
			
			Console.WriteLine("Ingresa nombre 1");
			n1=Console.ReadLine();
			Console.WriteLine("Sexo F/M");
			sexo=Console.ReadLine();
			nombres=nombres+"\n1.-"+n1+" sexo "+sexo ;
			
			Console.WriteLine("Ingresa nombre 2");
			n1=Console.ReadLine();
			Console.WriteLine("Sexo F/M");
			sexo=Console.ReadLine();
			nombres=nombres+"\n2.-"+n1+" sexo "+sexo ;

			Console.WriteLine(nombres);

			Console.ReadKey();
		}

	}
}