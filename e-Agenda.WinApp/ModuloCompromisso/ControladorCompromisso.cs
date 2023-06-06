using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        private TabelaCompromissoUserControl tabelaCompromisso;
        private TelaFiltroCompromissoForm telaFiltroCompromisso;

        private RepositorioCompromisso repCompromisso;
        private RepositorioContato repContato;

        private DateTime dataInicial;
        private DateTime dataFinal;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repContato)
        {
            this.repCompromisso = repositorioCompromisso;
            this.repContato = repContato;
            this.dataInicial = default(DateTime);
            this.dataFinal = default(DateTime);
        }

        public override string ToolTipInserir => "Inserir novo compromisso";

        public override string ToolTipEditar => "Editar compromisso existente";

        public override string ToolTipExcluir => "Excluir compromisso existente";

        public override string ObterTipoCadastro => "Compromissos";

        public override bool FiltrarHabilitado => true;

        public override void Editar()
        {
            Compromisso compromissoSelecionado = ObterCompromissoSelecionado();

            if (compromissoSelecionado == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                    "Edição de Compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            telaCompromisso.CarregarContatos(repContato.SelecionarTodos());

            telaCompromisso.ConfigurarTela(compromissoSelecionado, repContato.SelecionarPorId(compromissoSelecionado.contatoID));

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();
            if(opcaoEscolhida == DialogResult.OK)
            {
                repCompromisso.Editar(telaCompromisso.ObterCompromisso());
            }
            CarregarCompromissos(dataInicial, dataFinal);
        }

        public override void Excluir()
        {
            Compromisso compromissoSelecionado = ObterCompromissoSelecionado();
            if (compromissoSelecionado == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                    "Exclusão de Compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            DialogResult opcaoEscolhida = MessageBox.Show(
                $"Deseja excluir o compromisso {compromissoSelecionado.assunto}?",
                "Exclusão de Compromissos",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repCompromisso.Excluir(compromissoSelecionado);
                CarregarCompromissos(dataInicial, dataFinal);
            }
        }

        public override void Inserir()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();
            
            telaCompromisso.DefinirID(repCompromisso.contadorRegistros);

            telaCompromisso.CarregarContatos(repContato.SelecionarTodos());

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                repCompromisso.Inserir(telaCompromisso.ObterCompromisso());
                CarregarCompromissos(dataInicial, dataFinal);
            }
        }
        public override void Filtrar()
        {
            if(telaFiltroCompromisso == null)
            {
                telaFiltroCompromisso = new TelaFiltroCompromissoForm();
            }
            DialogResult opcaoEscolhida = telaFiltroCompromisso.ShowDialog();
            if(opcaoEscolhida == DialogResult.OK)
            {
                telaFiltroCompromisso.ObterDatas(out this.dataInicial, out this.dataFinal); ;
                CarregarCompromissos(dataInicial, dataFinal);
            }
        }
        private Compromisso ObterCompromissoSelecionado()
        {
            int id = tabelaCompromisso.ObterIdSelecionado();

            return repCompromisso.SelecionarPorId(id);
        }
        private void CarregarCompromissos(DateTime dataInicial, DateTime dataFinal)
        {
            List<Compromisso> compromissos = repCompromisso.SelecionarTodos();
            if(dataInicial != default(DateTime) && dataFinal != default(DateTime))
            {
                compromissos = compromissos.Where(x => x.data >= dataInicial && x.data <= dataFinal).ToList();
            }else if(dataInicial != default(DateTime) && dataFinal == default(DateTime))
            {
                compromissos = compromissos.Where(x => x.data >= dataInicial).ToList();
            }else if(dataFinal != default(DateTime))
            {
                compromissos = compromissos.Where(x => x.data <= dataFinal).ToList();
            }
            tabelaCompromisso.AtualizarTabela(compromissos, repContato);
        }
        public override UserControl ObterTabela()
        { 
            if(tabelaCompromisso == null)
            {
                tabelaCompromisso = new TabelaCompromissoUserControl();
            }
            tabelaCompromisso.AtualizarTabela(repCompromisso.SelecionarTodos(), repContato);
            return tabelaCompromisso;
        }
    }
}
