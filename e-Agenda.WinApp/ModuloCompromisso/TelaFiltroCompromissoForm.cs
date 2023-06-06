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
    public partial class TelaFiltroCompromissoForm : Form
    {
        private DateTime dataInicial;
        private DateTime dataFinal;

        public TelaFiltroCompromissoForm()
        {
            InitializeComponent();
        }

        internal void ObterDatas(out DateTime dataInicial, out DateTime dataFinal)
        {
            dataInicial = this.dataInicial;
            dataFinal = this.dataFinal;
        }

        private void rbnIntervaloCustomizado_CheckedChanged(object sender, EventArgs e)
        {
            txtDataInicial.Enabled = !txtDataInicial.Enabled;
            txtDataFinal.Enabled = !txtDataFinal.Enabled;
        }

        private void txtDataInicial_ValueChanged(object sender, EventArgs e)
        {
            this.dataInicial = txtDataInicial.Value;
        }

        private void txtDataFinal_ValueChanged(object sender, EventArgs e)
        {
            this.dataFinal = txtDataFinal.Value;
        }

        private void rbnVisualizarTodos_CheckedChanged(object sender, EventArgs e)
        {
            this.dataInicial = default(DateTime);
            this.dataFinal = default(DateTime);
        }

        private void rbnCompromissosPassados_CheckedChanged(object sender, EventArgs e)
        {
            this.dataInicial = default(DateTime);
            this.dataFinal = DateTime.Now.AddDays(-1);
            
        }

        private void rbnCompromissosFuturos_CheckedChanged(object sender, EventArgs e)
        {
            this.dataInicial = DateTime.Now.AddDays(1);
            this.dataFinal = default(DateTime);
            
        }
    }
}
