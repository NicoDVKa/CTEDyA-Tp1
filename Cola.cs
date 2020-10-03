/*
 * Creado por SharpDevelop.
 * Usuario: User
 * Fecha: 14/09/2020
 * Hora: 11:40 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP1
{
	public class Cola<T>
	{

		
		private List<T> datos = new List<T>();
	
		public void encolar(T elem) {
			this.datos.Add(elem);
		}
	
		public T desencolar() {
			T temp = this.datos[0];
			this.datos.RemoveAt(0);
			return temp;
		}
		
		public T tope() {
			return this.datos[0]; 
		}
		
		//Cantidad de elementos de una cola.

		public int cantidad()
        {
			return this.datos.Count;
		}
			
			public bool esVacia() {
				return this.datos.Count == 0;
			}
		}
}
