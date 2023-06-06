namespace e_Agenda.WinApp.Compartilhado
{
    public static class UserControlExtension
    {
        public static void ConfigurarUserControl(this UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
        }
    }
}
