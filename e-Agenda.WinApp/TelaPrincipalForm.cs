using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            panelRegistros.Controls.Clear();

            labelTipoCadastro.Text = "Cadastro de Contatos";
            btnInserir.ToolTipText = "Inserir Novo Contato";
            btnEditar.ToolTipText = "Editar Contato";
            btnExcluir.ToolTipText = "Excluir Contato";

            ListagemContatoControl listagemContatos = new ListagemContatoControl();

            listagemContatos.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagemContatos);
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            panelRegistros.Controls.Clear();

            labelTipoCadastro.Text = "Cadastro de Tarefas";
            btnInserir.ToolTipText = "Inserir Nova Tarefa";
            btnEditar.ToolTipText = "Editar Tarefa";
            btnExcluir.ToolTipText = "Excluir Tarefa";

            ListagemTarefaControl listagemTarefas = new ListagemTarefaControl();

            listagemTarefas.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagemTarefas);
        }

        private void despesasMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriasMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (labelTipoCadastro.Text == "Cadastro de Tarefas") { 
                TelaTarefaForm telaTarefa = new TelaTarefaForm();
                telaTarefa.ShowDialog();
            }
            else if (labelTipoCadastro.Text == "Cadastro de Contatos")
            {
                TelaContatoForm telaContato = new TelaContatoForm();
                telaContato.ShowDialog();
            }
        }
    }
}