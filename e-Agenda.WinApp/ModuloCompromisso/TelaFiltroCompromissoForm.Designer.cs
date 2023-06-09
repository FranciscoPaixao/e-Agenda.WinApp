namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltroCompromissoForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rbnVisualizarTodos = new RadioButton();
            rbnCompromissosPassados = new RadioButton();
            rbnCompromissosFuturos = new RadioButton();
            groupBox1 = new GroupBox();
            rbnIntervaloCustomizado = new RadioButton();
            txtDataInicial = new DateTimePicker();
            labelDataInicial = new Label();
            labelDataFinal = new Label();
            txtDataFinal = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rbnVisualizarTodos
            // 
            rbnVisualizarTodos.AutoSize = true;
            rbnVisualizarTodos.Checked = true;
            rbnVisualizarTodos.Location = new Point(21, 22);
            rbnVisualizarTodos.Name = "rbnVisualizarTodos";
            rbnVisualizarTodos.Size = new Size(206, 19);
            rbnVisualizarTodos.TabIndex = 0;
            rbnVisualizarTodos.TabStop = true;
            rbnVisualizarTodos.Text = "Visualizar Todos os Compromissos";
            rbnVisualizarTodos.UseVisualStyleBackColor = true;
            rbnVisualizarTodos.CheckedChanged += rbnVisualizarTodos_CheckedChanged;
            // 
            // rbnCompromissosPassados
            // 
            rbnCompromissosPassados.AutoSize = true;
            rbnCompromissosPassados.Location = new Point(21, 57);
            rbnCompromissosPassados.Name = "rbnCompromissosPassados";
            rbnCompromissosPassados.Size = new Size(208, 19);
            rbnCompromissosPassados.TabIndex = 1;
            rbnCompromissosPassados.Text = "Visualizar Compromissos Passados";
            rbnCompromissosPassados.UseVisualStyleBackColor = true;
            rbnCompromissosPassados.CheckedChanged += rbnCompromissosPassados_CheckedChanged;
            // 
            // rbnCompromissosFuturos
            // 
            rbnCompromissosFuturos.AutoSize = true;
            rbnCompromissosFuturos.Location = new Point(19, 91);
            rbnCompromissosFuturos.Name = "rbnCompromissosFuturos";
            rbnCompromissosFuturos.Size = new Size(200, 19);
            rbnCompromissosFuturos.TabIndex = 2;
            rbnCompromissosFuturos.Text = "Visualizar Compromissos Futuros";
            rbnCompromissosFuturos.UseVisualStyleBackColor = true;
            rbnCompromissosFuturos.CheckedChanged += rbnCompromissosFuturos_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbnIntervaloCustomizado);
            groupBox1.Controls.Add(rbnVisualizarTodos);
            groupBox1.Controls.Add(rbnCompromissosFuturos);
            groupBox1.Controls.Add(rbnCompromissosPassados);
            groupBox1.Location = new Point(35, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 163);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // rbnIntervaloCustomizado
            // 
            rbnIntervaloCustomizado.AutoSize = true;
            rbnIntervaloCustomizado.Location = new Point(19, 125);
            rbnIntervaloCustomizado.Name = "rbnIntervaloCustomizado";
            rbnIntervaloCustomizado.Size = new Size(182, 19);
            rbnIntervaloCustomizado.TabIndex = 3;
            rbnIntervaloCustomizado.Text = "Definir Intervalo Customizado";
            rbnIntervaloCustomizado.UseVisualStyleBackColor = true;
            rbnIntervaloCustomizado.CheckedChanged += rbnIntervaloCustomizado_CheckedChanged;
            // 
            // txtDataInicial
            // 
            txtDataInicial.Enabled = false;
            txtDataInicial.Format = DateTimePickerFormat.Short;
            txtDataInicial.Location = new Point(136, 190);
            txtDataInicial.Name = "txtDataInicial";
            txtDataInicial.Size = new Size(102, 23);
            txtDataInicial.TabIndex = 4;
            txtDataInicial.ValueChanged += txtDataInicial_ValueChanged;
            // 
            // labelDataInicial
            // 
            labelDataInicial.AutoSize = true;
            labelDataInicial.Location = new Point(62, 196);
            labelDataInicial.Name = "labelDataInicial";
            labelDataInicial.Size = new Size(68, 15);
            labelDataInicial.TabIndex = 6;
            labelDataInicial.Text = "Data Inicial:";
            // 
            // labelDataFinal
            // 
            labelDataFinal.AutoSize = true;
            labelDataFinal.Location = new Point(62, 225);
            labelDataFinal.Name = "labelDataFinal";
            labelDataFinal.Size = new Size(68, 15);
            labelDataFinal.TabIndex = 8;
            labelDataFinal.Text = "Data Inicial:";
            // 
            // txtDataFinal
            // 
            txtDataFinal.Enabled = false;
            txtDataFinal.Format = DateTimePickerFormat.Short;
            txtDataFinal.Location = new Point(136, 219);
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(102, 23);
            txtDataFinal.TabIndex = 7;
            txtDataFinal.ValueChanged += txtDataFinal_ValueChanged;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(103, 280);
            button1.Name = "button1";
            button1.Size = new Size(88, 41);
            button1.TabIndex = 9;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(200, 280);
            button2.Name = "button2";
            button2.Size = new Size(88, 41);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 347);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelDataFinal);
            Controls.Add(txtDataFinal);
            Controls.Add(labelDataInicial);
            Controls.Add(txtDataInicial);
            Controls.Add(groupBox1);
            Name = "TelaFiltroCompromissoForm";
            Text = "Filtro de Compromissos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbnVisualizarTodos;
        private RadioButton rbnCompromissosPassados;
        private RadioButton rbnCompromissosFuturos;
        private GroupBox groupBox1;
        private DateTimePicker txtDataInicial;
        private Label labelDataInicial;
        private Label labelDataFinal;
        private DateTimePicker txtDataFinal;
        private RadioButton rbnIntervaloCustomizado;
        private Button button1;
        private Button button2;
    }
}