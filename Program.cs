using System;
// Nueva directiva "System.IO"
using System.IO;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se intenta ejecutar el código dentro del try.
            try
            {
                Console.WriteLine("Introduce el valor a:");
                // Se transforma a "float" lo que se introduzca en la consola.
                float a = float.Parse(Console.ReadLine());

                Console.WriteLine("Introduce el valor b:");
                float b = float.Parse(Console.ReadLine());

                // float a = 10f;
                // float b = 2f;

                float result = a / b;
                Console.WriteLine($"{a} / {b} = {result}");

                //Requiere agregar directiva "using.IO"
                using (StreamWriter sw = new StreamWriter("operacion.txt"))
                {
                    sw.WriteLine($"{a} / {b} = {result}");
                }
            }

            // catch (System.Exception) - Atrapa cualquier Exception.
            catch (System.FormatException) // Atrapar solamente las Exception que nos interesan
            {
                // Si ocurre una Excepción en el try, se ejecuta el código en este catch
                Console.WriteLine("Error, por favor introduce números válidos.");

                // Se comentó el "throw", pero si se activa de nuevo tira el error(si lo hay) en la consola.
                // throw;
            }
            finally
            {
                Console.WriteLine("Este mensaje siempre se muestra.");
            }
        }
    }
}
