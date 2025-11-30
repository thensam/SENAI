using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade01.Model
{
    internal class Tarefa
    {
        public string nome { get; set; }
        public DateTime data { get; set; }
        public string status { get; set; }

        public Tarefa(string nome, DateTime data, string status)
        {
            this.nome = nome;
            this.data = data;
            this.status = status;

        }
    }
}