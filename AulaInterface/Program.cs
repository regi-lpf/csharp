using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            while (true)
            {
                Console.WriteLine("Pesssoas atualmente asicionadas no sistema: ");
                foreach (var item in pessoas)
                {
                    Console.WriteLine($"{item.Nome}   {item.Idade}   {item.Cpf}");
                }
                Console.WriteLine("Preencha as informações sobre a pessoa na sua frente");
                Console.WriteLine("Caso queira encerrar o expediente, insira 'fim' ");
                string nome = Console.ReadLine();
                if(nome.ToLower() == "fim")
                {
                    break;
                }
                try
                {
                    int idade = Convert.ToInt32(Console.ReadLine());
                    string cpf = Console.ReadLine();
                    pessoas.Add(new Pessoa(nome, idade, cpf));
                }
                catch(Exception)
                {
                    Console.WriteLine("Apenas números na idade");
                }
                Console.Clear();
            }
        }
    }
}