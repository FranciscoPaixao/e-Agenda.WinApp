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
    public partial class ListagemContatoControl : UserControl
    {
        List<Contato> contatos = new List<Contato>();

        public ListagemContatoControl()
        {
            InitializeComponent();
            contatos.Add(new Contato(1, "Fulano", "Microsoft"));
            contatos.Add(new Contato(2, "Ciclano", "Apple"));
            foreach (var contato in contatos)
            {
                listContato.Items.Add(contato);
            }
        }
    }
}
