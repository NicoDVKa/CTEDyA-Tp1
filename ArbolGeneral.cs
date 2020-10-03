/*
 * Creado por SharpDevelop.
 * Usuario: User
 * Fecha: 14/09/2020
 * Hora: 11:39 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP1
{
	public class ArbolGeneral<T>
	{
		
		private T dato;
		private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();

		public ArbolGeneral(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			return hijos;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Add(hijo);
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Remove(hijo);
		}
	
		public bool esHoja() {
			return this.getHijos().Count == 0;
		}
	
		//Ver el dato de los nodos hijos
		public void verHijos(){
			foreach(ArbolGeneral<T> hijo in this.getHijos()){
				Console.WriteLine(hijo.getDatoRaiz()+" ");
			}
		}
		
		//Recorridos
		public void preorden(){
			Console.Write(this.getDatoRaiz()+" ");
			
				foreach(ArbolGeneral<T> hijo in this.getHijos()){
					hijo.preorden();
				}
			
		}
		public void inorden(){
			if(this.getHijos().Count>0){
				this.getHijos()[0].inorden();
			}
			Console.Write(this.getDatoRaiz()+" ");
			for(int i = 1;i<this.getHijos().Count;i++){
				this.getHijos()[i].inorden();
			}
		}
		public void postorden(){
			foreach(ArbolGeneral<T> hijo in this.getHijos()){
				hijo.postorden();
			}
			Console.Write(this.getDatoRaiz()+" ");
		}
		public void porNiveles(){
			Cola <ArbolGeneral<T>> cola = new Cola<ArbolGeneral<T>>();
			cola.encolar(this);
			while(!cola.esVacia()){
				ArbolGeneral<T> nodo=cola.desencolar();
				Console.Write(nodo.getDatoRaiz()+" ");
				if(nodo.getHijos().Count!=0){
					foreach(ArbolGeneral<T> hijo in nodo.getHijos()){
						cola.encolar(hijo);
					}
				}
					
			}
		}

		//Altura del arbol.
		public int altura(){
			int alturaMaxima = 0;

			if (this.esHoja()) return 0;
            

			
			foreach (ArbolGeneral<T> hijo in this.getHijos())
			{
				 int alturaHijo = hijo.altura();
				if (alturaHijo > alturaMaxima) alturaMaxima = alturaHijo;
				
			}
			
			return alturaMaxima+1;
        }

		//Nivel
		public int nivel(T dato)
        {
			int nivel = 0;

            if (this.getDatoRaiz().ToString()==dato.ToString()){ //Chequea la raiz
				return 0;
            }

			foreach (ArbolGeneral<T> hijo in this.getHijos())
			{
			
				nivel=hijo.nivel(dato);
				nivel++;
				if (nivel != 0) return nivel;

			}
			return -1;
        }

		//Ancho
		public int ancho()
        {

			if (this.esHoja()) return 1; 

			Cola<ArbolGeneral<T>> cola = new Cola<ArbolGeneral<T>>();
			cola.encolar(this); //Encolas la raiz
			int ancho = 0;
			
			while (!cola.esVacia()) //Mientras la cola no este vacia
			{
				int anchoTemporal = cola.cantidad();
				if (anchoTemporal > ancho) ancho = anchoTemporal;

                while (anchoTemporal-->0)
                {
					ArbolGeneral<T> nodo = cola.desencolar();
					foreach (ArbolGeneral<T> hijo in nodo.getHijos())
					{
						cola.encolar(hijo);
					}
				}
			}
			return ancho;
        }
		
		
		

	}
}
