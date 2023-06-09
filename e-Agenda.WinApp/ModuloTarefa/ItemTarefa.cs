namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ItemTarefa
    {
        public string titulo;
        public bool finalizada;

        public ItemTarefa(string titulo = "")
        {
            this.titulo = titulo;
        }

        public void Concluir()
        {
            this.finalizada = true;
        }

        public void Desmarcar()
        {
            this.finalizada = false;
        }

        public override bool Equals(object? obj)
        {
            return obj is ItemTarefa tarefa &&
                   titulo == tarefa.titulo &&
                   finalizada == tarefa.finalizada;
        }
    }
}