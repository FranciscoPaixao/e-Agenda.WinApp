using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class RepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected List<TEntidade> listaRegistros;
        public int contadorRegistros;

        public List<TEntidade> ListaRegistros { get => listaRegistros; }

        public RepositorioBase()
        {
            contadorRegistros = 0;
            listaRegistros = new List<TEntidade>();
        }

        public virtual bool Inserir(TEntidade registro)
        {
            registro.id = contadorRegistros;
            listaRegistros.Add(registro);
            contadorRegistros++;
            return true;
        }
        public virtual  void MesclarRepositorio(RepositorioBase<TEntidade> repositorio)
        {
            this.listaRegistros.AddRange(repositorio.SelecionarTodos());
            this.contadorRegistros = repositorio.contadorRegistros;
        }
        public virtual void Editar(TEntidade novoRegistro)
        {
            TEntidade registroAntigo = SelecionarPorId(novoRegistro.id);
            registroAntigo.AtualizarInformacoes(novoRegistro);
        }
        public virtual void Excluir(int id) => listaRegistros.Remove(SelecionarPorId(id));

        public virtual bool Excluir(TEntidade registro) => listaRegistros.Remove(registro);

        public virtual List<TEntidade> SelecionarTodos() => listaRegistros;

        public virtual TEntidade SelecionarPorId(int id) => listaRegistros.FirstOrDefault(x => x.id == id);

    }
}
