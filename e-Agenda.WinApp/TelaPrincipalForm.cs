using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Threading;
using System.Windows.Forms;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioContato repContato = new RepositorioContato();
        private RepositorioCompromisso repCompromisso = new RepositorioCompromisso();

        private CancellationTokenSource cancellationTokenSource;
        private Thread threadSalvarDados;

        private static TelaPrincipalForm telaPrincipal;

        public TelaPrincipalForm()
        {
            InitializeComponent();
            repContato.CarregarRepositorio();
            repCompromisso.CarregarRepositorio();
            Console.WriteLine(repContato.ListaRegistros.Count);
            cancellationTokenSource = new CancellationTokenSource();
            threadSalvarDados = new Thread(() => SalvarDados(cancellationTokenSource));
            threadSalvarDados.Start();

            telaPrincipal = this;
        }

        public void SalvarDados(CancellationTokenSource cancellationTokenSource)
        {
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                repContato.GravarRepositorio();
                repCompromisso.GravarRepositorio();
                Thread.Sleep(2000);
            }
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
        }

        private void toolStripItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itemClicado = (ToolStripMenuItem)sender;
            switch (itemClicado.Name)
            {
                case "contatosMenuItem":
                    controlador = new ControladorContato(repContato);
                    break;
                case "compromissosMenuItem":
                    controlador = new ControladorCompromisso(repCompromisso, repContato);
                    break;
                default:
                    break;
            }
            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);

            ConfigurarTelaPrincipal(controlador);
        }
        private void botaoBarraFerramentas_Click(object sender, EventArgs e)
        {
            ToolStripButton botaoCliclado = (ToolStripButton)sender;
            switch (botaoCliclado.Name)
            {
                case "btnInserir":
                    controlador.Inserir();
                    break;
                case "btnEditar":
                    controlador.Editar();
                    break;
                case "btnExcluir":
                    controlador.Excluir();
                    break;
                case "btnFiltrar":
                    controlador.Filtrar();
                    break;
                default:
                    break;
            }
        }
        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro;

            tsBarraFerramentas.Enabled = true;

            ConfigurarToolTips(controladorBase);

            ConfigurarEstados(controlador);

            ConfigurarListagem(controladorBase);

        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl tabela = controladorBase.ObterTabela();

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(tabela);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            btnAdicionarItens.ToolTipText = controlador.ToolTipAdicionarItens;
            btnConcluirItens.ToolTipText = controlador.ToolTipConcluirItens;
        }

        private void ConfigurarEstados(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            btnAdicionarItens.Enabled = controlador.AdicionarItensHabilitado;
            btnConcluirItens.Enabled = controlador.ConcluirItensHabilitado;
        }

        private void TelaPrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
            threadSalvarDados.Join();
        }
    }
}
