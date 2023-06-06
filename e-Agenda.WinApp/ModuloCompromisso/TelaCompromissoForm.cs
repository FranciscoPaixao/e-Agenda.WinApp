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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        public TelaCompromissoForm()
        {
            InitializeComponent();
        }
        public void DefinirID(int id = 0)
        {
            txtId.Text = id.ToString();
        }
        public void CarregarContatos(List<Contato> contatos)
        {
            foreach(Contato contato in contatos)
            {
                cmbContatos.Items.Add(contato.nome);
            }
        }
        public void ConfigurarTela(Compromisso compromisso, Contato contato)
        {
            txtId.Text = compromisso.id.ToString();

            txtAssunto.Text = compromisso.assunto;

            txtData.Value = compromisso.data;

            txtHoraInicio.Value = DateTime.Now.Date.Add(compromisso.horaInicio);

            txtHorarioTermino.Value = DateTime.Now.Date.Add(compromisso.horaTermino);

            if (compromisso.contatoID > -1)
            {
                chkSelecionarContato.Checked = true;
                cmbContatos.Enabled = true;
                cmbContatos.SelectedIndex = cmbContatos.Items.IndexOf(contato.nome);
            }

            if (compromisso.tipoLocal == TipoLocalEnum.Presencial)
            {
                rdbPresencial.Checked = true;
                txtLocalPresencial.Text = compromisso.localPresencial;
            } 
            else
            {
                rdbOnline.Checked = true;
                txtLocalOnline.Text = compromisso.localOnline;
            }
        }
        public Compromisso ObterCompromisso()
        {
            Compromisso compromisso = new Compromisso();

            compromisso.assunto = txtAssunto.Text;

            compromisso.data = txtData.Value;

            compromisso.horaInicio = txtHoraInicio.Value.TimeOfDay;

            compromisso.horaTermino = txtHorarioTermino.Value.TimeOfDay;

            compromisso.tipoLocal = rdbOnline.Checked ? TipoLocalEnum.Online : TipoLocalEnum.Presencial;

            string local = rdbOnline.Checked ? txtLocalOnline.Text : txtLocalPresencial.Text;
            if(chkSelecionarContato.Checked)
            {
                Contato contato = (Contato)cmbContatos.SelectedItem;
            }
            else
            {
                compromisso.contatoID = -1;
            }
            if(compromisso.tipoLocal == TipoLocalEnum.Online)
            {
                compromisso.localOnline = local;
            }
            else
            {
                compromisso.localPresencial = local;
            }
            return compromisso;
        }

        //Eventos
        private void rdbPresencial_CheckedChanged(object sender, EventArgs e)
        {
            txtLocalOnline.Enabled = !txtLocalOnline.Enabled;
        }

        private void rdbOnline_CheckedChanged(object sender, EventArgs e)
        {
            txtLocalPresencial.Enabled = !txtLocalPresencial.Enabled;
        }

        private void chkSelecionarContato_CheckedChanged(object sender, EventArgs e)
        {
            cmbContatos.Enabled = !cmbContatos.Enabled;
        }
    }
}
