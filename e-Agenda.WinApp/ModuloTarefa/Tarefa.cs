using e_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase<Tarefa>
    {
        public string titulo;

        public PrioridadeTarefaEnum prioridade;

        public DateTime dataCriacao;

        public List<ItemTarefa> itens;

        public Decimal percentualConcluido;

        public Tarefa(int id = -1, string titulo = "", PrioridadeTarefaEnum prioridade = PrioridadeTarefaEnum.NaoDefinido, DateTime dataCriacao = default(DateTime), Decimal percentualConcluido = 0)
        {
            this.id = id;
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataCriacao = dataCriacao;
            if (dataCriacao == default(DateTime))
            {
                dataCriacao = DateTime.Now;
            }
            this.itens = new List<ItemTarefa>();
            this.percentualConcluido = percentualConcluido;
        }

        public override void AtualizarInformacoes(Tarefa novoRegistro)
        {
            titulo = novoRegistro.titulo;
            dataCriacao = novoRegistro.dataCriacao;
            percentualConcluido = novoRegistro.percentualConcluido;
        }

        public void AdicionarItem(ItemTarefa item)
        {
            itens.Add(item);
        }
        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemSelecionado = itens.FirstOrDefault(x => x.Equals(item));

            itemSelecionado.Concluir();

            CalcularPercentualConcluido();
        }

        public void DesmarcarItem(ItemTarefa item)
        {
            ItemTarefa itemSelecionado = itens.FirstOrDefault(x => x.Equals(item));

            itemSelecionado.Desmarcar();

            CalcularPercentualConcluido();
        }

        public void CalcularPercentualConcluido()
        {
            decimal quantidadeItens = itens.Count;

            decimal quantidadeItensConcluidos = itens.Count(x => x.finalizada == true);

            decimal resultado = (quantidadeItensConcluidos / quantidadeItens) * 100;

            this.percentualConcluido = Math.Round(resultado, 2);

        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if(string.IsNullOrEmpty(titulo))
            {
                erros.Add("O campo título é obrigatório");
            }
            if(prioridade == PrioridadeTarefaEnum.NaoDefinido)
            {
                erros.Add("O campo prioridade é obrigatório");
            }
            if(dataCriacao == default(DateTime))
            {
                erros.Add("O campo data de criação é obrigatório");
            }
            if(percentualConcluido < 0 || percentualConcluido > 100)
            {
                erros.Add("O campo percentual concluído deve estar entre 0 e 100");
            }
            return erros.ToArray();
        }
    }
}
