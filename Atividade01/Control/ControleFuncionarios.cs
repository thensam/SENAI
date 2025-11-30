using System;
using System.Collections.Generic;
using System.Text;
using Atividade01.Model;
using System.IO;
using System.Text.Json;

namespace Atividade01.Control
{
    internal class ControleFuncionarios
    {
        private List<Funcionario> funcionarioList = new List<Funcionario>();

        public void addFuncionario(Funcionario funcionario)
        {
            if (string.IsNullOrWhiteSpace(funcionario.nome))
                return;
            if (string.IsNullOrWhiteSpace(funcionario.email))
                return;

            funcionarioList.Add(funcionario);
            salvar();
        }
        public List<Funcionario> listarFuncionarios()
        {
            return funcionarioList;
        }

        public void apagarFuncionario(int indice)
        {
            if(indice >= 0 && indice < funcionarioList.Count)
            {
                funcionarioList.RemoveAt(indice);
                salvar();
            }
        }
        public void salvar()
        {
            string jsonFuncionario = JsonSerializer.Serialize(funcionarioList);
            File.WriteAllText("funcionarios.json", jsonFuncionario);
        }
        public void carregar()
        {
            if (File.Exists("funcionarios.json"))
            {
                string jsonFuncionario = File.ReadAllText("funcionarios.json");
                funcionarioList = JsonSerializer.Deserialize<List<Funcionario>>(jsonFuncionario);
            }
        }
    }
}
