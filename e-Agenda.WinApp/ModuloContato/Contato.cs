using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class Contato : EntidadeBase<Contato>
    {
        public string nome;
        public string empresa;
        public string cargo;
        public string email;
        public string telefone;

        public Contato(int id = -1, string nome = "", string empresa = "", string cargo = "", string email = "", string telefone = "")
        {
            this.id = id;
            this.nome = nome;
            this.empresa = empresa;
            this.cargo = cargo;
            this.email = email;
            this.telefone = telefone;
        }
        public override void AtualizarInformacoes(Contato novoRegistro)
        {
            this.nome = novoRegistro.nome;
            this.empresa = novoRegistro.empresa;
            this.cargo = novoRegistro.cargo;
            this.email = novoRegistro.email;
            this.telefone = novoRegistro.telefone;
        }

        public override string[] Validar()
        {
            List<String> errors = new List<String>();
            if (String.IsNullOrEmpty(this.nome))
            {
                errors.Add("O campo nome é obrigatório");
            }
            if (String.IsNullOrEmpty(this.empresa))
            {
                errors.Add("O campo empresa é obrigatório");
            }
            if (String.IsNullOrEmpty(this.email))
            {
                errors.Add("O campo email é obrigatório");
            }
            if (String.IsNullOrEmpty(this.telefone))
            {
                errors.Add("O campo telefone é obrigatório");
            }
            if (String.IsNullOrEmpty(this.cargo))
            {
                errors.Add("O campo cargo é obrigatório");
            }
            return errors.ToArray();
        }
        public override string ToString()
        {
            return nome;
        }
    }
}
