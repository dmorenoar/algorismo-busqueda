using System;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[100_000_000];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i; // Llenamos el array con números del 0 al 999,999
        }

        int target = 99_999_999; //Es lo mismo que 99999999

        int left = 0;
        int right = numbers.Length - 1;

        bool found = false;

        // Capturamos el tiempo de ejecución
        DateTime startTime;
        startTime = DateTime.Now;

        while (left <= right && !found)
        {
            int mid = (left + right) / 2;

            if (numbers[mid] == target)
            {
                found = true;
                Console.WriteLine($"Num {target} encontrado en el índice {mid} (binary search).");
            }else if (numbers[mid] < target)
            {
                // Buscar en la mitad derecha
                left = mid + 1;
            }
            else
            {
                // Buscar en la mitad izquierda
                right = mid - 1;
            }
        }

        // Capturamos el tiempo de finalización
        DateTime endTime;
        endTime = DateTime.Now;

        // Calcula la diferencia (duración)
        TimeSpan duration;
        duration = endTime - startTime;

        Console.WriteLine("Temps d'execució: " + duration.TotalMilliseconds + " ms");

        if (!found) { 
            Console.WriteLine($"Num {target} no encontrado en el array.");
        }


        // Capturamos el tiempo de ejecución
        startTime = DateTime.Now;
        for (int i = 0; i < numbers.Length; i++) { 
            if(numbers[i] == target) { 
                Console.WriteLine($"Num {target} encontrado en el índice {i} (búsqueda lineal).");
                break;
            }
        }

        // Capturamos el tiempo de finalización
        endTime = DateTime.Now;

        // Calcula la diferencia (duración)
        duration = endTime - startTime;

        Console.WriteLine("Temps d'execució: " + duration.TotalMilliseconds + " ms");



    }
}
