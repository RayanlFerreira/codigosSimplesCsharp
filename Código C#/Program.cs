using System;

namespace Código_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo");

            /*1-Ler temperatura em graus Celsius e transformá-la em graus Fahrenheit*/
            /*
            float celsius, fahrenheit;

            Console.WriteLine("Me diga a temperatura em graus celsius:");
            celsius = int.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("A temperatura em fahrenheit é " + fahrenheit +"°F");
            */
            /*----------------------------------------------------------------------*/

            /*2-Cálculo de um saláriolíquido de um professor. Serão fornecidos valor dahora aula, númerode aulas dadas e o % de desconto do INSS.*/
            float dinheiroHora,INSS,salario;
            int aulas;

            Console.WriteLine("Diga o valor que você recebe por horas de aulas: ");
            dinheiroHora = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Quantas aulas foram dadas ? ");
            aulas = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a porcentagem de desconto do INSS de acordo com seu salário? ");
            INSS = float.Parse(Console.ReadLine());

            salario = (dinheiroHora * aulas);
            salario = salario - (salario * INSS/100);

            Console.WriteLine("Seu salário é de " + salario +" reais.");
        }
    }
}
