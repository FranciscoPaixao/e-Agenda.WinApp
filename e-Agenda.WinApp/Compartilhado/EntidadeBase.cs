namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class EntidadeBase<TEntidade>
    {
        public int id;
        public abstract void AtualizarInformacoes(TEntidade novoRegistro);

        public abstract string[] Validar();
    }
}
