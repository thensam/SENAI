using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Atividade01
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void AbrirFormNoPanel(Form f)
        {
            panelTarefa.Controls.Clear();              
            f.TopLevel = false;                        
            f.FormBorderStyle = FormBorderStyle.None;  
            f.Dock = DockStyle.Fill;                   
            panelTarefa.Controls.Add(f);               
            f.Show();                                  
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new Form1());
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FormFuncionario());
        }

        private void panelTarefa_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
