using System;
using System.Collections.Generic;
using System.Text;
using Atividade01.Model;
using System.IO;
using System.Text.Json;


namespace Atividade01.Control
{
    internal class ControleTarefa
    {
        private List<Tarefa> tarefaList = new List<Tarefa>();

        public void addTarefa(Tarefa tarefa)
        {
            if (string.IsNullOrWhiteSpace(tarefa.nome))
                return;

            if (string.IsNullOrWhiteSpace(tarefa.status))
                return;

            tarefaList.Add(tarefa);
            salvar();
        }
        public List<Tarefa> obterTarefa()
        {
            return tarefaList; 
        }
        public void apagar(int indice) //explicaçao no design
        {
            if (indice >= 0 && indice < tarefaList.Count)
            {
                tarefaList.RemoveAt(indice);
                salvar();
            }
        }
        public void salvar() //salva os dados
        {
            string json = JsonSerializer.Serialize(tarefaList);  //cria o json com jsonserializer, ele organiza tudo automaticamente pra vc
            File.WriteAllText("tarefas.json", json);  //nome do arquivo / o que vai pra esse arquivo. ou seja, tudo que ta na variavel json

        }
        public void carregar() //carrega os dados
        {
            if (File.Exists("tarefas.json"))
            {
                string json = File.ReadAllText("tarefas.json"); //lê e atribui todo arquivo de tarefas a variavel
                tarefaList = JsonSerializer.Deserialize<List<Tarefa>>(json); //nao sei o que faz muito bem mas pelo que vi, ele "desmonta" o json e cria uma outra list
            }
        }
    }
}
