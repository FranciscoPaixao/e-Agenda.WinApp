namespace e_Agenda.WinApp.ModuloContato
{
        public class Contato
        {
            public int id;
            public string nome;
            public string empresa;

            public Contato(int id, string nome, string empresa)
            {
                this.id = id;
                this.nome = nome;
                this.empresa = empresa;
            }

            public override string ToString()
            {
                return $"Id: {id}, Nome: {nome}, Empresa: {empresa}";
            }
        }
}
