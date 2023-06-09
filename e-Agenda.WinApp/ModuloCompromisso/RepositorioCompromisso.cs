
using e_Agenda.WinApp.ModuloContato;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {

        protected override RepositorioCompromisso ConverterJson(string json)
        {
            return JsonConvert.DeserializeObject<RepositorioCompromisso>(json); ;
        }
    }
}
