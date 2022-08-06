using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaInterface
{
    class Pessoa : IPessoa
    {
        public Pessoa(string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
    }
}
