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
    public partial class TelaContatoForm : Form
    {
        public TelaContatoForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }
        public void DefinirID(int id = 0)
        {
            txtId.Text = id.ToString();
        }
        public Contato ObterContato()
        {
            Contato contato = new Contato(nome: this.txtNome.Text,
                                          email: this.txtEmail.Text,
                                          telefone: this.txtTelefone.Text,
                                          empresa: this.txtEmpresa.Text,
                                          cargo: this.txtCargo.Text);
            int id = -1;
            bool idValido = int.TryParse(txtId.Text, out id);
            if (idValido && id >= 0)
            {
                contato.id = id;
            }
            return contato;
        }
        public void ConfigurarTela(Contato contato)
        {
            txtId.Text = contato.id.ToString();
            txtNome.Text = contato.nome;
            txtEmail.Text = contato.email;
            txtTelefone.Text = contato.telefone;
            txtCargo.Text = contato.cargo;
            txtEmpresa.Text = contato.empresa;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Contato contato = ObterContato();
            string[] erros = contato.Validar();
            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
