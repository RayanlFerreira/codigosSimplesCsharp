using System;

namespace Código_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo");

            /*1-Ler temperatura em graus Celsius e transformá-la em graus Fahrenheit*/
            float celsius, fahrenheit;

            Console.WriteLine("Me diga a temperatura em graus celsius:");
            celsius = int.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("A temperatura em fahrenheit é " + fahrenheit +"°F");
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
            /*----------------------------------------------------------------------*/

            /*3- Ler  1  número.  Se  positivo,  imprimir  raiz  quadrada,  senão  o quadrado.*/
            float num;

            Console.WriteLine("Digite um número : ");
            num = float.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("A raiz quardrada é: " + Math.Sqrt(num));
            }
            else
            {
                Console.WriteLine("O quadrado desse número: " + num * num);
            }
            /*----------------------------------------------------------------------*/

            /*4- Faça um programa que calcule e mostre a área de um círculo.: Obs.: Crie uma constante para π, sabendo que ele vale 3.1415.*/
            float raio;
            const double pi = 3.1415;
            double area;

            Console.WriteLine("Me diga o valor do raio de um circulo : ");
            raio = float.Parse(Console.ReadLine());

            area = pi * (raio * raio);

            Console.WriteLine("A área da circunferência é: " + area);
            /*----------------------------------------------------------------------*/

            /*5- Faça  um  programa  que  receba  o  ano  de  nascimento  de  uma pessoa  e  o  ano  atual,  calcule  e  mostre:  a.  A  idade  dessa  pessoa;  b.  Quantos anos essa pessoa terá em 2022.*/
            int anonascimento, idade, idade2022;
            const int ano2022 = 2022;
            int anoAtual = 2021;

            Console.WriteLine("Me diga o ano em que você nasceu :");
            anonascimento = int.Parse(Console.ReadLine());

            idade = anoAtual - anonascimento;
            idade2022 = ano2022-anonascimento;
            Console.WriteLine("Você atualmente tem "+ idade +"anos e em 2022 você terá "+ idade2022);
            /*----------------------------------------------------------------------*/

            /*6- O custo ao consumidor de um carro novo é a soma do preço de fábrica  com  o  percentual  de  lucro  do  distribuidor  e  dos  impostos  aplicados  ao preço  de  fábrica.  Faça  um  programa  que  receba  o  preço  de  fábrica  de  um veículo, o percentual de lucro do distribuidor e o percentual de imposto. Calcule e  mostre:  a.  O  valor  correspondente  ao  lucro  do  distribuidor;  b.  O  valor correspondente aos impostos; c. O preço final do veículo.*/
            float valorF, imposto, lucro, preco;

            Console.WriteLine("Digite o valor do veículo vindo da fábrica: ");
            valorF = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o imposto aplicado no valor do veículo vindo da fábrica: ");
            imposto = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o percentual de lucro? ");
            lucro = float.Parse(Console.ReadLine());

            imposto = valorF * (imposto/100);
            lucro = valorF * (lucro/100);

            preco = valorF + imposto + lucro;

            Console.WriteLine("O valor de lucro do distribuidor é R$" + lucro);
            Console.WriteLine("O valor do imposto é R$" + imposto);
            Console.WriteLine("O preço do veículo é R$" + preco);

            /*7- Cada degrau de uma escada tem X de altura. Faça um programa que  receba  essa  altura  e  a  altura  que  o  usuário  deseja  alcançar  subindo  a escada.  Calcule  e  mostre  quantos degraus o  usuário deverá  subir  para  atingir seu objetivo, sem se preocupar com a altura do usuário.*/
            int alturaDegrau, alturaDesejada, numDegrau;

            Console.WriteLine("Qual a altura de cada degrau em CM?");
            alturaDegrau = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a altura que você quer atingir em CM ?");
            alturaDesejada = int.Parse(Console.ReadLine());

            numDegrau = alturaDesejada/alturaDegrau;
            Console.WriteLine("O número de degraus necessários para atingir a altura desejada é de "+ numDegrau);
            /*----------------------------------------------------------------------*/

            /*8-Faça um programa que receba o número de horas trabalhadas e o  valor  do  salário  mínimo.  Calcule  e  mostre  o  salário  a  receber  seguindo  as regras abaixo: a. a hora trabalhada vale a metade do salário mínimo; b. o salário bruto equivale ao número de horas trabalhadas multiplicado pelo valor da hora trabalhada; c. oimposto equivale a 3% do salário bruto; d. o salário a receber equivale ao salário bruto menos o imposto. */
            float horas, salarioMinimo, horaTrabalhada;
            double impostoGov, salarioBruto;

            Console.WriteLine("Digite as horas trabalhadas");
            horas = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do salario minimo");
            salarioMinimo = float.Parse(Console.ReadLine());

            horaTrabalhada = salarioMinimo / 2;
            salarioBruto = horaTrabalhada*horas;
            impostoGov = salario*0.03;
            salarioBruto = salarioBruto - imposto;

            Console.WriteLine("O seu salario é de :R$" + salario);
            /*----------------------------------------------------------------------*/
        }
    }
}
