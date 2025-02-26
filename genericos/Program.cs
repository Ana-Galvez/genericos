using System;


namespace genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //SIN GENERICS, USANDO HERENCIA
    class Objetos
    {
        private Object[] lista;
        private int cantidadElementos=0;
        public Objetos(int cantidadElementos)
        {
            lista = new Object[cantidadElementos];
        }
        public void Agregar(Object elemento)
        {
            lista[cantidadElementos] = elemento;
            cantidadElementos++;
        }

        public Object GetLista(int cantidadElementos)
        {
            return lista[cantidadElementos];
        }

    }
}
