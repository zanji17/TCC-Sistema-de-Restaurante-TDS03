
namespace Restaurante
{
    partial class FormHomeGerente
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
            this.pbCaixa = new System.Windows.Forms.PictureBox();
            this.pbCozinha = new System.Windows.Forms.PictureBox();
            this.pbAtendente = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pratosEProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloDeAdicionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCozinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtendente)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCaixa
            // 
            this.pbCaixa.Image = global::Restaurante.Properties.Resources.Icon_Caixa;
            this.pbCaixa.Location = new System.Drawing.Point(424, 46);
            this.pbCaixa.Name = "pbCaixa";
            this.pbCaixa.Size = new System.Drawing.Size(114, 104);
            this.pbCaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaixa.TabIndex = 6;
            this.pbCaixa.TabStop = false;
            this.pbCaixa.Click += new System.EventHandler(this.pbCaixa_Click);
            // 
            // pbCozinha
            // 
            this.pbCozinha.Image = global::Restaurante.Properties.Resources.icon_Cozinha;
            this.pbCozinha.Location = new System.Drawing.Point(225, 46);
            this.pbCozinha.Name = "pbCozinha";
            this.pbCozinha.Size = new System.Drawing.Size(114, 104);
            this.pbCozinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCozinha.TabIndex = 5;
            this.pbCozinha.TabStop = false;
            this.pbCozinha.Click += new System.EventHandler(this.pbCozinha_Click);
            // 
            // pbAtendente
            // 
            this.pbAtendente.Image = global::Restaurante.Properties.Resources.Icon_Atendente;
            this.pbAtendente.Location = new System.Drawing.Point(28, 46);
            this.pbAtendente.Name = "pbAtendente";
            this.pbAtendente.Size = new System.Drawing.Size(114, 104);
            this.pbAtendente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAtendente.TabIndex = 4;
            this.pbAtendente.TabStop = false;
            this.pbAtendente.Click += new System.EventHandler(this.pbAtendente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Home do Caixa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(222, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Home da Cozinha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Home do Atendente";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atendentesToolStripMenuItem,
            this.ingredientesToolStripMenuItem,
            this.pratosEProdutosToolStripMenuItem,
            this.acessosToolStripMenuItem,
            this.modeloDeAdicionalToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // atendentesToolStripMenuItem
            // 
            this.atendentesToolStripMenuItem.Name = "atendentesToolStripMenuItem";
            this.atendentesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.atendentesToolStripMenuItem.Text = "Atendentes";
            this.atendentesToolStripMenuItem.Click += new System.EventHandler(this.atendentesToolStripMenuItem_Click);
            // 
            // ingredientesToolStripMenuItem
            // 
            this.ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            this.ingredientesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ingredientesToolStripMenuItem.Text = "Ingredientes";
            this.ingredientesToolStripMenuItem.Click += new System.EventHandler(this.ingredientesToolStripMenuItem_Click);
            // 
            // pratosEProdutosToolStripMenuItem
            // 
            this.pratosEProdutosToolStripMenuItem.Name = "pratosEProdutosToolStripMenuItem";
            this.pratosEProdutosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.pratosEProdutosToolStripMenuItem.Text = "Pratos e Produtos";
            this.pratosEProdutosToolStripMenuItem.Click += new System.EventHandler(this.pratosEProdutosToolStripMenuItem_Click);
            // 
            // acessosToolStripMenuItem
            // 
            this.acessosToolStripMenuItem.Name = "acessosToolStripMenuItem";
            this.acessosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.acessosToolStripMenuItem.Text = "Acessos";
            this.acessosToolStripMenuItem.Click += new System.EventHandler(this.acessosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atendimentoToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // atendimentoToolStripMenuItem
            // 
            this.atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            this.atendimentoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.atendimentoToolStripMenuItem.Text = "Atendimento";
            this.atendimentoToolStripMenuItem.Click += new System.EventHandler(this.atendimentoToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // modeloDeAdicionalToolStripMenuItem
            // 
            this.modeloDeAdicionalToolStripMenuItem.Name = "modeloDeAdicionalToolStripMenuItem";
            this.modeloDeAdicionalToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.modeloDeAdicionalToolStripMenuItem.Text = "Modelo de Adicional";
            this.modeloDeAdicionalToolStripMenuItem.Click += new System.EventHandler(this.modeloDeAdicionalToolStripMenuItem_Click);
            // 
            // FormHomeGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 203);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbCaixa);
            this.Controls.Add(this.pbCozinha);
            this.Controls.Add(this.pbAtendente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHomeGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home do Gerente";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCozinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtendente)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbCaixa;
        private System.Windows.Forms.PictureBox pbCozinha;
        private System.Windows.Forms.PictureBox pbAtendente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pratosEProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloDeAdicionalToolStripMenuItem;
    }
}