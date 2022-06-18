using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicios
            {
                //1)
                {
                    int[][] matriz = new int[4][];

                    for (int i = 0; i < matriz.Length; i++)
                    {
                        matriz[i] = new int[4];
                    }

                    Console.WriteLine("vai inserino numero dps digo quantos sao maior q 10");
                    for (int i = 0; i < matriz.Length; i++)
                    {
                        for (int j = 0; j < matriz[i].Length; j++)
                        {
                            matriz[i][j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }


                    int quantidadeMaiorQueDez = 0;
                    for (int i = 0; i < matriz.Length; i++)
                    {
                        for (int j = 0; j < matriz[i].Length; j++)
                        {
                            if (matriz[i][j] > 10)
                            {
                                quantidadeMaiorQueDez++;
                            }
                        }
                    }

                    Console.WriteLine("A quantidade de numeros maiores que 10 é: ");
                    Console.WriteLine(quantidadeMaiorQueDez);
                }
            }
        }
    }
}