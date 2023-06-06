using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TabelaCompromissoUserControl : UserControl
    {
        public TabelaCompromissoUserControl()
        {
            InitializeComponent();
            this.ConfigurarUserControl();
            gridTabela.ConfigurarGridZebrado();
            gridTabela.ConfigurarGrid();
            ConfigurarColunas();
        }
        public void AtualizarTabela(List<Compromisso> compromissos, RepositorioContato repContato)
        {
            gridTabela.Rows.Clear();

            foreach (Compromisso compromisso in compromissos)
            {
                string contato = repContato.SelecionarPorId(compromisso.contatoID).nome;
                gridTabela.Rows.Add(compromisso.id, compromisso.assunto, compromisso.data.ToShortDateString(), compromisso.horaInicio.ToString(@"hh\:mm"), compromisso.horaTermino.ToString(@"hh\:mm"), contato, compromisso.tipoLocal);
            }
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn() { Name  = "id", HeaderText = "ID" },
                new DataGridViewTextBoxColumn() { Name  = "assunto", HeaderText = "Assunto" },
                new DataGridViewTextBoxColumn() { Name  = "data", HeaderText = "Data" },
                new DataGridViewTextBoxColumn() { Name  = "horaInicio", HeaderText = "Hora Inicio" },
                new DataGridViewTextBoxColumn() { Name  = "horaTermino", HeaderText = "Hora Termino" },
                new DataGridViewTextBoxColumn() { Name  = "contato", HeaderText = "Contato" },
                new DataGridViewTextBoxColumn() { Name  = "tipoLocal", HeaderText = "Local" },
            };
            gridTabela.Columns.AddRange(colunas);
        }
        public int ObterIdSelecionado()
        {
            if (gridTabela.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridTabela.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
