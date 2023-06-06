using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace e_Agenda.WinApp
{
    public class ControladorDados
    {
        private string arquivoContato = typeof(RepositorioContato).Name + ".json";
        private string arquivoCompromisso = typeof(RepositorioCompromisso).Name + ".json";

        private string jsonContato;
        private string jsonCompromisso;

        private RepositorioContato repContato;
        private RepositorioCompromisso repCompromisso;

        public ControladorDados(RepositorioContato repContato, RepositorioCompromisso repCompromisso)
        {
            this.repContato = repContato;
            this.repCompromisso = repCompromisso;
        }

        public void CarregarDados()
        {
            if (File.Exists(arquivoContato))
            {
                string jsonContato = File.ReadAllText(arquivoContato);
                if (jsonContato.Length > 0)
                {
                    var tempRepContato = JsonConvert.DeserializeObject<RepositorioContato>(jsonContato);
                    repContato.MesclarRepositorio(tempRepContato);
                }
            }
            else
            {
                File.Create(arquivoContato).Close();
            }
            if (File.Exists(arquivoCompromisso))
            {
                string jsonCompromisso = File.ReadAllText(arquivoContato);
                if (jsonCompromisso.Length > 0)
                {
                    var tempRepCompromisso = JsonConvert.DeserializeObject<RepositorioCompromisso>(jsonCompromisso);
                    repCompromisso.MesclarRepositorio(tempRepCompromisso);
                }
            }
            else
            {
                File.Create(arquivoCompromisso).Close();
            }
        }
        public void SalvarDados(CancellationTokenSource cancellationTokenSource)
        {
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                if (repContato.contadorRegistros > 0)
                {
                    string antigoJsonContato = jsonContato;
                    jsonContato = JsonConvert.SerializeObject(repContato);
                    if (!jsonContato.Equals(antigoJsonContato))
                    {
                        File.WriteAllText(arquivoContato, jsonContato);
                    }
                }
                Thread.Sleep(2000);
            }
        }
    }
}
