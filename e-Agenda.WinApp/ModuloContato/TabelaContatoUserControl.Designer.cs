namespace e_Agenda.WinApp.ModuloContato
{
    partial class TabelaContatoUserControl
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
            gridTabela = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridTabela).BeginInit();
            SuspendLayout();
            // 
            // gridTabela
            // 
            gridTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTabela.Location = new Point(224, 103);
            gridTabela.Name = "gridTabela";
            gridTabela.RowTemplate.Height = 25;
            gridTabela.Size = new Size(240, 150);
            gridTabela.TabIndex = 0;
            // 
            // TabelaContatoUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridTabela);
            Name = "TabelaContatoUserControl";
            Size = new Size(800, 373);
            ((System.ComponentModel.ISupportInitialize)gridTabela).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView gridTabela;
    }
}
