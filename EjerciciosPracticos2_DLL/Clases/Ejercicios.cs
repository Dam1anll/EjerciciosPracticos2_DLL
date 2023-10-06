using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos2_DLL.Clases
{
    internal class Ejercicios
    {
        //Ejercicio 1
        public void SumarArreglos()
        {
            Console.Write("Ingrese la longitud de los Arreglos: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] arregloUno = new int[longitud];
            int[] arregloDos = new int[longitud];
            int[] arregloTres = new int[longitud];

            Console.WriteLine("Ingrese los valores para el primer arreglo:");
            for (int x = 0; x < longitud; x++)
            {
                arregloUno[x] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ingrese los valores para el segundo arreglo:");
            for (int x = 0; x < longitud; x++)
            {
                arregloDos[x] = Convert.ToInt32(Console.ReadLine());
            }

            for (int x = 0; x < longitud; x++)
            {
                arregloTres[x] = arregloUno[x] + arregloDos[x];
            }

            Console.WriteLine("Resultados:");
            for (int x = 0; x < longitud; x++)
            {
                Console.WriteLine($"{arregloUno[x]} + {arregloDos[x]} = {arregloTres[x]}");
            }
        }

        //Ejercicio 2

        //Ejercicio 4
        public void MostrarArreglos()
        {
            Console.Write("Ingrese la longitud del arreglo: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            if (longitud <= 0)
            {
                Console.WriteLine("El tamaño del arreglo debe ser mayor que cero.");
                return;
            }

            int[] arreglo = new int[longitud];
            HashSet<int> numerosIngresados = new HashSet<int>();

            for (int i = 0; i < longitud; i++)
            {
                int valor;
                bool valorValido = false;

                do
                {
                    Console.Write($"Ingrese el valor {i + 1}: ");
                    valor = Convert.ToInt32(Console.ReadLine());

                    if (numerosIngresados.Contains(valor))
                    {
                        Console.WriteLine("Este valor ya ha sido ingresado.");
                    }
                    else
                    {
                        valorValido = true;
                        numerosIngresados.Add(valor);
                        arreglo[i] = valor;
                    }
                } while (!valorValido);
            }

            Console.WriteLine("\nContenido del arreglo:");
            foreach (int num in arreglo)
            {
                Console.WriteLine(num);
            }
        }
    }
}
