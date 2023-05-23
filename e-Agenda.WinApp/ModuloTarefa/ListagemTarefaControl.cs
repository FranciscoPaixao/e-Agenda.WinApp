using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class ListagemTarefaControl : UserControl
    {
        public List<Tarefa> tarefas = new List<Tarefa>();
        public ListagemTarefaControl()
        {
            InitializeComponent();
            tarefas.Add(new Tarefa(1, "Fazer e-Agenda", "Alta"));
            tarefas.Add(new Tarefa(2, "Fazer e-Agenda", "Alta"));
            foreach (var tarefa in tarefas)
            {
                listTarefa.Items.Add(tarefa);
            }
        }
    }
}
