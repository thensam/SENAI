using Atividade01.Model;
using Atividade01.Control;
namespace Atividade01
{
    public partial class Form1 : Form
    {

        ControleTarefa controleTarefa = new ControleTarefa();

        public Form1()
        {
            InitializeComponent();
            controleTarefa.carregar(); //carrega lista
            dataTarefa.DataSource = controleTarefa.obterTarefa(); //carrega grid
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string tarefa = txtTarefa.Text;
            DateTime tarefaDate = dateTarefa.Value;
            string status = statusTarefa.Text;

            Tarefa tarefaSend = new Tarefa(tarefa, tarefaDate, status);

            controleTarefa.addTarefa(tarefaSend);

            dataTarefa.DataSource = null;
            dataTarefa.DataSource = controleTarefa.obterTarefa();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataTarefa.CurrentRow != null) //verificacao inutil se tem algo selecionado antes de apagar
            {
                int indice = dataTarefa.CurrentRow.Index;  //pega o indice atual da linha selecionada
                controleTarefa.apagar(indice); //passa pro metodo apagar

                dataTarefa.DataSource = null; //zera o grid
                dataTarefa.DataSource = controleTarefa.obterTarefa(); //carrega o grid
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
