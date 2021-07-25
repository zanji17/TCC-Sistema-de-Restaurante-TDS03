
namespace Restaurante
{
    partial class FormRegistrarPrato
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
            this.components = new System.ComponentModel.Container();
            this.clbAdicional = new System.Windows.Forms.CheckedListBox();
            this.clbRetirar = new System.Windows.Forms.CheckedListBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.painel_botoes = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paiel_topo = new Guna.UI2.WinForms.Guna2Panel();
            this.pbFechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtOBS = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbPP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nQuantidade = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblPratoProduto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQualidade = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAdicional = new System.Windows.Forms.Label();
            this.lblRetirar = new System.Windows.Forms.Label();
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.cbTipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.painel_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paiel_topo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // clbAdicional
            // 
            this.clbAdicional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbAdicional.FormattingEnabled = true;
            this.clbAdicional.Location = new System.Drawing.Point(281, 229);
            this.clbAdicional.Name = "clbAdicional";
            this.clbAdicional.Size = new System.Drawing.Size(178, 165);
            this.clbAdicional.TabIndex = 1;
            // 
            // clbRetirar
            // 
            this.clbRetirar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbRetirar.FormattingEnabled = true;
            this.clbRetirar.Location = new System.Drawing.Point(474, 229);
            this.clbRetirar.Name = "clbRetirar";
            this.clbRetirar.Size = new System.Drawing.Size(204, 165);
            this.clbRetirar.TabIndex = 2;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // painel_botoes
            // 
            this.painel_botoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.painel_botoes.Controls.Add(this.btnPesquisar);
            this.painel_botoes.Controls.Add(this.pictureBox1);
            this.painel_botoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_botoes.Location = new System.Drawing.Point(0, 40);
            this.painel_botoes.Name = "painel_botoes";
            this.painel_botoes.ShadowDecoration.Parent = this.painel_botoes;
            this.painel_botoes.Size = new System.Drawing.Size(890, 56);
            this.painel_botoes.TabIndex = 51;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Animated = true;
            this.btnPesquisar.AutoRoundedCorners = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BorderRadius = 22;
            this.btnPesquisar.CheckedState.Parent = this.btnPesquisar;
            this.btnPesquisar.CustomImages.Parent = this.btnPesquisar;
            this.btnPesquisar.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.HoverState.Parent = this.btnPesquisar;
            this.btnPesquisar.Location = new System.Drawing.Point(740, 6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.ShadowDecoration.Parent = this.btnPesquisar;
            this.btnPesquisar.Size = new System.Drawing.Size(129, 47);
            this.btnPesquisar.TabIndex = 67;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseTransparentBackground = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.logo_azul_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // paiel_topo
            // 
            this.paiel_topo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paiel_topo.Controls.Add(this.pbFechar);
            this.paiel_topo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paiel_topo.Location = new System.Drawing.Point(0, 0);
            this.paiel_topo.Name = "paiel_topo";
            this.paiel_topo.ShadowDecoration.Parent = this.paiel_topo;
            this.paiel_topo.Size = new System.Drawing.Size(890, 40);
            this.paiel_topo.TabIndex = 50;
            // 
            // pbFechar
            // 
            this.pbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFechar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pbFechar.HoverState.Parent = this.pbFechar;
            this.pbFechar.IconColor = System.Drawing.Color.White;
            this.pbFechar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pbFechar.Location = new System.Drawing.Point(825, 0);
            this.pbFechar.Name = "pbFechar";
            this.pbFechar.ShadowDecoration.Parent = this.pbFechar;
            this.pbFechar.Size = new System.Drawing.Size(65, 40);
            this.pbFechar.TabIndex = 70;
            this.pbFechar.Click += new System.EventHandler(this.pbFechar_Click);
            // 
            // txtOBS
            // 
            this.txtOBS.Animated = true;
            this.txtOBS.BackColor = System.Drawing.Color.Transparent;
            this.txtOBS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOBS.BorderRadius = 10;
            this.txtOBS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOBS.DefaultText = "";
            this.txtOBS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOBS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOBS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOBS.DisabledState.Parent = this.txtOBS;
            this.txtOBS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOBS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOBS.FocusedState.Parent = this.txtOBS;
            this.txtOBS.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOBS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOBS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOBS.HoverState.Parent = this.txtOBS;
            this.txtOBS.Location = new System.Drawing.Point(12, 229);
            this.txtOBS.Multiline = true;
            this.txtOBS.Name = "txtOBS";
            this.txtOBS.PasswordChar = '\0';
            this.txtOBS.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOBS.PlaceholderText = "Obs: ";
            this.txtOBS.SelectedText = "";
            this.txtOBS.ShadowDecoration.Parent = this.txtOBS;
            this.txtOBS.Size = new System.Drawing.Size(251, 165);
            this.txtOBS.TabIndex = 54;
            // 
            // cbPP
            // 
            this.cbPP.Animated = true;
            this.cbPP.AutoRoundedCorners = true;
            this.cbPP.BackColor = System.Drawing.Color.Transparent;
            this.cbPP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPP.BorderRadius = 17;
            this.cbPP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPP.FocusedState.Parent = this.cbPP;
            this.cbPP.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPP.HoverState.Parent = this.cbPP;
            this.cbPP.ItemHeight = 30;
            this.cbPP.ItemsAppearance.Parent = this.cbPP;
            this.cbPP.Location = new System.Drawing.Point(299, 137);
            this.cbPP.Name = "cbPP";
            this.cbPP.ShadowDecoration.Parent = this.cbPP;
            this.cbPP.Size = new System.Drawing.Size(251, 36);
            this.cbPP.TabIndex = 55;
            this.cbPP.SelectedIndexChanged += new System.EventHandler(this.cbPP_SelectedIndexChanged);
            // 
            // nQuantidade
            // 
            this.nQuantidade.AutoRoundedCorners = true;
            this.nQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.nQuantidade.BorderRadius = 17;
            this.nQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nQuantidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nQuantidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nQuantidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nQuantidade.DisabledState.Parent = this.nQuantidade;
            this.nQuantidade.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nQuantidade.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nQuantidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nQuantidade.FocusedState.Parent = this.nQuantidade;
            this.nQuantidade.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nQuantidade.Location = new System.Drawing.Point(600, 137);
            this.nQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nQuantidade.Name = "nQuantidade";
            this.nQuantidade.ShadowDecoration.Parent = this.nQuantidade;
            this.nQuantidade.Size = new System.Drawing.Size(251, 36);
            this.nQuantidade.TabIndex = 56;
            this.nQuantidade.UseTransparentBackground = true;
            // 
            // lblPratoProduto
            // 
            this.lblPratoProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblPratoProduto.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPratoProduto.Location = new System.Drawing.Point(380, 114);
            this.lblPratoProduto.Name = "lblPratoProduto";
            this.lblPratoProduto.Size = new System.Drawing.Size(100, 22);
            this.lblPratoProduto.TabIndex = 58;
            this.lblPratoProduto.Text = "Prato/Produto";
            // 
            // lblQualidade
            // 
            this.lblQualidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQualidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lblQualidade.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualidade.Location = new System.Drawing.Point(689, 114);
            this.lblQualidade.Name = "lblQualidade";
            this.lblQualidade.Size = new System.Drawing.Size(73, 22);
            this.lblQualidade.TabIndex = 60;
            this.lblQualidade.Text = "Qualidade";
            // 
            // lblAdicional
            // 
            this.lblAdicional.AutoSize = true;
            this.lblAdicional.BackColor = System.Drawing.Color.Transparent;
            this.lblAdicional.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblAdicional.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicional.Location = new System.Drawing.Point(334, 201);
            this.lblAdicional.Name = "lblAdicional";
            this.lblAdicional.Size = new System.Drawing.Size(73, 20);
            this.lblAdicional.TabIndex = 61;
            this.lblAdicional.Text = "Adicional";
            // 
            // lblRetirar
            // 
            this.lblRetirar.AutoSize = true;
            this.lblRetirar.BackColor = System.Drawing.Color.Transparent;
            this.lblRetirar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblRetirar.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetirar.Location = new System.Drawing.Point(549, 206);
            this.lblRetirar.Name = "lblRetirar";
            this.lblRetirar.Size = new System.Drawing.Size(54, 20);
            this.lblRetirar.TabIndex = 62;
            this.lblRetirar.Text = "Retirar";
            // 
            // btnSair
            // 
            this.btnSair.Animated = true;
            this.btnSair.AutoRoundedCorners = true;
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSair.BorderRadius = 17;
            this.btnSair.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSair.BorderThickness = 1;
            this.btnSair.CheckedState.Parent = this.btnSair;
            this.btnSair.CustomImages.Parent = this.btnSair;
            this.btnSair.FillColor = System.Drawing.Color.White;
            this.btnSair.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSair.HoverState.Parent = this.btnSair;
            this.btnSair.Location = new System.Drawing.Point(768, 587);
            this.btnSair.Name = "btnSair";
            this.btnSair.ShadowDecoration.Parent = this.btnSair;
            this.btnSair.Size = new System.Drawing.Size(101, 36);
            this.btnSair.TabIndex = 65;
            this.btnSair.Text = "Sair";
            this.btnSair.UseTransparentBackground = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Animated = true;
            this.btnConfirmar.AutoRoundedCorners = true;
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BorderRadius = 47;
            this.btnConfirmar.CheckedState.Parent = this.btnConfirmar;
            this.btnConfirmar.CustomImages.Parent = this.btnConfirmar;
            this.btnConfirmar.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.HoverState.Parent = this.btnConfirmar;
            this.btnConfirmar.Location = new System.Drawing.Point(727, 259);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.ShadowDecoration.Parent = this.btnConfirmar;
            this.btnConfirmar.Size = new System.Drawing.Size(102, 96);
            this.btnConfirmar.TabIndex = 66;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseTransparentBackground = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.Animated = true;
            this.cbTipo.AutoRoundedCorners = true;
            this.cbTipo.BackColor = System.Drawing.Color.Transparent;
            this.cbTipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipo.BorderRadius = 17;
            this.cbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipo.FocusedState.Parent = this.cbTipo;
            this.cbTipo.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTipo.HoverState.Parent = this.cbTipo;
            this.cbTipo.ItemHeight = 30;
            this.cbTipo.ItemsAppearance.Parent = this.cbTipo;
            this.cbTipo.Location = new System.Drawing.Point(28, 137);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.ShadowDecoration.Parent = this.cbTipo;
            this.cbTipo.Size = new System.Drawing.Size(251, 36);
            this.cbTipo.TabIndex = 67;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(97, 114);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(104, 22);
            this.guna2HtmlLabel1.TabIndex = 68;
            this.guna2HtmlLabel1.Text = "Filtrar Por Tipo";
            // 
            // FormRegistrarPrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurante.Properties.Resources.Design_sem_nome__2_;
            this.ClientSize = new System.Drawing.Size(890, 650);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblRetirar);
            this.Controls.Add(this.lblAdicional);
            this.Controls.Add(this.lblQualidade);
            this.Controls.Add(this.lblPratoProduto);
            this.Controls.Add(this.nQuantidade);
            this.Controls.Add(this.cbPP);
            this.Controls.Add(this.txtOBS);
            this.Controls.Add(this.painel_botoes);
            this.Controls.Add(this.paiel_topo);
            this.Controls.Add(this.clbRetirar);
            this.Controls.Add(this.clbAdicional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistrarPrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Prato";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegistrarPrato_FormClosing);
            this.Load += new System.EventHandler(this.FormRegistrarPrato_Load);
            this.painel_botoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paiel_topo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox clbAdicional;
        private System.Windows.Forms.CheckedListBox clbRetirar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel painel_botoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel paiel_topo;
        private Guna.UI2.WinForms.Guna2NumericUpDown nQuantidade;
        private Guna.UI2.WinForms.Guna2ComboBox cbPP;
        public Guna.UI2.WinForms.Guna2TextBox txtOBS;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQualidade;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPratoProduto;
        private System.Windows.Forms.Label lblAdicional;
        private System.Windows.Forms.Label lblRetirar;
        private Guna.UI2.WinForms.Guna2Button btnConfirmar;
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private Guna.UI2.WinForms.Guna2ControlBox pbFechar;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipo;
    }
}