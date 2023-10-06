using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos2_DLL.Clases
{
    internal class Ejercicio1
    {
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
    }
}
