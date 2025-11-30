using Atividade01.Control;
using Atividade01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Atividade01
{
    public partial class FormFuncionario : Form
    {
        ControleFuncionarios ctrlFuncionarios = new ControleFuncionarios();
        public FormFuncionario()
        {
            InitializeComponent();
            ctrlFuncionarios.carregar();
            dataFuncionarios.DataSource = ctrlFuncionarios.listarFuncionarios();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nome = txtNomeF.Text;
            string email = txtEmailF.Text;

            Funcionario funcionarioSend = new Funcionario(nome, email);
            ctrlFuncionarios.addFuncionario(funcionarioSend);

            dataFuncionarios.DataSource = null;
            dataFuncionarios.DataSource = ctrlFuncionarios.listarFuncionarios();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (dataFuncionarios.CurrentRow != null)
            {
                int indice = dataFuncionarios.CurrentRow.Index;
                ctrlFuncionarios.apagarFuncionario(indice);
                dataFuncionarios.DataSource = null;
                dataFuncionarios.DataSource = ctrlFuncionarios.listarFuncionarios();
            }
        }
    }
}
