using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    internal class ControladorContato : ControladorBase
    {
        public RepositorioContato repContato;
        private TabelaContatoUserControl tabelaContato;

        public ControladorContato(RepositorioContato repositorioContato)
        {
            this.repContato = repositorioContato;
        }

        public override string ToolTipInserir => "Inserir novo Contato";

        public override string ToolTipEditar => "Editar Contato existente";

        public override string ToolTipExcluir => "Excluir Contato existente";

        public override string ObterTipoCadastro => "Contatos";

        public override void Editar()
        {

            Contato contatoSelecionado = ObterContatoSelecionado();
            if (contatoSelecionado == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Edição de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaContatoForm telaContato = new TelaContatoForm();

            telaContato.ConfigurarTela(contatoSelecionado);

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repContato.Editar(telaContato.ObterContato());
            }

            CarregarContatos();
        }
        private Contato ObterContatoSelecionado()
        {
            int id = tabelaContato.ObterIdSelecionado();

            return repContato.SelecionarPorId(id);
        }
        public override void Excluir()
        {
            Contato contato = ObterContatoSelecionado();

            if (contato == null)
            {
                MessageBox.Show(
                    $"Selecione um contato primeiro!",
                    "Exclusão de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show(
                $"Deseja excluir o contato {contato.nome}?",
                "Exclusão de Contatos",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repContato.Excluir(contato);
                CarregarContatos();
            }
        }

        public override void Inserir()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            telaContato.DefinirID(repContato.contadorRegistros);

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repContato.Inserir(telaContato.ObterContato());

                CarregarContatos();
            }
        }
        private void CarregarContatos()
        {
            List<Contato> contatos = repContato.SelecionarTodos();
            tabelaContato.AtualizarTabela(contatos);
        }
        public override UserControl ObterTabela()
        {
            if (tabelaContato == null)
            {
                tabelaContato = new TabelaContatoUserControl();
            }
            tabelaContato.AtualizarTabela(repContato.SelecionarTodos());
            return tabelaContato;
        }
    }
}
