using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjONG
{
    internal class Adotante
    {
        public string CPF { get; set; }

        public string Nome { get; set; }

        public char Sexo { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Telefone { get; set; }

        public string Cidade { get; set; }

        public string SiglaEstado { get; set; }

        public string Rua { get; set; }

        public string Bairro { get; set; }

        public string Numero { get; set; }

        public Adotante()
        {

        }

        public Adotante(string cpf, string nome, char sexo, DateTime dataNascimento, string telefone, string cidade, string siglaEstado, string rua, string bairro,  string numero)
        {
            CPF = cpf;
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Cidade = cidade;
            SiglaEstado = siglaEstado;
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
        }
    }
}
