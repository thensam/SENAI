using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade01.Model
{
    internal class Funcionario
    {
        public string nome { get; set; }
        public string email { get; set; }

        public Funcionario(string nome, string email) {
            this.nome = nome;
            this.email = email;
        }
    }
}
