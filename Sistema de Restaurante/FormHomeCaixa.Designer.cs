
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRegistroPedido = new System.Windows.Forms.DataGridView();
            this.lblMeusPedidos = new System.Windows.Forms.Label();
            this.dgvPedidosAbertos = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblPedido = new System.Windows.Forms.Label();
            this.btnDelivery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosAbertos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Registro do Pedido: ";
            // 
            // dgvRegistroPedido
            // 
            this.dgvRegistroPedido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRegistroPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroPedido.Location = new System.Drawing.Point(12, 221);
            this.dgvRegistroPedido.Name = "dgvRegistroPedido";
            this.dgvRegistroPedido.Size = new System.Drawing.Size(619, 150);
            this.dgvRegistroPedido.TabIndex = 12;
            // 
            // lblMeusPedidos
            // 
            this.lblMeusPedidos.AutoSize = true;
            this.lblMeusPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeusPedidos.Location = new System.Drawing.Point(167, 9);
            this.lblMeusPedidos.Name = "lblMeusPedidos";
            this.lblMeusPedidos.Size = new System.Drawing.Size(141, 20);
            this.lblMeusPedidos.TabIndex = 11;
            this.lblMeusPedidos.Text = "Pedidos Abertos";
            // 
            // dgvPedidosAbertos
            // 
            this.dgvPedidosAbertos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPedidosAbertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosAbertos.Location = new System.Drawing.Point(12, 32);
            this.dgvPedidosAbertos.Name = "dgvPedidosAbertos";
            this.dgvPedidosAbertos.Size = new System.Drawing.Size(619, 150);
            this.dgvPedidosAbertos.TabIndex = 9;
            this.dgvPedidosAbertos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidosAbertos_CellClick);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(647, 226);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(96, 36);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar Pedido";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(647, 284);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 36);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(452, 198);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(0, 20);
            this.lblPedido.TabIndex = 15;
            // 
            // btnDelivery
            // 
            this.btnDelivery.Location = new System.Drawing.Point(647, 32);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(96, 43);
            this.btnDelivery.TabIndex = 16;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            // 
            // FormHomeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRegistroPedido);
            this.Controls.Add(this.lblMeusPedidos);
            this.Controls.Add(this.dgvPedidosAbertos);
            this.Controls.Add(this.btnFechar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHomeCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home do Caixa";
            this.Load += new System.EventHandler(this.FormHomeCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosAbertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRegistroPedido;
        private System.Windows.Forms.Label lblMeusPedidos;
        private System.Windows.Forms.DataGridView dgvPedidosAbertos;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Button btnDelivery;
    }
}