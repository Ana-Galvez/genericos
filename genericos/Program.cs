using System;


namespace genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista nombres = new Lista(4);
            nombres.Agregar("Ana");
            nombres.Agregar("Juan");
            nombres.Agregar("Ezi");
            nombres.Agregar("Marco");
            Console.WriteLine(nombres.GetLista(2));
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
