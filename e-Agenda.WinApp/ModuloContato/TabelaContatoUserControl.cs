using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TabelaContatoUserControl : UserControl
    {
        public TabelaContatoUserControl()
        {
            InitializeComponent();
            this.ConfigurarUserControl();
            gridTabela.ConfigurarGridZebrado();
            gridTabela.ConfigurarGrid();
            ConfigurarColunas();
        }

        public void AtualizarTabela(List<Contato> contatos)
        {
            gridTabela.Rows.Clear();
            foreach (var contato in contatos)
            {
                gridTabela.Rows.Add(contato.id, contato.nome, contato.telefone, contato.email, contato.empresa, contato.cargo);
            }
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn() { Name  = "id", HeaderText = "ID" },
                new DataGridViewTextBoxColumn() { Name  = "nome", HeaderText = "Nome" },
                new DataGridViewTextBoxColumn() { Name  = "telefone", HeaderText = "Telefone" },
                new DataGridViewTextBoxColumn() { Name  = "email", HeaderText = "Email" },
                new DataGridViewTextBoxColumn() { Name  = "empresa", HeaderText = "Empresa" },
                new DataGridViewTextBoxColumn() { Name  = "cargo", HeaderText = "Cargo" },
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
