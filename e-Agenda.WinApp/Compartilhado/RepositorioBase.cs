using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class RepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected List<TEntidade> listaRegistros;
        public int contadorRegistros;
        protected string jsonRepositorio;
        protected string nomeArquivo = typeof(TEntidade).Name + ".json";

        public List<TEntidade> ListaRegistros { get => listaRegistros; }

        public RepositorioBase()
        {
            contadorRegistros = 0;
            listaRegistros = new List<TEntidade>();
            //CarregarRepositorio();
        }
        public virtual bool Inserir(TEntidade registro)
        {
            registro.id = contadorRegistros;
            listaRegistros.Add(registro);
            contadorRegistros++;
            return true;
        }
        public virtual void CarregarRepositorio()
        {
            if (File.Exists(nomeArquivo))
            {
                string json = File.ReadAllText(nomeArquivo);

                if (string.IsNullOrEmpty(json))
                {
                    return;
                }

                RepositorioBase<TEntidade> tempRep = ConverterJson(json);

                this.listaRegistros.AddRange(tempRep.ListaRegistros);

                this.contadorRegistros = tempRep.contadorRegistros;

                return;
            }
            File.Create(nomeArquivo).Close();
        }

        protected abstract RepositorioBase<TEntidade> ConverterJson(string json);

        public virtual void GravarRepositorio()
        {
            if (contadorRegistros > 0 && listaRegistros.Count > 0)
            {
                string antigoJson = jsonRepositorio;

                jsonRepositorio = JsonConvert.SerializeObject(this);

                File.WriteAllText(nomeArquivo, jsonRepositorio);
            }
        }
        protected virtual JsonSerializerOptions ConfigSerializacao()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
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
