
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvMeusPedidos = new System.Windows.Forms.DataGridView();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblMeusPedidos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTodosPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeusPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarPedido
            // 
            this.btnCriarPedido.Location = new System.Drawing.Point(464, 25);
            this.btnCriarPedido.Name = "btnCriarPedido";
            this.btnCriarPedido.Size = new System.Drawing.Size(88, 30);
            this.btnCriarPedido.TabIndex = 0;
            this.btnCriarPedido.Text = "Criar Pedido";
            this.btnCriarPedido.UseVisualStyleBackColor = true;
            this.btnCriarPedido.Click += new System.EventHandler(this.btnCriarPedido_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dgvMeusPedidos
            // 
            this.dgvMeusPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMeusPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeusPedidos.Location = new System.Drawing.Point(147, 88);
            this.dgvMeusPedidos.Name = "dgvMeusPedidos";
            this.dgvMeusPedidos.Size = new System.Drawing.Size(345, 150);
            this.dgvMeusPedidos.TabIndex = 2;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(121, 34);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(76, 13);
            this.lblMesa.TabIndex = 3;
            this.lblMesa.Text = "Mesa/Delivery";
            // 
            // lblMeusPedidos
            // 
            this.lblMeusPedidos.AutoSize = true;
            this.lblMeusPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeusPedidos.Location = new System.Drawing.Point(262, 65);
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
            this.dgvTodosPedidos.Location = new System.Drawing.Point(107, 275);
            this.dgvTodosPedidos.Name = "dgvTodosPedidos";
            this.dgvTodosPedidos.Size = new System.Drawing.Size(445, 150);
            this.dgvTodosPedidos.TabIndex = 5;
            // 
            // FormHomeAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTodosPedidos);
            this.Controls.Add(this.lblMeusPedidos);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.dgvMeusPedidos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCriarPedido);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHomeAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home do Atendente";
            this.Load += new System.EventHandler(this.FormHomeAtendente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeusPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarPedido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvMeusPedidos;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblMeusPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTodosPedidos;
    }
}