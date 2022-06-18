using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            // a) Declarar uma variável A, ler um valor para ela e escrever o valor da variável A em seguida.
            {


                //Console.WriteLine("insira um valor de a");
                //string a = Console.ReadLine();

                //Console.WriteLine("A = " + a);

                //Console.ReadLine();
            }

            // b) Escreva um algoritmo que solicita ao usuário 3 valores inteiros via teclado e depois exibe os números fornecidos.
            {
                //Console.WriteLine("insira um valor de a");
                //int a = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("insira um valor de b");
                //int b = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("insira um valor de c");
                //int c = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("A = " + a);
                //Console.WriteLine("B = " + b);
                //Console.WriteLine("C = " + c);

                //Console.ReadLine();
            }

            // c) Efetuar a leitura de um número inteiro e apresentar o resultado do quadrado desse número.
            {
                //Console.WriteLine("Insira um valor de X:");
                //double x = Convert.ToDouble(Console.ReadLine());
                //double resultado = Math.Pow(x, 2);
                //Console.WriteLine("O quadrado de X é igual a:"+resultado);

                //Console.ReadLine();
            }   
            
            // d) Ler dois valores inteiros (variáveis A e B) e apresentar o resultado do quadrado do primeiro valor (variável A) mais o quadrado do segundo valor (variável B).
            {
                //Console.WriteLine("Insira um valor de A:");
                //double a = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Insira um valor de B:");
                //double b = Convert.ToDouble(Console.ReadLine());

                //double quadradoA = Math.Pow(a, 2);
                //double quadradoB = Math.Pow(b, 2);
                //double soma = quadradoA + quadradoB;

                //Console.WriteLine("A soma do quadrado de A com o quadrado de B é igual a:"+soma);

                //Console.ReadLine();
            }

            // e) Elaborar um programa que efetue a apresentação do valor da conversão em real (R$) de um valor lido em dólar (US$). O programa deverá solicitar o valor da cotação do dólar e também a quantidade de dólares disponível com o usuário.
            {
                //double cotacao;
                //double dinheiro;

                //Console.WriteLine("insira o valor da cotacao do dolar(em R$)☺");
                //cotacao = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Insira o valor que você possui(em US$)☻♥");
                //dinheiro = Convert.ToDouble(Console.ReadLine());

                //double resultado = dinheiro * cotacao;

                //Console.WriteLine("Conversao completa. Voce possui R$"+resultado);

                //Console.ReadLine(); 
            }

            // f) Elaborar um programa que efetue a apresentação do valor da conversão em dólar (US$) de um valor lido em real (R$). O programa deverá solicitar o valor da cotação do dólar e também a quantidade de reais disponível com o usuário.
            {
                //double cotacao;
                //double dinheiro;

                //console.writeline("insira o valor da cotacao do dolar(em r$):(");
                //cotacao = convert.todouble(console.readline());
                //console.writeline("insira o valor que você possui(em r$):'(");
                //dinheiro = convert.todouble(console.readline());

                //double resultado = dinheiro / cotacao;

                //console.writeline("conversao completa. voce possui us$" + resultado);

                //console.readline();
            }

            // g) Os artigos de uma loja possuem um valor associado a si. Na compra a vista, é concedido um desconto de 8% mas, comprando em 3 vezes há um acréscimo de 15% no valor do artigo. Faça um algoritmo que tendo como entrada o valor do artigo, mostre como resultado o valor a vista e o valor das parcelas a prazo.
            {
                //Console.WriteLine("Insira o valor do produto(R$):");
                //double valor = Convert.ToDouble(Console.ReadLine());

                //double valorAVista = valor * 0.92;
                //double valorParcelado = valor * 1.15;

                //Console.WriteLine("Valor a vista: R$"+valorAVista);
                //Console.WriteLine("Valor parcelado em 3 vezes: R$"+valorParcelado);

                //Console.ReadLine();
            }

            // h) Ler dois valores para as variáveis A e B, e efetuar a troca dos valores de forma que a variável A passe a possuir o valor da variável B e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.
            {
                Console.WriteLine("Insira um valor de A");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira um valor de B");
                int b = Convert.ToInt32(Console.ReadLine());

                int aux = a;
                a = b;
                b = aux;

                Console.WriteLine();

                Console.ReadLine();
            }

            // Conteudo
            {
                //int valor1 = 10;
                //int valor2 = 3;
                //double valor3 = 0.5;

                //Console.WriteLine(valor1 + valor2);
                //Console.WriteLine(valor1 + valor3);
                //valor1 = valor3;
                //valor1 = valor2;
                //valor2 = valor1;
                //valor3 = valor1;
                //Console.WriteLine(valor1 + valor2 + valor3);

                //int valor1 = 5;
                //double valor2 = 4;
                //String palavra = "3";

                //valor1 = palavra;
                //valor2 = valor1 + 3.5;
                //palavra = valor1;
                //palavra = valor1.ToString();
                //palavra = valor2.ToString() + valor1;
                //palavra = valor1.ToString() + valor2;
            }

        }
    }
}
