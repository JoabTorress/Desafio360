using System;

namespace Ti360
{
    internal class Program
    {
        static void Main()
        {
            
            Console.Write("Digite seu peso em quilogramas: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            
            double imc = CalcularIMC(peso, altura);

            
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            
            ExibirClassificacaoIMC(imc);
        }

       
        static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        static void ExibirClassificacaoIMC(double imc)
        {
            Console.Write("Classificação do IMC: ");

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc < 34.9)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (imc < 39.9)
            {
                Console.WriteLine("Obesidade Grau II");
            }
            else
            {
                Console.WriteLine("Obesidade Grau III");
            }
        }
    }
}

