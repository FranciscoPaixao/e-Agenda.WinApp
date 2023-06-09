using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        protected override RepositorioContato ConverterJson(string json)
        {
            return JsonConvert.DeserializeObject<RepositorioContato>(json);
        }
    }
}
