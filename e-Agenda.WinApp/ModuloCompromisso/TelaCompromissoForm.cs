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
            foreach (Contato contato in contatos)
            {
                cmbContatos.Items.Add(contato);
            }
        }
        public void ConfigurarTela(Compromisso compromisso, Contato contato)
        {
            this.Text = "Edição de Compromisso";

            txtId.Text = compromisso.id.ToString();

            txtAssunto.Text = compromisso.assunto;

            txtData.Value = compromisso.data;

            txtHoraInicio.Value = DateTime.Now.Date.Add(compromisso.horaInicio);

            txtHorarioTermino.Value = DateTime.Now.Date.Add(compromisso.horaTermino);

            if (compromisso.contatoID > -1)
            {
                chkSelecionarContato.Checked = true;
                cmbContatos.Enabled = true;
                cmbContatos.SelectedIndex = cmbContatos.Items.IndexOf(contato);
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

            compromisso.id = Convert.ToInt32(txtId.Text);

            compromisso.assunto = txtAssunto.Text;

            compromisso.data = txtData.Value;

            compromisso.horaInicio = txtHoraInicio.Value.TimeOfDay;

            compromisso.horaTermino = txtHorarioTermino.Value.TimeOfDay;

            compromisso.tipoLocal = rdbOnline.Checked ? TipoLocalEnum.Online : TipoLocalEnum.Presencial;

            string local = rdbOnline.Checked ? txtLocalOnline.Text : txtLocalPresencial.Text;

            if (chkSelecionarContato.Checked)
            {
                Contato contato = (Contato)cmbContatos.SelectedItem;
                compromisso.contatoID = contato.id;
            }

            if (compromisso.tipoLocal == TipoLocalEnum.Online)
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = ObterCompromisso();
            string[] erros = compromisso.Validar();
            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
