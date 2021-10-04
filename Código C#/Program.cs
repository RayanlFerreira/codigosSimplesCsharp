using System;

namespace Código_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*1-Ler temperatura em graus Celsius e transformá-la em graus Fahrenheit*/
            int celsius, fahrenheit;

            Console.WriteLine("Me diga a temperatura em graus celsius:");
            celsius = int.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("A temperatura em fahrenheit é " + fahrenheit +"°F");
            /*----------------------------------------------------------------------*/
        }
    }
}
