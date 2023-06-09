using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        public override string ToolTipInserir => "Inserir nova tarefa";

        public override string ToolTipEditar => "Editar tarefa selecionada";

        public override string ToolTipExcluir => "Excluir tarefa selecionada";

        public override string ObterTipoCadastro => "Tarefa";

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterTabela()
        {
            throw new NotImplementedException();
        }
    }
}
