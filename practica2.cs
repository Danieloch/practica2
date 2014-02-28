using System;

namespace Practica1
{
	class Precios
	{

		public static void Main(string[] args)
		{

		double producto1,producto2,producto3;
		string tipodeproducto,tipodeproducto2,tipodeproducto3;
		double iva=1.16,precio,total;
		float costo,costo2,costo3;
		

		Console.WriteLine("Bienvenido");
		Console.WriteLine();
         Console.WriteLine("tipodeproducto: ");
               tipodeproducto = (Console.ReadLine());;
		Console.Write("Ingresa el precio del producto :");
	    costo=float.Parse (Console.ReadLine ());
	    producto1=costo*iva;

	    	    Console.WriteLine("El precio con iva del primer producto es :"+producto1);

	    Console.WriteLine("\n\n");

         Console.WriteLine("tipodeproducto2: ");
                tipodeproducto2 = (Console.ReadLine());
	    Console.Write("Ingresa el segundo precio del producto  :");
	    costo2=float.Parse (Console.ReadLine ());
	    producto2=costo2*iva;

	    Console.WriteLine("El precio con iva del segundo producto es :"+producto2);


	    Console.WriteLine("\n\n");
        Console.WriteLine("tipodeproducto3: ");
                tipodeproducto3 = (Console.ReadLine());
	    Console.Write("Ingresa el tercer precio del producto  :");
	    costo3=float.Parse (Console.ReadLine ());
	    producto3=costo3*iva;

	    Console.WriteLine("El precio con iva del segundo producto es :"+producto3);

	    Console.WriteLine("\n");
	    
	   
	    Console.WriteLine("\n");
	    total=producto1+producto2+producto3;
	    Console.WriteLine("El total de los productos es  :"+total);

	    Console.ReadKey(true);
		}


	}
}