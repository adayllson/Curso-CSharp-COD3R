using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // área da circuferência
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine("A área é: " + area +"!");

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário é " + salario);

            int menorValorInt = int.MinValue;// Mais usado dos inteiros!
            Console.WriteLine("Menor Valor Int é " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor Long é " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial é " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("O preço do computador é " + precoComputador);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre estrelas " + distanciaEntreEstrelas);

            char letra = 'a';
            Console.WriteLine("Letra " + letra);

            string texto = "Exemplo de texto!";
            Console.WriteLine("Texto " + texto);

        }
    }
}
