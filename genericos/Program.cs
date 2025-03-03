﻿using System;
using System.Security.Permissions;


namespace genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista nombres = new Lista(4);
            ////nombres.Agregar(100);
            ////nombres.Agregar("Juan");
            ////nombres.Agregar(125);
            ////nombres.Agregar("Marco");
            //////se debe castear
            ////int nombre = (int)nombres.GetLista(2);
            ////Console.WriteLine(nombre.GetType());
            //nombres.Agregar(new Empleado(20000));
            //nombres.Agregar(new Empleado(20000));
            //nombres.Agregar(new Empleado(20000));
            //nombres.Agregar(new Empleado(20000));

            ////no tira error de tipo de dato hasta que se ejecuta
            //String nombre = (String)nombres.GetLista(2);

            Lista<Empleado> salarios = new Lista<Empleado>(4);
            salarios.Agregar(new Empleado(20000));
            salarios.Agregar(new Empleado(25000));
            salarios.Agregar(new Empleado(2000));
            salarios.Agregar(new Empleado(10000));
            Empleado salario = salarios.GetLista(2);
            Console.WriteLine(salario.GetSalario()+4);

            Lista<String> nombresEmpleados = new Lista<String>(3);
            nombresEmpleados.Agregar("Ana");
            nombresEmpleados.Agregar("Jorge");
            nombresEmpleados.Agregar("Santiago");
            Console.WriteLine(nombresEmpleados.GetLista(2));
                

        }
    }

    //Con GENERICS
    class Lista<T>
    {
        private T[] lista;
        private int cantidadElementos = 0;
        public Lista(int cantidadElementos)
        {
            lista = new T[cantidadElementos];
        }
        public void Agregar(T elemento)
        {
            lista[cantidadElementos] = elemento;
            cantidadElementos++;
        }
        public T GetLista(int indiceElemento)
        {
            return lista[indiceElemento];
        }
    }

    ////SIN GENERICS, USANDO HERENCIA
    //class Lista
    //{
    //    private Object[] lista;
    //    private int cantidadElementos=0;
    //    public Lista(int cantidadElementos)
    //    {
    //        lista = new Object[cantidadElementos];
    //    }
    //    public void Agregar(Object elemento)
    //    {
    //        lista[cantidadElementos] = elemento;
    //        cantidadElementos++;
    //    }

    //    public Object GetLista(int indiceElemento)
    //    {
    //        return lista[indiceElemento];
    //    }

    //}

    class Empleado
    {
        private double salario;
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }


}
