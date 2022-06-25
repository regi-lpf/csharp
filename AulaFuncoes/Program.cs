using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AulaFuncoes
{
    class Program
    {
        public static void Main(string[] args)
        {
            // exec 01 l1
            int valor1, valor2;
            Console.WriteLine("Insira 2 numeros: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("o menor numero e "+Metodos.Compara(valor1, valor2));

        }
    }
}