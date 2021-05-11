
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
            this.btnCriarPedido = new System.Windows.Forms.Button();
            this.txtMesa = new System.Windows.Forms.TextBox();
            this.dgvMeusPedidos = new System.Windows.Forms.DataGridView();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblMeusPedidos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTodosPedidos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nPessoas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeusPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarPedido
            // 
            this.btnCriarPedido.Location = new System.Drawing.Point(488, 25);
            this.btnCriarPedido.Name = "btnCriarPedido";
            this.btnCriarPedido.Size = new System.Drawing.Size(88, 30);
            this.btnCriarPedido.TabIndex = 0;
            this.btnCriarPedido.Text = "Criar Pedido";
            this.btnCriarPedido.UseVisualStyleBackColor = true;
            this.btnCriarPedido.Click += new System.EventHandler(this.btnCriarPedido_Click);
            // 
            // txtMesa
            // 
            this.txtMesa.Location = new System.Drawing.Point(131, 31);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Size = new System.Drawing.Size(128, 20);
            this.txtMesa.TabIndex = 1;
            // 
            // dgvMeusPedidos
            // 
            this.dgvMeusPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMeusPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeusPedidos.Location = new System.Drawing.Point(107, 88);
            this.dgvMeusPedidos.Name = "dgvMeusPedidos";
            this.dgvMeusPedidos.Size = new System.Drawing.Size(445, 150);
            this.dgvMeusPedidos.TabIndex = 2;
            this.dgvMeusPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeusPedidos_CellClick);
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(128, 15);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(76, 13);
            this.lblMesa.TabIndex = 3;
            this.lblMesa.Text = "Mesa/Delivery";
            // 
            // lblMeusPedidos
            // 
            this.lblMeusPedidos.AutoSize = true;
            this.lblMeusPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeusPedidos.Location = new System.Drawing.Point(261, 65);
            this.lblMeusPedidos.Name = "lblMeusPedidos";
            this.lblMeusPedidos.Size = new System.Drawing.Size(121, 20);
            this.lblMeusPedidos.TabIndex = 4;
            this.lblMeusPedidos.Text = "Meus Pedidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Todos os Pedidos";
            // 
            // dgvTodosPedidos
            // 
            this.dgvTodosPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTodosPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodosPedidos.Location = new System.Drawing.Point(71, 275);
            this.dgvTodosPedidos.Name = "dgvTodosPedidos";
            this.dgvTodosPedidos.Size = new System.Drawing.Size(515, 150);
            this.dgvTodosPedidos.TabIndex = 5;
            this.dgvTodosPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodosPedidos_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(265, 31);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(128, 20);
            this.txtCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nº Pessoas";
            // 
            // nPessoas
            // 
            this.nPessoas.Location = new System.Drawing.Point(404, 31);
            this.nPessoas.Name = "nPessoas";
            this.nPessoas.Size = new System.Drawing.Size(54, 20);
            this.nPessoas.TabIndex = 11;
            // 
            // FormHomeAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 457);
            this.Controls.Add(this.nPessoas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTodosPedidos);
            this.Controls.Add(this.lblMeusPedidos);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.dgvMeusPedidos);
            this.Controls.Add(this.txtMesa);
            this.Controls.Add(this.btnCriarPedido);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHomeAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home do Atendente";
            this.Load += new System.EventHandler(this.FormHomeAtendente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeusPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarPedido;
        private System.Windows.Forms.TextBox txtMesa;
        private System.Windows.Forms.DataGridView dgvMeusPedidos;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblMeusPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTodosPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nPessoas;
    }
}