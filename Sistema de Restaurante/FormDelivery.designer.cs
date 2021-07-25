
namespace Restaurante
{
    partial class FormDelivery
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
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTodosPedidos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMeusPedidos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.txtEndereco = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBairro = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtComplemento = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAberto = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvFinalizado = new Guna.UI2.WinForms.Guna2DataGridView();
            this.painel_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paiel_topo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAberto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizado)).BeginInit();
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
            this.pbFechar.TabIndex = 68;
            this.pbFechar.Click += new System.EventHandler(this.pbFechar_Click);
            // 
            // btnCriarPedidoAtendente
            // 
            this.btnCriarPedidoAtendente.Animated = true;
            this.btnCriarPedidoAtendente.AutoRoundedCorners = true;
            this.btnCriarPedidoAtendente.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarPedidoAtendente.BorderRadius = 24;
            this.btnCriarPedidoAtendente.CheckedState.Parent = this.btnCriarPedidoAtendente;
            this.btnCriarPedidoAtendente.CustomImages.Parent = this.btnCriarPedidoAtendente;
            this.btnCriarPedidoAtendente.Font = new System.Drawing.Font("Yu Gothic UI", 11.75F);
            this.btnCriarPedidoAtendente.ForeColor = System.Drawing.Color.White;
            this.btnCriarPedidoAtendente.HoverState.Parent = this.btnCriarPedidoAtendente;
            this.btnCriarPedidoAtendente.Location = new System.Drawing.Point(80, 438);
            this.btnCriarPedidoAtendente.Name = "btnCriarPedidoAtendente";
            this.btnCriarPedidoAtendente.ShadowDecoration.Parent = this.btnCriarPedidoAtendente;
            this.btnCriarPedidoAtendente.Size = new System.Drawing.Size(130, 50);
            this.btnCriarPedidoAtendente.TabIndex = 53;
            this.btnCriarPedidoAtendente.Text = "Criar Pedido";
            this.btnCriarPedidoAtendente.UseTransparentBackground = true;
            this.btnCriarPedidoAtendente.Click += new System.EventHandler(this.btnCriarPedidoAtendente_Click);
            // 
            // txtNome
            // 
            this.txtNome.Animated = true;
            this.txtNome.AutoRoundedCorners = true;
            this.txtNome.BackColor = System.Drawing.Color.Transparent;
            this.txtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.BorderRadius = 17;
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
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.HoverState.Parent = this.txtNome;
            this.txtNome.Location = new System.Drawing.Point(18, 144);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.SelectedText = "";
            this.txtNome.ShadowDecoration.Parent = this.txtNome;
            this.txtNome.Size = new System.Drawing.Size(254, 36);
            this.txtNome.TabIndex = 55;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Animated = true;
            this.txtTelefone.AutoRoundedCorners = true;
            this.txtTelefone.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefone.BorderRadius = 17;
            this.txtTelefone.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.DefaultText = "";
            this.txtTelefone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefone.DisabledState.Parent = this.txtTelefone;
            this.txtTelefone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefone.FocusedState.Parent = this.txtTelefone;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefone.ForeColor = System.Drawing.Color.Black;
            this.txtTelefone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefone.HoverState.Parent = this.txtTelefone;
            this.txtTelefone.Location = new System.Drawing.Point(18, 200);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefone.PlaceholderText = "Telefone";
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.ShadowDecoration.Parent = this.txtTelefone;
            this.txtTelefone.Size = new System.Drawing.Size(254, 36);
            this.txtTelefone.TabIndex = 56;
            // 
            // lblTodosPedidos
            // 
            this.lblTodosPedidos.BackColor = System.Drawing.Color.Transparent;
            this.lblTodosPedidos.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodosPedidos.ForeColor = System.Drawing.Color.Black;
            this.lblTodosPedidos.Location = new System.Drawing.Point(499, 320);
            this.lblTodosPedidos.Name = "lblTodosPedidos";
            this.lblTodosPedidos.Size = new System.Drawing.Size(212, 29);
            this.lblTodosPedidos.TabIndex = 59;
            this.lblTodosPedidos.Text = "Deliverys Finalizados";
            // 
            // lblMeusPedidos
            // 
            this.lblMeusPedidos.BackColor = System.Drawing.Color.Transparent;
            this.lblMeusPedidos.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeusPedidos.ForeColor = System.Drawing.Color.Black;
            this.lblMeusPedidos.Location = new System.Drawing.Point(506, 111);
            this.lblMeusPedidos.Name = "lblMeusPedidos";
            this.lblMeusPedidos.Size = new System.Drawing.Size(199, 29);
            this.lblMeusPedidos.TabIndex = 60;
            this.lblMeusPedidos.Text = "Deliverys em aberto";
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
            this.btnSair.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.btnSair.HoverState.Parent = this.btnSair;
            this.btnSair.Location = new System.Drawing.Point(837, 601);
            this.btnSair.Name = "btnSair";
            this.btnSair.ShadowDecoration.Parent = this.btnSair;
            this.btnSair.Size = new System.Drawing.Size(91, 36);
            this.btnSair.TabIndex = 62;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Animated = true;
            this.txtEndereco.AutoRoundedCorners = true;
            this.txtEndereco.BackColor = System.Drawing.Color.Transparent;
            this.txtEndereco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndereco.BorderRadius = 17;
            this.txtEndereco.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.DefaultText = "";
            this.txtEndereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEndereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEndereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndereco.DisabledState.Parent = this.txtEndereco;
            this.txtEndereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndereco.FocusedState.Parent = this.txtEndereco;
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEndereco.ForeColor = System.Drawing.Color.Black;
            this.txtEndereco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndereco.HoverState.Parent = this.txtEndereco;
            this.txtEndereco.Location = new System.Drawing.Point(18, 251);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndereco.PlaceholderText = "Endereço";
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.ShadowDecoration.Parent = this.txtEndereco;
            this.txtEndereco.Size = new System.Drawing.Size(254, 36);
            this.txtEndereco.TabIndex = 63;
            // 
            // txtBairro
            // 
            this.txtBairro.Animated = true;
            this.txtBairro.AutoRoundedCorners = true;
            this.txtBairro.BackColor = System.Drawing.Color.Transparent;
            this.txtBairro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBairro.BorderRadius = 17;
            this.txtBairro.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBairro.DefaultText = "";
            this.txtBairro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBairro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBairro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBairro.DisabledState.Parent = this.txtBairro;
            this.txtBairro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBairro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBairro.FocusedState.Parent = this.txtBairro;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBairro.HoverState.Parent = this.txtBairro;
            this.txtBairro.Location = new System.Drawing.Point(18, 304);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBairro.PlaceholderText = "Bairro";
            this.txtBairro.SelectedText = "";
            this.txtBairro.ShadowDecoration.Parent = this.txtBairro;
            this.txtBairro.Size = new System.Drawing.Size(254, 36);
            this.txtBairro.TabIndex = 64;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Animated = true;
            this.txtComplemento.AutoRoundedCorners = true;
            this.txtComplemento.BackColor = System.Drawing.Color.Transparent;
            this.txtComplemento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComplemento.BorderRadius = 17;
            this.txtComplemento.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtComplemento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComplemento.DefaultText = "";
            this.txtComplemento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComplemento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComplemento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComplemento.DisabledState.Parent = this.txtComplemento;
            this.txtComplemento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComplemento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComplemento.FocusedState.Parent = this.txtComplemento;
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComplemento.ForeColor = System.Drawing.Color.Black;
            this.txtComplemento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComplemento.HoverState.Parent = this.txtComplemento;
            this.txtComplemento.Location = new System.Drawing.Point(18, 361);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.PasswordChar = '\0';
            this.txtComplemento.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComplemento.PlaceholderText = "Complemento";
            this.txtComplemento.SelectedText = "";
            this.txtComplemento.ShadowDecoration.Parent = this.txtComplemento;
            this.txtComplemento.Size = new System.Drawing.Size(254, 36);
            this.txtComplemento.TabIndex = 65;
            // 
            // btnEditar
            // 
            this.btnEditar.Animated = true;
            this.btnEditar.AutoRoundedCorners = true;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BorderRadius = 21;
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.btnEditar.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Location = new System.Drawing.Point(73, 494);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(144, 45);
            this.btnEditar.TabIndex = 66;
            this.btnEditar.Text = "Editar Informações";
            this.btnEditar.UseTransparentBackground = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvAberto
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvAberto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAberto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAberto.BackgroundColor = System.Drawing.Color.White;
            this.dgvAberto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAberto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAberto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAberto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAberto.ColumnHeadersHeight = 21;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAberto.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAberto.EnableHeadersVisualStyles = false;
            this.dgvAberto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAberto.Location = new System.Drawing.Point(319, 144);
            this.dgvAberto.Name = "dgvAberto";
            this.dgvAberto.ReadOnly = true;
            this.dgvAberto.RowHeadersVisible = false;
            this.dgvAberto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAberto.Size = new System.Drawing.Size(593, 163);
            this.dgvAberto.TabIndex = 67;
            this.dgvAberto.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvAberto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAberto.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAberto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAberto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAberto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAberto.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAberto.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAberto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvAberto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAberto.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAberto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAberto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAberto.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvAberto.ThemeStyle.ReadOnly = true;
            this.dgvAberto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAberto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAberto.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAberto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAberto.ThemeStyle.RowsStyle.Height = 22;
            this.dgvAberto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAberto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAberto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAberto_CellClick);
            // 
            // dgvFinalizado
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFinalizado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinalizado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinalizado.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinalizado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFinalizado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFinalizado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinalizado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFinalizado.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinalizado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFinalizado.EnableHeadersVisualStyles = false;
            this.dgvFinalizado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFinalizado.Location = new System.Drawing.Point(319, 355);
            this.dgvFinalizado.Name = "dgvFinalizado";
            this.dgvFinalizado.ReadOnly = true;
            this.dgvFinalizado.RowHeadersVisible = false;
            this.dgvFinalizado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinalizado.Size = new System.Drawing.Size(593, 167);
            this.dgvFinalizado.TabIndex = 68;
            this.dgvFinalizado.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvFinalizado.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFinalizado.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFinalizado.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFinalizado.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFinalizado.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFinalizado.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFinalizado.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFinalizado.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvFinalizado.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFinalizado.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFinalizado.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFinalizado.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFinalizado.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvFinalizado.ThemeStyle.ReadOnly = true;
            this.dgvFinalizado.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFinalizado.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFinalizado.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFinalizado.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFinalizado.ThemeStyle.RowsStyle.Height = 22;
            this.dgvFinalizado.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFinalizado.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFinalizado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinalizado_CellClick);
            // 
            // FormDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurante.Properties.Resources.Design_sem_nome__2_;
            this.ClientSize = new System.Drawing.Size(940, 649);
            this.Controls.Add(this.dgvFinalizado);
            this.Controls.Add(this.dgvAberto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblMeusPedidos);
            this.Controls.Add(this.lblTodosPedidos);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCriarPedidoAtendente);
            this.Controls.Add(this.painel_botoes);
            this.Controls.Add(this.paiel_topo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home do Atendente";
            this.Load += new System.EventHandler(this.FormDelivery_Load);
            this.painel_botoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paiel_topo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAberto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel painel_botoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel paiel_topo;
        private Guna.UI2.WinForms.Guna2Button btnCriarPedidoAtendente;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTodosPedidos;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMeusPedidos;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private Guna.UI2.WinForms.Guna2TextBox txtComplemento;
        private Guna.UI2.WinForms.Guna2TextBox txtBairro;
        private Guna.UI2.WinForms.Guna2TextBox txtEndereco;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2ControlBox pbFechar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFinalizado;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAberto;
    }
}