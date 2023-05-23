namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class ListagemTarefaControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listTarefa = new ListBox();
            SuspendLayout();
            // 
            // listTarefa
            // 
            listTarefa.Dock = DockStyle.Fill;
            listTarefa.FormattingEnabled = true;
            listTarefa.ItemHeight = 15;
            listTarefa.Location = new Point(0, 0);
            listTarefa.Name = "listTarefa";
            listTarefa.Size = new Size(689, 334);
            listTarefa.TabIndex = 0;
            // 
            // ListagemTarefaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listTarefa);
            Name = "ListagemTarefaControl";
            Size = new Size(689, 334);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listTarefa;
    }
}
