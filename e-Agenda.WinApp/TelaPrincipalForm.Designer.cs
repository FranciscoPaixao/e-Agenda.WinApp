namespace e_Agenda.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            contatosMenuItem = new ToolStripMenuItem();
            compromissosMenuItem = new ToolStripMenuItem();
            tarefasMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem = new ToolStripMenuItem();
            despesasMenuItem = new ToolStripMenuItem();
            categoriasMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            tsBarraFerramentas = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnAdicionarItens = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnConcluirItens = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            labelTipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tsBarraFerramentas.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, compromissosMenuItem, tarefasMenuItem, despesasToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(71, 20);
            toolStripMenuItem1.Text = "Cadastros";
            // 
            // contatosMenuItem
            // 
            contatosMenuItem.Name = "contatosMenuItem";
            contatosMenuItem.Size = new Size(154, 22);
            contatosMenuItem.Text = "Contatos";
            contatosMenuItem.Click += toolStripItem_Click;
            // 
            // compromissosMenuItem
            // 
            compromissosMenuItem.Name = "compromissosMenuItem";
            compromissosMenuItem.Size = new Size(154, 22);
            compromissosMenuItem.Text = "Compromissos";
            compromissosMenuItem.Click += toolStripItem_Click;
            // 
            // tarefasMenuItem
            // 
            tarefasMenuItem.Name = "tarefasMenuItem";
            tarefasMenuItem.Size = new Size(154, 22);
            tarefasMenuItem.Text = "Tarefas";
            tarefasMenuItem.Click += toolStripItem_Click;
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { despesasMenuItem, categoriasMenuItem });
            despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size = new Size(154, 22);
            despesasToolStripMenuItem.Text = "Despesas";
            // 
            // despesasMenuItem
            // 
            despesasMenuItem.Name = "despesasMenuItem";
            despesasMenuItem.Size = new Size(130, 22);
            despesasMenuItem.Text = "Despesas";
            despesasMenuItem.Click += toolStripItem_Click;
            // 
            // categoriasMenuItem
            // 
            categoriasMenuItem.Name = "categoriasMenuItem";
            categoriasMenuItem.Size = new Size(130, 22);
            categoriasMenuItem.Text = "Categorias";
            categoriasMenuItem.Click += toolStripItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(52, 17);
            labelRodape.Text = "[rodape]";
            // 
            // tsBarraFerramentas
            // 
            tsBarraFerramentas.Enabled = false;
            tsBarraFerramentas.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator1, btnFiltrar, toolStripSeparator2, btnAdicionarItens, toolStripSeparator3, btnConcluirItens, toolStripSeparator4, labelTipoCadastro });
            tsBarraFerramentas.Location = new Point(0, 24);
            tsBarraFerramentas.Name = "tsBarraFerramentas";
            tsBarraFerramentas.Size = new Size(800, 45);
            tsBarraFerramentas.TabIndex = 2;
            tsBarraFerramentas.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(42, 42);
            btnInserir.Text = "Inserir";
            btnInserir.Click += botaoBarraFerramentas_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(42, 42);
            btnEditar.Text = "Editar";
            btnEditar.Click += botaoBarraFerramentas_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.delete_forever_FILL0_wght400_GRAD0_opsz24;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(42, 42);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += botaoBarraFerramentas_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Image = Properties.Resources.filter_alt_FILL0_wght400_GRAD0_opsz24;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(7);
            btnFiltrar.Size = new Size(42, 42);
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Click += botaoBarraFerramentas_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // btnAdicionarItens
            // 
            btnAdicionarItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarItens.Image = Properties.Resources.library_add_FILL0_wght400_GRAD0_opsz24;
            btnAdicionarItens.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionarItens.ImageTransparentColor = Color.Magenta;
            btnAdicionarItens.Name = "btnAdicionarItens";
            btnAdicionarItens.Size = new Size(28, 42);
            btnAdicionarItens.Text = "Adicionar Itens";
            btnAdicionarItens.Click += botaoBarraFerramentas_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 45);
            // 
            // btnConcluirItens
            // 
            btnConcluirItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConcluirItens.Image = Properties.Resources.select_check_box_FILL0_wght400_GRAD0_opsz24;
            btnConcluirItens.ImageScaling = ToolStripItemImageScaling.None;
            btnConcluirItens.ImageTransparentColor = Color.Magenta;
            btnConcluirItens.Name = "btnConcluirItens";
            btnConcluirItens.Size = new Size(28, 42);
            btnConcluirItens.Text = "Concluir Itens";
            btnConcluirItens.Click += botaoBarraFerramentas_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 45);
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(75, 42);
            labelTipoCadastro.Text = "tipoCadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 69);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(800, 359);
            panelRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRegistros);
            Controls.Add(tsBarraFerramentas);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            Text = "e-Agenda";
            FormClosing += TelaPrincipalForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tsBarraFerramentas.ResumeLayout(false);
            tsBarraFerramentas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem compromissosMenuItem;
        private ToolStripMenuItem tarefasMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem despesasMenuItem;
        private ToolStripMenuItem categoriasMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStrip tsBarraFerramentas;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel panelRegistros;
        private ToolStripLabel labelTipoCadastro;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnFiltrar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnAdicionarItens;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnConcluirItens;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripStatusLabel labelRodape;
    }
}