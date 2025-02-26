using System;


namespace genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista nombres = new Lista(4);
            nombres.Agregar(100);
            nombres.Agregar("Juan");
            nombres.Agregar(125);
            nombres.Agregar("Marco");
            int nombre = (int)nombres.GetLista(2);
            Console.WriteLine(nombre.GetType());
        }
    }

    //SIN GENERICS, USANDO HERENCIA
    class Lista
    {
        private Object[] lista;
        private int cantidadElementos=0;
        public Lista(int cantidadElementos)
        {
            lista = new Object[cantidadElementos];
        }
        public void Agregar(Object elemento)
        {
            lista[cantidadElementos] = elemento;
            cantidadElementos++;
        }

        public Object GetLista(int indiceElemento)
        {
            return lista[indiceElemento];
        }

    }
}
