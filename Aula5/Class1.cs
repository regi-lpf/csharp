using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exec 1 L1
            {
                //Pessoa pes = new Pessoa();
                //Console.WriteLine("Preencha uma pessoa: ");
                //pes.nome = Console.ReadLine();
                //pes.idade = Convert.ToInt32(Console.ReadLine());
                //pes.cpf = Console.ReadLine();
                //pes.endereco = Console.ReadLine();

                //Console.WriteLine($"Nome: {pes.nome}\nIdade: {pes.idade}\nCPF: {pes.cpf}\nEndereço: {pes.endereco}");
            }

            // Exec 2 L1
            {
                //Cachorro dog1 = new Cachorro();
                //Cachorro dog2 = new Cachorro();

                //Console.WriteLine("Preencha os dados do primeiro cão ");
                //Console.ReadLine();
                //Console.WriteLine("Nome: ");
                //dog1.nome = Console.ReadLine();
                //Console.WriteLine("Nome do Dono: ");
                //dog1.nomeDoDono = Console.ReadLine();
                //Console.WriteLine("Idade do Cão: ");
                //dog1.idade = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Preencha os dados do segundo cão ");
                //Console.ReadLine();
                //Console.WriteLine("Nome: ");
                //dog2.nome = Console.ReadLine();
                //Console.WriteLine("Nome do Dono: ");
                //dog2.nomeDoDono = Console.ReadLine();
                //Console.WriteLine("Idade do Cão: ");
                //dog2.idade = Convert.ToInt32(Console.ReadLine());

                //Console.Write("Cachorros com mais de 6 anos: ");

                //if (dog1.idade > 6)
                //{
                //    Console.Write(dog1.nome + ", ");
                //}

                //if (dog2.idade > 6)
                //{
                //    Console.Write(dog2.nome + " ");
                //}

            }

            // Exec 3 L1
            {
                //Aluno aluno1 = new Aluno();

                //Console.WriteLine("Preencha os dados do aluno: ");
                //Console.WriteLine("Nome: ");
                //aluno1.nome = Console.ReadLine();
                //Console.WriteLine("Nota 1: ");
                //aluno1.nota1 = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Nota 2: ");
                //aluno1.nota2 = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Nota 3: ");
                //aluno1.nota3 = Convert.ToDouble(Console.ReadLine());

                //double soma = aluno1.nota1 + aluno1.nota2 + aluno1.nota3;
                //aluno1.media = soma / 3;
                //Console.Write("Média do aluno: "+ aluno1.media);

                //if (aluno1.media > 7)
                //{
                //    Console.WriteLine("Situação do Aluno: Aprovado");
                //}
                //else
                //{
                //    Console.WriteLine("Situação do Aluno: Reprovado");
                //}
            }

            // Funções
            {
                // Exec 1 L2
                {

                }
            }
        }
        // Exec 1 L1

        public struct Pessoa
        {
            public string nome;
            public int idade;
            public string cpf;
            public string endereco;
        }

        // Exec 2 L1

        public struct Cachorro
        {
            public string nome;
            public string nomeDoDono;
            public int idade;
        }

        // Exec 3 L1

        public struct Aluno
        {
            public string nome;
            public double nota1;
            public double nota2;
            public double nota3;
            public double media;
        }
    }
}
