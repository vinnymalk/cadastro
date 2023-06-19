using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProj
{
    internal class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Cpf { get; set; } = null!;
        public int Idade { get; set; }
        public string Email { get; set; } = null!;
        public string Endereco { get; set; } = null!;

    }



}
