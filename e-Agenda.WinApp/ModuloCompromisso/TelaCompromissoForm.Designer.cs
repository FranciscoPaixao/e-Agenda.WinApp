namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            chkSelecionarContato = new CheckBox();
            groupBox1 = new GroupBox();
            rdbOnline = new RadioButton();
            rdbPresencial = new RadioButton();
            txtLocalOnline = new TextBox();
            txtLocalPresencial = new TextBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            label6 = new Label();
            cmbContatos = new ComboBox();
            txtHorarioTermino = new DateTimePicker();
            label5 = new Label();
            txtHoraInicio = new DateTimePicker();
            label4 = new Label();
            txtData = new DateTimePicker();
            label3 = new Label();
            txtAssunto = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // chkSelecionarContato
            // 
            chkSelecionarContato.AutoSize = true;
            chkSelecionarContato.Location = new Point(13, 157);
            chkSelecionarContato.Name = "chkSelecionarContato";
            chkSelecionarContato.RightToLeft = RightToLeft.Yes;
            chkSelecionarContato.Size = new Size(188, 19);
            chkSelecionarContato.TabIndex = 38;
            chkSelecionarContato.Text = "?Deseja selecionar um Contato";
            chkSelecionarContato.UseVisualStyleBackColor = true;
            chkSelecionarContato.CheckedChanged += chkSelecionarContato_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbOnline);
            groupBox1.Controls.Add(rdbPresencial);
            groupBox1.Controls.Add(txtLocalOnline);
            groupBox1.Controls.Add(txtLocalPresencial);
            groupBox1.Location = new Point(24, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 99);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Local";
            // 
            // rdbOnline
            // 
            rdbOnline.AutoSize = true;
            rdbOnline.Location = new Point(28, 58);
            rdbOnline.Name = "rdbOnline";
            rdbOnline.Size = new Size(60, 19);
            rdbOnline.TabIndex = 25;
            rdbOnline.TabStop = true;
            rdbOnline.Text = "Online";
            rdbOnline.UseVisualStyleBackColor = true;
            rdbOnline.CheckedChanged += rdbOnline_CheckedChanged;
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Location = new Point(10, 27);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(78, 19);
            rdbPresencial.TabIndex = 24;
            rdbPresencial.TabStop = true;
            rdbPresencial.Text = "Presencial";
            rdbPresencial.UseVisualStyleBackColor = true;
            rdbPresencial.CheckedChanged += rdbPresencial_CheckedChanged;
            // 
            // txtLocalOnline
            // 
            txtLocalOnline.Location = new Point(94, 58);
            txtLocalOnline.Name = "txtLocalOnline";
            txtLocalOnline.Size = new Size(286, 23);
            txtLocalOnline.TabIndex = 23;
            // 
            // txtLocalPresencial
            // 
            txtLocalPresencial.Location = new Point(94, 26);
            txtLocalPresencial.Name = "txtLocalPresencial";
            txtLocalPresencial.Size = new Size(286, 23);
            txtLocalPresencial.TabIndex = 21;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(335, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 40);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(254, 340);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 40);
            btnGravar.TabIndex = 35;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(214, 157);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 34;
            label6.Text = "Contato:";
            // 
            // cmbContatos
            // 
            cmbContatos.DisplayMember = "nome";
            cmbContatos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContatos.Enabled = false;
            cmbContatos.FormattingEnabled = true;
            cmbContatos.Location = new Point(273, 154);
            cmbContatos.Name = "cmbContatos";
            cmbContatos.Size = new Size(137, 23);
            cmbContatos.TabIndex = 33;
            // 
            // txtHorarioTermino
            // 
            txtHorarioTermino.CustomFormat = "HH:mm";
            txtHorarioTermino.Format = DateTimePickerFormat.Custom;
            txtHorarioTermino.Location = new Point(273, 111);
            txtHorarioTermino.Name = "txtHorarioTermino";
            txtHorarioTermino.ShowUpDown = true;
            txtHorarioTermino.Size = new Size(137, 23);
            txtHorarioTermino.TabIndex = 32;
            // 
            // label5
            // 
            label5.Location = new Point(204, 107);
            label5.Name = "label5";
            label5.Size = new Size(63, 34);
            label5.TabIndex = 31;
            label5.Text = "Hora Termino:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.CustomFormat = "HH:mm";
            txtHoraInicio.Format = DateTimePickerFormat.Custom;
            txtHoraInicio.Location = new Point(78, 111);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ShowUpDown = true;
            txtHoraInicio.Size = new Size(124, 23);
            txtHoraInicio.TabIndex = 30;
            // 
            // label4
            // 
            label4.Location = new Point(13, 100);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(53, 37);
            label4.TabIndex = 29;
            label4.Text = "Hora Inicio:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(78, 75);
            txtData.Name = "txtData";
            txtData.Size = new Size(124, 23);
            txtData.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 78);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 27;
            label3.Text = "Data:";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(78, 41);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(339, 23);
            txtAssunto.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 44);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 25;
            label2.Text = "Assunto:";
            // 
            // txtId
            // 
            txtId.Location = new Point(78, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(72, 23);
            txtId.TabIndex = 24;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 15);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 23;
            label1.Text = "Id:";
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 417);
            Controls.Add(chkSelecionarContato);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label6);
            Controls.Add(cmbContatos);
            Controls.Add(txtHorarioTermino);
            Controls.Add(label5);
            Controls.Add(txtHoraInicio);
            Controls.Add(label4);
            Controls.Add(txtData);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaCompromissoForm";
            Text = "TelaCompromissoForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkSelecionarContato;
        private GroupBox groupBox1;
        private RadioButton rdbOnline;
        private RadioButton rdbPresencial;
        private TextBox txtLocalOnline;
        private TextBox txtLocalPresencial;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label6;
        private ComboBox cmbContatos;
        private DateTimePicker txtHorarioTermino;
        private Label label5;
        private DateTimePicker txtHoraInicio;
        private Label label4;
        private DateTimePicker txtData;
        private Label label3;
        private TextBox txtAssunto;
        private Label label2;
        private TextBox txtId;
        private Label label1;
    }
}