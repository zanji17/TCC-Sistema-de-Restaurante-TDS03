
namespace Restaurante
{
    partial class FormPratosProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clbCategoria = new System.Windows.Forms.CheckedListBox();
            this.clbIngredientes = new System.Windows.Forms.CheckedListBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btnLimpar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCad = new Guna.UI2.WinForms.Guna2Button();
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTipo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ckCozinha = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clbRetirar = new System.Windows.Forms.CheckedListBox();
            this.painel_botoes = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paiel_topo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbModelo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.clbAdicional = new System.Windows.Forms.CheckedListBox();
            this.lbAdicional = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.dgvPratosProdutos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.painel_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paiel_topo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratosProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // clbCategoria
            // 
            this.clbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbCategoria.CheckOnClick = true;
            this.clbCategoria.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.clbCategoria.FormattingEnabled = true;
            this.clbCategoria.Location = new System.Drawing.Point(12, 279);
            this.clbCategoria.Name = "clbCategoria";
            this.clbCategoria.Size = new System.Drawing.Size(192, 168);
            this.clbCategoria.TabIndex = 2;
            this.clbCategoria.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbCategoria_ItemCheck);
            // 
            // clbIngredientes
            // 
            this.clbIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbIngredientes.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.clbIngredientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clbIngredientes.FormattingEnabled = true;
            this.clbIngredientes.Location = new System.Drawing.Point(12, 489);
            this.clbIngredientes.Name = "clbIngredientes";
            this.clbIngredientes.Size = new System.Drawing.Size(191, 144);
            this.clbIngredientes.TabIndex = 8;
            this.clbIngredientes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbIngredientes_ItemCheck);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblCategoria.Location = new System.Drawing.Point(12, 258);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(43, 18);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Filtro";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.BackColor = System.Drawing.Color.Transparent;
            this.lblIngredientes.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.Location = new System.Drawing.Point(12, 463);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(75, 20);
            this.lblIngredientes.TabIndex = 15;
            this.lblIngredientes.Text = "Selecione";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Animated = true;
            this.btnLimpar.AutoRoundedCorners = true;
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLimpar.BorderRadius = 16;
            this.btnLimpar.BorderThickness = 2;
            this.btnLimpar.CheckedState.Parent = this.btnLimpar;
            this.btnLimpar.CustomImages.Parent = this.btnLimpar;
            this.btnLimpar.FillColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLimpar.HoverState.Parent = this.btnLimpar;
            this.btnLimpar.Location = new System.Drawing.Point(305, 655);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.ShadowDecoration.Parent = this.btnLimpar;
            this.btnLimpar.Size = new System.Drawing.Size(87, 34);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseTransparentBackground = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCad
            // 
            this.btnCad.Animated = true;
            this.btnCad.AutoRoundedCorners = true;
            this.btnCad.BackColor = System.Drawing.Color.Transparent;
            this.btnCad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCad.BorderRadius = 17;
            this.btnCad.BorderThickness = 2;
            this.btnCad.CheckedState.Parent = this.btnCad;
            this.btnCad.CustomImages.Parent = this.btnCad;
            this.btnCad.FillColor = System.Drawing.Color.White;
            this.btnCad.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCad.HoverState.Parent = this.btnCad;
            this.btnCad.Location = new System.Drawing.Point(11, 655);
            this.btnCad.Name = "btnCad";
            this.btnCad.ShadowDecoration.Parent = this.btnCad;
            this.btnCad.Size = new System.Drawing.Size(117, 36);
            this.btnCad.TabIndex = 120;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseTransparentBackground = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnSair
            // 
            this.btnSair.Animated = true;
            this.btnSair.AutoRoundedCorners = true;
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btnSair.BorderRadius = 14;
            this.btnSair.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSair.BorderThickness = 1;
            this.btnSair.CheckedState.Parent = this.btnSair;
            this.btnSair.CustomImages.Parent = this.btnSair;
            this.btnSair.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.HoverState.Parent = this.btnSair;
            this.btnSair.Location = new System.Drawing.Point(831, 658);
            this.btnSair.Name = "btnSair";
            this.btnSair.ShadowDecoration.Parent = this.btnSair;
            this.btnSair.Size = new System.Drawing.Size(87, 30);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseTransparentBackground = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.AutoRoundedCorners = true;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEdit.BorderRadius = 16;
            this.btnEdit.BorderThickness = 2;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(398, 655);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(89, 34);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseTransparentBackground = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Animated = true;
            this.btnDel.AutoRoundedCorners = true;
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDel.BorderRadius = 16;
            this.btnDel.BorderThickness = 2;
            this.btnDel.CheckedState.Parent = this.btnDel;
            this.btnDel.CustomImages.Parent = this.btnDel;
            this.btnDel.FillColor = System.Drawing.Color.White;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDel.HoverState.Parent = this.btnDel;
            this.btnDel.Location = new System.Drawing.Point(493, 655);
            this.btnDel.Name = "btnDel";
            this.btnDel.ShadowDecoration.Parent = this.btnDel;
            this.btnDel.Size = new System.Drawing.Size(87, 34);
            this.btnDel.TabIndex = 22;
            this.btnDel.Text = "Apagar";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtNome
            // 
            this.txtNome.Animated = true;
            this.txtNome.AutoRoundedCorners = true;
            this.txtNome.BackColor = System.Drawing.Color.Transparent;
            this.txtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.BorderRadius = 15;
            this.txtNome.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.Parent = this.txtNome;
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.FocusedState.Parent = this.txtNome;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.HoverState.Parent = this.txtNome;
            this.txtNome.Location = new System.Drawing.Point(11, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.SelectedText = "";
            this.txtNome.ShadowDecoration.Parent = this.txtNome;
            this.txtNome.Size = new System.Drawing.Size(203, 32);
            this.txtNome.TabIndex = 54;
            // 
            // txtTipo
            // 
            this.txtTipo.Animated = true;
            this.txtTipo.AutoRoundedCorners = true;
            this.txtTipo.BackColor = System.Drawing.Color.Transparent;
            this.txtTipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipo.BorderRadius = 15;
            this.txtTipo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipo.DefaultText = "";
            this.txtTipo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTipo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTipo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTipo.DisabledState.Parent = this.txtTipo;
            this.txtTipo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipo.FocusedState.Parent = this.txtTipo;
            this.txtTipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTipo.ForeColor = System.Drawing.Color.Black;
            this.txtTipo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipo.HoverState.Parent = this.txtTipo;
            this.txtTipo.Location = new System.Drawing.Point(11, 131);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.PasswordChar = '\0';
            this.txtTipo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipo.PlaceholderText = "Tipo";
            this.txtTipo.SelectedText = "";
            this.txtTipo.ShadowDecoration.Parent = this.txtTipo;
            this.txtTipo.Size = new System.Drawing.Size(203, 32);
            this.txtTipo.TabIndex = 55;
            this.txtTipo.Enter += new System.EventHandler(this.txtTipo_Enter);
            // 
            // ckCozinha
            // 
            this.ckCozinha.AutoSize = true;
            this.ckCozinha.BackColor = System.Drawing.Color.Transparent;
            this.ckCozinha.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ckCozinha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckCozinha.CheckedState.BorderRadius = 17;
            this.ckCozinha.CheckedState.BorderThickness = 0;
            this.ckCozinha.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckCozinha.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCozinha.ForeColor = System.Drawing.Color.Black;
            this.ckCozinha.Location = new System.Drawing.Point(27, 169);
            this.ckCozinha.Name = "ckCozinha";
            this.ckCozinha.Size = new System.Drawing.Size(170, 24);
            this.ckCozinha.TabIndex = 59;
            this.ckCozinha.Text = "Será feito na cozinha";
            this.ckCozinha.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.ckCozinha.UncheckedState.BorderRadius = 0;
            this.ckCozinha.UncheckedState.BorderThickness = 0;
            this.ckCozinha.UncheckedState.FillColor = System.Drawing.Color.White;
            this.ckCozinha.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Marque os Retirável";
            // 
            // clbRetirar
            // 
            this.clbRetirar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbRetirar.CheckOnClick = true;
            this.clbRetirar.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbRetirar.FormattingEnabled = true;
            this.clbRetirar.Location = new System.Drawing.Point(254, 101);
            this.clbRetirar.Name = "clbRetirar";
            this.clbRetirar.Size = new System.Drawing.Size(258, 189);
            this.clbRetirar.TabIndex = 60;
            // 
            // painel_botoes
            // 
            this.painel_botoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.painel_botoes.Controls.Add(this.pictureBox1);
            this.painel_botoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_botoes.Location = new System.Drawing.Point(0, 30);
            this.painel_botoes.Name = "painel_botoes";
            this.painel_botoes.ShadowDecoration.Parent = this.painel_botoes;
            this.painel_botoes.Size = new System.Drawing.Size(930, 35);
            this.painel_botoes.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.logo_azul_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // paiel_topo
            // 
            this.paiel_topo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paiel_topo.Controls.Add(this.guna2ControlBox1);
            this.paiel_topo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paiel_topo.Location = new System.Drawing.Point(0, 0);
            this.paiel_topo.Name = "paiel_topo";
            this.paiel_topo.ShadowDecoration.Parent = this.paiel_topo;
            this.paiel_topo.Size = new System.Drawing.Size(930, 30);
            this.paiel_topo.TabIndex = 62;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.guna2ControlBox1.Location = new System.Drawing.Point(865, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(65, 27);
            this.guna2ControlBox1.TabIndex = 69;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.25F);
            this.label2.Location = new System.Drawing.Point(292, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Opções de adicionais do prato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.25F);
            this.label3.Location = new System.Drawing.Point(343, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Modelo Pronto:";
            // 
            // cbModelo
            // 
            this.cbModelo.Animated = true;
            this.cbModelo.BackColor = System.Drawing.Color.Transparent;
            this.cbModelo.BorderColor = System.Drawing.SystemColors.Control;
            this.cbModelo.BorderRadius = 10;
            this.cbModelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModelo.FocusedState.Parent = this.cbModelo;
            this.cbModelo.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.cbModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbModelo.HoverState.Parent = this.cbModelo;
            this.cbModelo.ItemHeight = 30;
            this.cbModelo.ItemsAppearance.Parent = this.cbModelo;
            this.cbModelo.Location = new System.Drawing.Point(254, 549);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.ShadowDecoration.Parent = this.cbModelo;
            this.cbModelo.Size = new System.Drawing.Size(274, 36);
            this.cbModelo.TabIndex = 66;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged);
            // 
            // clbAdicional
            // 
            this.clbAdicional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbAdicional.CheckOnClick = true;
            this.clbAdicional.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.clbAdicional.FormattingEnabled = true;
            this.clbAdicional.Location = new System.Drawing.Point(400, 359);
            this.clbAdicional.Name = "clbAdicional";
            this.clbAdicional.Size = new System.Drawing.Size(128, 144);
            this.clbAdicional.TabIndex = 67;
            this.clbAdicional.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbAdicional_ItemCheck);
            // 
            // lbAdicional
            // 
            this.lbAdicional.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lbAdicional.FormattingEnabled = true;
            this.lbAdicional.ItemHeight = 17;
            this.lbAdicional.Location = new System.Drawing.Point(254, 359);
            this.lbAdicional.Name = "lbAdicional";
            this.lbAdicional.Size = new System.Drawing.Size(128, 157);
            this.lbAdicional.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 10.25F);
            this.label4.Location = new System.Drawing.Point(39, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 64;
            this.label4.Text = "Ingredientes do Prato";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2VSeparator1.FillThickness = 3;
            this.guna2VSeparator1.Location = new System.Drawing.Point(220, 289);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(18, 342);
            this.guna2VSeparator1.TabIndex = 69;
            this.guna2VSeparator1.UseTransparentBackground = true;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(229, 298);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(299, 10);
            this.guna2Separator1.TabIndex = 70;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2VSeparator2.FillThickness = 3;
            this.guna2VSeparator2.Location = new System.Drawing.Point(220, 80);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(18, 214);
            this.guna2VSeparator2.TabIndex = 71;
            this.guna2VSeparator2.UseTransparentBackground = true;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Separator2.FillThickness = 3;
            this.guna2Separator2.Location = new System.Drawing.Point(11, 209);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(219, 10);
            this.guna2Separator2.TabIndex = 72;
            this.guna2Separator2.UseTransparentBackground = true;
            // 
            // dgvPratosProdutos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPratosProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPratosProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPratosProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPratosProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPratosProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPratosProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPratosProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPratosProdutos.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPratosProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPratosProdutos.EnableHeadersVisualStyles = false;
            this.dgvPratosProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPratosProdutos.Location = new System.Drawing.Point(549, 81);
            this.dgvPratosProdutos.Name = "dgvPratosProdutos";
            this.dgvPratosProdutos.ReadOnly = true;
            this.dgvPratosProdutos.RowHeadersVisible = false;
            this.dgvPratosProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPratosProdutos.Size = new System.Drawing.Size(369, 560);
            this.dgvPratosProdutos.TabIndex = 121;
            this.dgvPratosProdutos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvPratosProdutos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPratosProdutos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPratosProdutos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPratosProdutos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPratosProdutos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPratosProdutos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPratosProdutos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPratosProdutos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvPratosProdutos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPratosProdutos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPratosProdutos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPratosProdutos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPratosProdutos.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvPratosProdutos.ThemeStyle.ReadOnly = true;
            this.dgvPratosProdutos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPratosProdutos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPratosProdutos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPratosProdutos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPratosProdutos.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPratosProdutos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPratosProdutos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPratosProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPratosProdutos_CellClick_1);
            // 
            // txtValor
            // 
            this.txtValor.Animated = true;
            this.txtValor.AutoRoundedCorners = true;
            this.txtValor.BackColor = System.Drawing.Color.Transparent;
            this.txtValor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.BorderRadius = 17;
            this.txtValor.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.DefaultText = "";
            this.txtValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.DisabledState.Parent = this.txtValor;
            this.txtValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.FocusedState.Parent = this.txtValor;
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.HoverState.Parent = this.txtValor;
            this.txtValor.Location = new System.Drawing.Point(254, 597);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.PlaceholderText = "Preço";
            this.txtValor.SelectedText = "";
            this.txtValor.ShadowDecoration.Parent = this.txtValor;
            this.txtValor.Size = new System.Drawing.Size(274, 36);
            this.txtValor.TabIndex = 122;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // FormPratosProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurante.Properties.Resources.Design_sem_nome__2_;
            this.ClientSize = new System.Drawing.Size(930, 697);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.dgvPratosProdutos);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2VSeparator2);
            this.Controls.Add(this.ckCozinha);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.lbAdicional);
            this.Controls.Add(this.clbAdicional);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.painel_botoes);
            this.Controls.Add(this.paiel_topo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbRetirar);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.clbIngredientes);
            this.Controls.Add(this.clbCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPratosProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pratos/Produtos";
            this.Load += new System.EventHandler(this.FormPratosProdutos_Load);
            this.painel_botoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paiel_topo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratosProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox clbCategoria;
        private System.Windows.Forms.CheckedListBox clbIngredientes;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblIngredientes;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private Guna.UI2.WinForms.Guna2Button btnCad;
        private Guna.UI2.WinForms.Guna2Button btnLimpar;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2TextBox txtTipo;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbRetirar;
        private Guna.UI2.WinForms.Guna2CheckBox ckCozinha;
        private Guna.UI2.WinForms.Guna2Panel painel_botoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel paiel_topo;
        private Guna.UI2.WinForms.Guna2ComboBox cbModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbAdicional;
        private System.Windows.Forms.CheckedListBox clbAdicional;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPratosProdutos;
        private Guna.UI2.WinForms.Guna2TextBox txtValor;
    }
}

