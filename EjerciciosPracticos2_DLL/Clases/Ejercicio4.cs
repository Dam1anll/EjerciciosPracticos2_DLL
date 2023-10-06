using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos2_DLL.Clases
{
    internal class Ejercicio4
    {
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
                        Console.WriteLine("Este valor ya ha sido ingresado. Intente nuevamente.");
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
