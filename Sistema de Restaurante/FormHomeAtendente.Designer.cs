
namespace Restaurante
{
    partial class FormHomeAtendente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.painel_botoes = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paiel_topo = new Guna.UI2.WinForms.Guna2Panel();
            this.pbFechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnCriarPedidoAtendente = new Guna.UI2.WinForms.Guna2Button();
            this.txtMesa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.nPessoas = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblTodosPedidos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMeusPedidos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMeusPedidos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvTodosPedidos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.painel_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paiel_topo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeusPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // painel_botoes
            // 
            this.painel_botoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.painel_botoes.Controls.Add(this.pictureBox1);
            this.painel_botoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_botoes.Location = new System.Drawing.Point(0, 40);
            this.painel_botoes.Name = "painel_botoes";
            this.painel_botoes.ShadowDecoration.Parent = this.painel_botoes;
            this.painel_botoes.Size = new System.Drawing.Size(940, 40);
            this.painel_botoes.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.logo_azul_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 40);
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
            this.paiel_topo.Size = new System.Drawing.Size(940, 40);
            this.paiel_topo.TabIndex = 51;
            // 
            // pbFechar
            // 
            this.pbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFechar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pbFechar.HoverState.Parent = this.pbFechar;
            this.pbFechar.IconColor = System.Drawing.Color.White;
            this.pbFechar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pbFechar.Location = new System.Drawing.Point(875, 0);
            this.pbFechar.Name = "pbFechar";
            this.pbFechar.ShadowDecoration.Parent = this.pbFechar;
            this.pbFechar.Size = new System.Drawing.Size(65, 40);
            this.pbFechar.TabIndex = 70;
            // 
            // btnCriarPedidoAtendente
            // 
            this.btnCriarPedidoAtendente.Animated = true;
            this.btnCriarPedidoAtendente.AutoRoundedCorners = true;
            this.btnCriarPedidoAtendente.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarPedidoAtendente.BorderRadius = 17;
            this.btnCriarPedidoAtendente.CheckedState.Parent = this.btnCriarPedidoAtendente;
            this.btnCriarPedidoAtendente.CustomImages.Parent = this.btnCriarPedidoAtendente;
            this.btnCriarPedidoAtendente.Font = new System.Drawing.Font("Yu Gothic UI", 11.75F);
            this.btnCriarPedidoAtendente.ForeColor = System.Drawing.Color.White;
            this.btnCriarPedidoAtendente.HoverState.Parent = this.btnCriarPedidoAtendente;
            this.btnCriarPedidoAtendente.Location = new System.Drawing.Point(737, 343);
            this.btnCriarPedidoAtendente.Name = "btnCriarPedidoAtendente";
            this.btnCriarPedidoAtendente.ShadowDecoration.Parent = this.btnCriarPedidoAtendente;
            this.btnCriarPedidoAtendente.Size = new System.Drawing.Size(152, 36);
            this.btnCriarPedidoAtendente.TabIndex = 53;
            this.btnCriarPedidoAtendente.Text = "Criar Pedido";
            this.btnCriarPedidoAtendente.UseTransparentBackground = true;
            this.btnCriarPedidoAtendente.Click += new System.EventHandler(this.btnCriarPedidoAtendente_Click);
            // 
            // txtMesa
            // 
            this.txtMesa.Animated = true;
            this.txtMesa.AutoRoundedCorners = true;
            this.txtMesa.BackColor = System.Drawing.Color.Transparent;
            this.txtMesa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMesa.BorderRadius = 17;
            this.txtMesa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtMesa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMesa.DefaultText = "";
            this.txtMesa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMesa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMesa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMesa.DisabledState.Parent = this.txtMesa;
            this.txtMesa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMesa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMesa.FocusedState.Parent = this.txtMesa;
            this.txtMesa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMesa.ForeColor = System.Drawing.Color.Black;
            this.txtMesa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMesa.HoverState.Parent = this.txtMesa;
            this.txtMesa.Location = new System.Drawing.Point(680, 136);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.PasswordChar = '\0';
            this.txtMesa.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMesa.PlaceholderText = "Mesa";
            this.txtMesa.SelectedText = "";
            this.txtMesa.ShadowDecoration.Parent = this.txtMesa;
            this.txtMesa.Size = new System.Drawing.Size(248, 36);
            this.txtMesa.TabIndex = 55;
            // 
            // txtCliente
            // 
            this.txtCliente.Animated = true;
            this.txtCliente.AutoRoundedCorners = true;
            this.txtCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCliente.BorderRadius = 17;
            this.txtCliente.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCliente.DefaultText = "";
            this.txtCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCliente.DisabledState.Parent = this.txtCliente;
            this.txtCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCliente.FocusedState.Parent = this.txtCliente;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCliente.HoverState.Parent = this.txtCliente;
            this.txtCliente.Location = new System.Drawing.Point(680, 195);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCliente.PlaceholderText = "Cliente";
            this.txtCliente.SelectedText = "";
            this.txtCliente.ShadowDecoration.Parent = this.txtCliente;
            this.txtCliente.Size = new System.Drawing.Size(248, 36);
            this.txtCliente.TabIndex = 56;
            // 
            // nPessoas
            // 
            this.nPessoas.AutoRoundedCorners = true;
            this.nPessoas.BackColor = System.Drawing.Color.Transparent;
            this.nPessoas.BorderRadius = 17;
            this.nPessoas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nPessoas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nPessoas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nPessoas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nPessoas.DisabledState.Parent = this.nPessoas;
            this.nPessoas.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nPessoas.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nPessoas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nPessoas.FocusedState.Parent = this.nPessoas;
            this.nPessoas.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.nPessoas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nPessoas.Location = new System.Drawing.Point(680, 259);
            this.nPessoas.Name = "nPessoas";
            this.nPessoas.ShadowDecoration.Parent = this.nPessoas;
            this.nPessoas.Size = new System.Drawing.Size(248, 36);
            this.nPessoas.TabIndex = 57;
            this.nPessoas.UseTransparentBackground = true;
            // 
            // lblTodosPedidos
            // 
            this.lblTodosPedidos.BackColor = System.Drawing.Color.Transparent;
            this.lblTodosPedidos.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodosPedidos.ForeColor = System.Drawing.Color.Black;
            this.lblTodosPedidos.Location = new System.Drawing.Point(29, 364);
            this.lblTodosPedidos.Name = "lblTodosPedidos";
            this.lblTodosPedidos.Size = new System.Drawing.Size(161, 27);
            this.lblTodosPedidos.TabIndex = 59;
            this.lblTodosPedidos.Text = "Todos os Pedidos";
            // 
            // lblMeusPedidos
            // 
            this.lblMeusPedidos.BackColor = System.Drawing.Color.Transparent;
            this.lblMeusPedidos.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeusPedidos.ForeColor = System.Drawing.Color.Black;
            this.lblMeusPedidos.Location = new System.Drawing.Point(29, 103);
            this.lblMeusPedidos.Name = "lblMeusPedidos";
            this.lblMeusPedidos.Size = new System.Drawing.Size(129, 27);
            this.lblMeusPedidos.TabIndex = 60;
            this.lblMeusPedidos.Text = "Meus Pedidos";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // btnSair
            // 
            this.btnSair.AutoRoundedCorners = true;
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BorderRadius = 17;
            this.btnSair.CheckedState.Parent = this.btnSair;
            this.btnSair.CustomImages.Parent = this.btnSair;
            this.btnSair.FillColor = System.Drawing.Color.White;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSair.HoverState.Parent = this.btnSair;
            this.btnSair.Location = new System.Drawing.Point(837, 601);
            this.btnSair.Name = "btnSair";
            this.btnSair.ShadowDecoration.Parent = this.btnSair;
            this.btnSair.Size = new System.Drawing.Size(91, 36);
            this.btnSair.TabIndex = 62;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pedidosBindingSource1
            // 
            this.pedidosBindingSource1.DataMember = "Pedidos";
            // 
            // dgvMeusPedidos
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvMeusPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMeusPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeusPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMeusPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMeusPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMeusPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeusPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMeusPedidos.ColumnHeadersHeight = 21;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMeusPedidos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMeusPedidos.EnableHeadersVisualStyles = false;
            this.dgvMeusPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMeusPedidos.Location = new System.Drawing.Point(29, 136);
            this.dgvMeusPedidos.Name = "dgvMeusPedidos";
            this.dgvMeusPedidos.ReadOnly = true;
            this.dgvMeusPedidos.RowHeadersVisible = false;
            this.dgvMeusPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeusPedidos.Size = new System.Drawing.Size(632, 207);
            this.dgvMeusPedidos.TabIndex = 64;
            this.dgvMeusPedidos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvMeusPedidos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMeusPedidos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMeusPedidos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMeusPedidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMeusPedidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMeusPedidos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMeusPedidos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMeusPedidos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvMeusPedidos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMeusPedidos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMeusPedidos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMeusPedidos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMeusPedidos.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvMeusPedidos.ThemeStyle.ReadOnly = true;
            this.dgvMeusPedidos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMeusPedidos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMeusPedidos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMeusPedidos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMeusPedidos.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMeusPedidos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMeusPedidos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMeusPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeusPedidos_CellClick);
            // 
            // dgvTodosPedidos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTodosPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodosPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodosPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodosPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTodosPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTodosPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodosPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTodosPedidos.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTodosPedidos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTodosPedidos.EnableHeadersVisualStyles = false;
            this.dgvTodosPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTodosPedidos.Location = new System.Drawing.Point(29, 397);
            this.dgvTodosPedidos.Name = "dgvTodosPedidos";
            this.dgvTodosPedidos.ReadOnly = true;
            this.dgvTodosPedidos.RowHeadersVisible = false;
            this.dgvTodosPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodosPedidos.Size = new System.Drawing.Size(632, 207);
            this.dgvTodosPedidos.TabIndex = 65;
            this.dgvTodosPedidos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvTodosPedidos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTodosPedidos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTodosPedidos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTodosPedidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTodosPedidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTodosPedidos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTodosPedidos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTodosPedidos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvTodosPedidos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTodosPedidos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTodosPedidos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTodosPedidos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTodosPedidos.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvTodosPedidos.ThemeStyle.ReadOnly = true;
            this.dgvTodosPedidos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTodosPedidos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTodosPedidos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTodosPedidos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTodosPedidos.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTodosPedidos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTodosPedidos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTodosPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodosPedidos_CellClick);
            // 
            // FormHomeAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurante.Properties.Resources.Design_sem_nome__2_;
            this.ClientSize = new System.Drawing.Size(940, 649);
            this.Controls.Add(this.dgvTodosPedidos);
            this.Controls.Add(this.dgvMeusPedidos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblMeusPedidos);
            this.Controls.Add(this.lblTodosPedidos);
            this.Controls.Add(this.nPessoas);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtMesa);
            this.Controls.Add(this.btnCriarPedidoAtendente);
            this.Controls.Add(this.painel_botoes);
            this.Controls.Add(this.paiel_topo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHomeAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home do Atendente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHomeAtendente_FormClosing);
            this.Load += new System.EventHandler(this.FormHomeAtendente_Load);
            this.painel_botoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paiel_topo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeusPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel painel_botoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel paiel_topo;
        private Guna.UI2.WinForms.Guna2Button btnCriarPedidoAtendente;
        private Guna.UI2.WinForms.Guna2TextBox txtMesa;
        private Guna.UI2.WinForms.Guna2TextBox txtCliente;
        private Guna.UI2.WinForms.Guna2NumericUpDown nPessoas;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTodosPedidos;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMeusPedidos;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private System.Windows.Forms.BindingSource pedidosBindingSource1;
        private Guna.UI2.WinForms.Guna2ControlBox pbFechar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTodosPedidos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMeusPedidos;
    }
}