using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjONG
{
    internal class Animal
    {
        public int Chip { get; set; }

        public string Nome { get; set; }

        public string Raca { get; set; }

        public string Sexo { get; set; }

        public string Familia { get; set; }

        public Adotante Adotante { get; set; }

        public Animal()
        {

        }

        public Animal(int chip, string nome, string raca, string sexo, string familia, Adotante adotante)
        {
            Chip = chip;
            Nome = nome;
            Raca = raca;
            Sexo = sexo;
            Familia = familia;
            Adotante = adotante;
        }
    }
}
