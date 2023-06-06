using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public string assunto;
        public DateTime data;
        public TimeSpan horaInicio;
        public TimeSpan horaTermino;
        public int contatoID;
        public string localPresencial;
        public string localOnline;
        public TipoLocalEnum tipoLocal;

        public Compromisso(int id = -1, string assunto = "", DateTime data = default(DateTime), TimeSpan horaInicio = default(TimeSpan), TimeSpan horaTermino = default(TimeSpan), int contatoID = -1, string localPresencial = "", string localOnline = "", TipoLocalEnum tipoLocal = TipoLocalEnum.Nenhum)
        {
            this.id = id;
            this.assunto = assunto;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
            this.contatoID = contatoID;
            this.localPresencial = localPresencial;
            this.localOnline = localOnline;
            this.tipoLocal = tipoLocal;
        }

        public override void AtualizarInformacoes(Compromisso novoRegistro)
        {
            this.assunto = novoRegistro.assunto;
            this.data = novoRegistro.data;
            this.horaInicio = novoRegistro.horaInicio;
            this.horaTermino = novoRegistro.horaTermino;
            this.contatoID = novoRegistro.contatoID;
            this.localPresencial = novoRegistro.localPresencial;
            this.localOnline = novoRegistro.localOnline;
            this.tipoLocal = novoRegistro.tipoLocal;
        }

        public override string[] Validar()
        {
            List<String> errors = new List<String>();
            if (String.IsNullOrEmpty(this.assunto))
            {
                errors.Add("O campo assunto é obrigatório");
            }
            if (this.data == default(DateTime))
            {
                errors.Add("O campo data é obrigatório");
            }
            if (this.horaInicio == default(TimeSpan))
            {
                errors.Add("O campo hora de início é obrigatório");
            }
            if (this.horaTermino == default(TimeSpan))
            {
                errors.Add("O campo hora de término é obrigatório");
            }
            if (this.tipoLocal == TipoLocalEnum.Nenhum)
            {
                errors.Add("O campo tipo de local é obrigatório");
            }
            if (this.tipoLocal == TipoLocalEnum.Presencial && String.IsNullOrEmpty(this.localPresencial))
            {
                errors.Add("O campo local presencial é obrigatório");
            }
            if (this.tipoLocal == TipoLocalEnum.Online && String.IsNullOrEmpty(this.localOnline))
            {
                errors.Add("O campo local online é obrigatório");
            }
            if (this.contatoID == -1)
            {
                errors.Add("O campo contato é obrigatório");
            }
            return errors.ToArray();
        }
    }
}
