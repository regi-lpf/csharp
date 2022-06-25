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
                    //int[][] matriz = new int[4][];

                    //for (int i = 0; i < matriz.Length; i++)
                    //{
                    //    matriz[i] = new int[4];
                    //}

                    //Console.WriteLine("vai inserino numero dps digo quantos sao maior q 10");
                    //for (int i = 0; i < matriz.Length; i++)
                    //{
                    //    for (int j = 0; j < matriz[i].Length; j++)
                    //    {
                    //        matriz[i][j] = Convert.ToInt32(Console.ReadLine());
                    //    }
                    //}


                    //int quantidadeMaiorQueDez = 0;
                    //for (int i = 0; i < matriz.Length; i++)
                    //{
                    //    for (int j = 0; j < matriz[i].Length; j++)
                    //    {
                    //        if (matriz[i][j] > 10)
                    //        {
                    //            quantidadeMaiorQueDez++;
                    //        }
                    //    }
                    //}

                    //Console.WriteLine("A quantidade de numeros maiores que 10 é: ");
                    //Console.WriteLine(quantidadeMaiorQueDez);
                }

                // 2)
                {
                    //int[][] matriz = new int[5][];
                    //for (int i = 0; i < matriz.Length; i++)
                    //{
                    //    matriz[i] = new int[5];
                    //}

                    //for (int i = 0; i < matriz.Length; i++)
                    //{
                    //    for (int j = 0; j < matriz[i].Length; j++)
                    //    {
                    //        if (i == j)
                    //        {
                    //            matriz[i][j] = 1;
                    //        }
                    //        else
                    //        {
                    //            matriz[i][j] = 0;
                    //        }
                    //    }
                    //}

                    //for (int i = 0; i < matriz.Length; i++)
                    //{
                    //    for (int j = 0; j < matriz[i].Length; j++)
                    //    {
                    //        Console.Write(matriz[i][j]+" ");
                    //    }
                    //    Console.WriteLine();
                    //}
                }

                // 3)
                {
                    //int[][] matriz = new int[10][];
                    //for (int i = 0; i < matriz.Length; i++)
                    //{
                    //    matriz[i] = new int[10];
                    //}

                    //for (int i = 0; i < matriz.Length; i++)
                    //{
                    //    for (int j = 0; j < matriz[i].Length; j++)
                    //    {
                    //        matriz[i][j] = i * j;
                    //    }
                    //}

                    //for (int i = 0; i < matriz.Length; i++)
                    //{
                    //    for (int j = 0; j < matriz[i].Length; j++)
                    //    {
                    //        Console.Write(matriz[i][j] + " ");
                    //    }
                    //    Console.WriteLine();
                    //}
                }

                // 4)
                {
                    //double[,] valores = new double[5, 5];
                    //double valor;

                    //Console.WriteLine("Preencha os valores da matriz");
                    //for (int i = 0; i < valores.GetLength(0); i++)
                    //{
                    //    for (int j = 0; j < valores.GetLength(1); j++)
                    //    {
                    //        valores[i, j] = Convert.ToDouble(Console.ReadLine());
                    //    }
                    //}
                    //Console.Clear();
                    //Console.WriteLine("Agora, insira um valor para ser encontrado na matriz");
                    //valor = Convert.ToDouble(Console.ReadLine());

                    //bool naoEncontrado = true;
                    //for (int i = 0; i < valores.GetLength(0); i++)
                    //{
                    //    for (int j = 0; j < valores.GetLength(1); j++)
                    //    {
                    //        if (valores[i,j] == valor)
                    //        {
                    //            naoEncontrado = false;
                    //            Console.WriteLine("Encontrei !!!");
                    //            Console.WriteLine($"{i},{j}");
                    //            i = valores.GetLength(0);
                    //            break;
                    //        }
                    //    }
                    //}
                    //if (naoEncontrado)
                    //{
                    //    Console.WriteLine("Não existe na matriz");
                    //}
                }

                // 5)
                {
                    //Random ran = new Random();
                    
                    //int[,] a = new int[4, 4];
                    //int[,] b = new int[4, 4];
                    //int[,] c = new int[4, 4];

                    //for (int i = 0; i < a.GetLength(0); i++)
                    //{
                    //    for (int j = 0; j < a.GetLength(1); j++)
                    //    {
                    //        a[i, j] = ran.Next(0, 9 +1);
                    //        Console.Write($"{a[i,j]}");
                    //    }
                    //    Console.WriteLine();
                    //}
                    //Console.WriteLine("-------------//-----------------");
                    //for (int i = 0; i < b.GetLength(0); i++)
                    //{
                    //    for (int j = 0; j < b.GetLength(1); j++)
                    //    {
                    //        b[i, j] = ran.Next(0, 9 +1);
                    //        Console.Write($"{b[i, j]}");
                    //    }
                    //    Console.WriteLine();
                    //}
                    //Console.WriteLine("-------------//-----------------");
                    //for (int i = 0; i < c.GetLength(0); i++)
                    //{
                    //    for (int j = 0; j < c.GetLength(1); j++)
                    //    {
                    //        if (a[i,j] > b[i,j])
                    //        {
                    //            c[i,j] = a[i,j];
                    //        }
                    //        else
                    //        {
                    //            c[i,j] = b[i,j];
                    //        }
                    //        Console.Write($"{c[i, j]}");
                    //    }
                    //    Console.WriteLine();
                    //}
                }
            }

        }
    }
}