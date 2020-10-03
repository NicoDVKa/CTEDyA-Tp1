/*
 * Creado por SharpDevelop.
 * Usuario: User
 * Fecha: 14/09/2020
 * Hora: 11:39 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Ejemplo de arbol general.
			 
			ArbolGeneral<int> arbol= new ArbolGeneral<int>(1);
			ArbolGeneral<int> primerHijo=new ArbolGeneral<int>(2);
			ArbolGeneral<int> segundoHijo=new ArbolGeneral<int>(3);
			ArbolGeneral<int> tercerHijo=new ArbolGeneral<int>(4);
			ArbolGeneral<int> cuartoHijo=new ArbolGeneral<int>(11);

			ArbolGeneral<int> hijoDeCuarto = new ArbolGeneral<int>(88);
			ArbolGeneral<int> nietoDeCuarto = new ArbolGeneral<int>(100);

			arbol.agregarHijo(primerHijo);
			arbol.agregarHijo(segundoHijo);
			arbol.agregarHijo(tercerHijo);
			arbol.agregarHijo(cuartoHijo);
			
			
			primerHijo.agregarHijo(new ArbolGeneral<int>(5));
			primerHijo.agregarHijo(new ArbolGeneral<int>(6));
			
			segundoHijo.agregarHijo(new ArbolGeneral<int>(7));
			
			tercerHijo.agregarHijo(new ArbolGeneral<int>(8));
			
			cuartoHijo.agregarHijo(hijoDeCuarto);
			hijoDeCuarto.agregarHijo(nietoDeCuarto);



			Console.Write("Preorden: "); arbol.preorden();
			Console.WriteLine();
			Console.Write("Inorden: "); arbol.inorden();
			Console.WriteLine();
			Console.Write("Postorden: "); arbol.postorden();
			Console.WriteLine();
			Console.Write("Por Niveles: "); arbol.porNiveles();
			Console.WriteLine();

			Console.WriteLine("=======================================================================================");

			Console.WriteLine("La cantidad de hijos del nodo raiz es de: {0}",arbol.getHijos().Count);

			Console.WriteLine("La altura del arbol,sin contar la raiz,es de: {0}",arbol.altura());

			int dato = 7;

			Console.WriteLine("El nivel del dato {0} es: {1}",dato,arbol.nivel(dato));
			Console.WriteLine("El ancho del arbol es: {0}",arbol.ancho());
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}