using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de números que desea digitar:");
        int cantidadNumeros = LeerEnteroPositivo();

        int[] numeros = LeerNumeros(cantidadNumeros);

        OrdenarNumeros(numeros);

        MostrarNumerosOrdenados(numeros);

        Console.ReadLine();
    }

    // Método para leer un número entero positivo desde la consola
    static int LeerEnteroPositivo()
    {
        int numero;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
            {
                break;
            }
            Console.WriteLine("Debe ingresar un número entero positivo. Inténtelo de nuevo:");
        }
        return numero;
    }

    // Método para leer un array de números enteros desde la consola
    static int[] LeerNumeros(int cantidad)
    {
        int[] numeros = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            while (true)
            {
                Console.Write($"Ingrese el número #{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    break;
                }
                Console.WriteLine("Debe ingresar un número entero válido. Inténtelo de nuevo:");
            }
        }
        return numeros;
    }

    // Método para ordenar los números utilizando el método de ordenamiento burbuja
    static void OrdenarNumeros(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Intercambiar elementos
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    // Método para mostrar los números ordenados
    static void MostrarNumerosOrdenados(int[] array)
    {
        Console.WriteLine("\nNúmeros ordenados:");
        foreach (int numero in array)
        {
            Console.WriteLine(numero);
        }
    }
}
