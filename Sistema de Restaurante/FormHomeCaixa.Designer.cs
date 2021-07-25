
namespace Restaurante
{
    partial class FormHomeCaixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRegistro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLimpar = new Guna.UI2.WinForms.Guna2Button();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dgvRegistroPedido = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pedidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPedidosAbertos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.painel_botoes = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paiel_topo = new Guna.UI2.WinForms.Guna2Panel();
            this.pbFechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cbtnDelivery = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.lblMesa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPedidos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnFecharPedido = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosAbertos)).BeginInit();
            this.painel_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paiel_topo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblRegistro.Location = new System.Drawing.Point(181, 296);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(142, 22);
            this.lblRegistro.TabIndex = 16;
            this.lblRegistro.Text = "Registro do Pedido: ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Animated = true;
            this.btnLimpar.AutoRoundedCorners = true;
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BorderRadius = 17;
            this.btnLimpar.CheckedState.Parent = this.btnLimpar;
            this.btnLimpar.CustomImages.Parent = this.btnLimpar;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.HoverState.Parent = this.btnLimpar;
            this.btnLimpar.Location = new System.Drawing.Point(12, 481);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.ShadowDecoration.Parent = this.btnLimpar;
            this.btnLimpar.Size = new System.Drawing.Size(91, 36);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseTransparentBackground = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Animated = true;
            this.btnVoltar.AutoRoundedCorners = true;
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BorderRadius = 17;
            this.btnVoltar.CheckedState.Parent = this.btnVoltar;
            this.btnVoltar.CustomImages.Parent = this.btnVoltar;
            this.btnVoltar.FillColor = System.Drawing.Color.White;
            this.btnVoltar.Font = new System.Drawing.Font("Yu Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnVoltar.HoverState.Parent = this.btnVoltar;
            this.btnVoltar.Location = new System.Drawing.Point(787, 602);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.ShadowDecoration.Parent = this.btnVoltar;
            this.btnVoltar.Size = new System.Drawing.Size(91, 36);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Sair";
            this.btnVoltar.UseTransparentBackground = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // dgvRegistroPedido
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvRegistroPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvRegistroPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistroPedido.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegistroPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistroPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRegistroPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistroPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvRegistroPedido.ColumnHeadersHeight = 21;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistroPedido.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvRegistroPedido.EnableHeadersVisualStyles = false;
            this.dgvRegistroPedido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRegistroPedido.Location = new System.Drawing.Point(12, 321);
            this.dgvRegistroPedido.Name = "dgvRegistroPedido";
            this.dgvRegistroPedido.RowHeadersVisible = false;
            this.dgvRegistroPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistroPedido.Size = new System.Drawing.Size(621, 154);
            this.dgvRegistroPedido.TabIndex = 17;
            this.dgvRegistroPedido.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvRegistroPedido.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegistroPedido.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRegistroPedido.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRegistroPedido.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRegistroPedido.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRegistroPedido.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegistroPedido.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRegistroPedido.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvRegistroPedido.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRegistroPedido.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRegistroPedido.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRegistroPedido.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRegistroPedido.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvRegistroPedido.ThemeStyle.ReadOnly = false;
            this.dgvRegistroPedido.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegistroPedido.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRegistroPedido.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRegistroPedido.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRegistroPedido.ThemeStyle.RowsStyle.Height = 22;
            this.dgvRegistroPedido.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRegistroPedido.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvPedidosAbertos
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvPedidosAbertos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPedidosAbertos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidosAbertos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedidosAbertos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidosAbertos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPedidosAbertos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidosAbertos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPedidosAbertos.ColumnHeadersHeight = 21;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidosAbertos.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPedidosAbertos.EnableHeadersVisualStyles = false;
            this.dgvPedidosAbertos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPedidosAbertos.Location = new System.Drawing.Point(12, 139);
            this.dgvPedidosAbertos.Name = "dgvPedidosAbertos";
            this.dgvPedidosAbertos.RowHeadersVisible = false;
            this.dgvPedidosAbertos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidosAbertos.Size = new System.Drawing.Size(621, 147);
            this.dgvPedidosAbertos.TabIndex = 18;
            this.dgvPedidosAbertos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvPedidosAbertos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPedidosAbertos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPedidosAbertos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPedidosAbertos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPedidosAbertos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPedidosAbertos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPedidosAbertos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPedidosAbertos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvPedidosAbertos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPedidosAbertos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPedidosAbertos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPedidosAbertos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPedidosAbertos.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvPedidosAbertos.ThemeStyle.ReadOnly = false;
            this.dgvPedidosAbertos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPedidosAbertos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPedidosAbertos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPedidosAbertos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPedidosAbertos.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPedidosAbertos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPedidosAbertos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPedidosAbertos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidosAbertos_CellClick);
            // 
            // painel_botoes
            // 
            this.painel_botoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.painel_botoes.Controls.Add(this.pictureBox1);
            this.painel_botoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_botoes.Location = new System.Drawing.Point(0, 40);
            this.painel_botoes.Name = "painel_botoes";
            this.painel_botoes.ShadowDecoration.Parent = this.painel_botoes;
            this.painel_botoes.Size = new System.Drawing.Size(890, 40);
            this.painel_botoes.TabIndex = 50;
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
            this.paiel_topo.Size = new System.Drawing.Size(890, 40);
            this.paiel_topo.TabIndex = 49;
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
            this.pbFechar.TabIndex = 71;
            this.pbFechar.Click += new System.EventHandler(this.pbFechar_Click);
            // 
            // cbtnDelivery
            // 
            this.cbtnDelivery.Animated = true;
            this.cbtnDelivery.BackColor = System.Drawing.Color.Transparent;
            this.cbtnDelivery.BorderColor = System.Drawing.Color.White;
            this.cbtnDelivery.BorderRadius = 20;
            this.cbtnDelivery.BorderThickness = 3;
            this.cbtnDelivery.CheckedState.Parent = this.cbtnDelivery;
            this.cbtnDelivery.CustomImages.Parent = this.cbtnDelivery;
            this.cbtnDelivery.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.cbtnDelivery.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbtnDelivery.ForeColor = System.Drawing.Color.White;
            this.cbtnDelivery.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cbtnDelivery.HoverState.Parent = this.cbtnDelivery;
            this.cbtnDelivery.Location = new System.Drawing.Point(686, 236);
            this.cbtnDelivery.Name = "cbtnDelivery";
            this.cbtnDelivery.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cbtnDelivery.ShadowDecoration.Parent = this.cbtnDelivery;
            this.cbtnDelivery.Size = new System.Drawing.Size(137, 132);
            this.cbtnDelivery.TabIndex = 54;
            this.cbtnDelivery.Text = "Delivery";
            this.cbtnDelivery.UseTransparentBackground = true;
            this.cbtnDelivery.Click += new System.EventHandler(this.cbtnDelivery_Click);
            // 
            // lblMesa
            // 
            this.lblMesa.BackColor = System.Drawing.Color.Transparent;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblMesa.Location = new System.Drawing.Point(329, 296);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(3, 2);
            this.lblMesa.TabIndex = 55;
            this.lblMesa.Text = null;
            // 
            // lblPedidos
            // 
            this.lblPedidos.BackColor = System.Drawing.Color.Transparent;
            this.lblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPedidos.Location = new System.Drawing.Point(223, 111);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(129, 22);
            this.lblPedidos.TabIndex = 56;
            this.lblPedidos.Text = "Todos os Pedidos";
            // 
            // btnFecharPedido
            // 
            this.btnFecharPedido.Animated = true;
            this.btnFecharPedido.AutoRoundedCorners = true;
            this.btnFecharPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharPedido.BorderRadius = 17;
            this.btnFecharPedido.CheckedState.Parent = this.btnFecharPedido;
            this.btnFecharPedido.CustomImages.Parent = this.btnFecharPedido;
            this.btnFecharPedido.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnFecharPedido.ForeColor = System.Drawing.Color.White;
            this.btnFecharPedido.HoverState.Parent = this.btnFecharPedido;
            this.btnFecharPedido.Location = new System.Drawing.Point(500, 481);
            this.btnFecharPedido.Name = "btnFecharPedido";
            this.btnFecharPedido.ShadowDecoration.Parent = this.btnFecharPedido;
            this.btnFecharPedido.Size = new System.Drawing.Size(133, 36);
            this.btnFecharPedido.TabIndex = 57;
            this.btnFecharPedido.Text = "Fechar Pedido";
            this.btnFecharPedido.UseTransparentBackground = true;
            this.btnFecharPedido.Click += new System.EventHandler(this.btnFecharPedido_Click);
            // 
            // FormHomeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurante.Properties.Resources.Design_sem_nome__2_;
            this.ClientSize = new System.Drawing.Size(890, 650);
            this.Controls.Add(this.btnFecharPedido);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.cbtnDelivery);
            this.Controls.Add(this.painel_botoes);
            this.Controls.Add(this.paiel_topo);
            this.Controls.Add(this.dgvPedidosAbertos);
            this.Controls.Add(this.dgvRegistroPedido);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHomeCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home do Caixa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHomeCaixa_FormClosing);
            this.Load += new System.EventHandler(this.FormHomeCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosAbertos)).EndInit();
            this.painel_botoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paiel_topo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRegistro;
        private Guna.UI2.WinForms.Guna2HtmlLabel btnFechar;
        private Guna.UI2.WinForms.Guna2Button btnLimpar;
        private Guna.UI2.WinForms.Guna2Button btnVoltar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRegistroPedido;
 //       private RestauranteDataSet8 restauranteDataSet8;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
 //       private RestauranteDataSet8TableAdapters.PedidosTableAdapter pedidosTableAdapter;
 //       private RestauranteDataSet9 restauranteDataSet9;
        private System.Windows.Forms.BindingSource pedidosBindingSource1;
 ///       private RestauranteDataSet9TableAdapters.PedidosTableAdapter pedidosTableAdapter1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPedidosAbertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAtendenteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn1;
        private Guna.UI2.WinForms.Guna2Panel painel_botoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel paiel_topo;
        private Guna.UI2.WinForms.Guna2GradientCircleButton cbtnDelivery;
        private Guna.UI2.WinForms.Guna2ControlBox pbFechar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMesa;
        private Guna.UI2.WinForms.Guna2Button btnFecharPedido;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPedidos;
    }
}