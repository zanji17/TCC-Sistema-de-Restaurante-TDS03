
namespace Restaurante
{
    partial class FormRegistroPedido
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
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.lblMesaDelivery = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelarTodos = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblmesa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.btnServido = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(12, 99);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.Size = new System.Drawing.Size(654, 280);
            this.dgvRegistro.TabIndex = 0;
            // 
            // lblMesaDelivery
            // 
            this.lblMesaDelivery.AutoSize = true;
            this.lblMesaDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaDelivery.Location = new System.Drawing.Point(369, 10);
            this.lblMesaDelivery.Name = "lblMesaDelivery";
            this.lblMesaDelivery.Size = new System.Drawing.Size(91, 29);
            this.lblMesaDelivery.TabIndex = 1;
            this.lblMesaDelivery.Text = "mesa #";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(686, 99);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 32);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar Prato";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(686, 137);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(102, 32);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(686, 229);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 32);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarTodos
            // 
            this.btnCancelarTodos.Location = new System.Drawing.Point(686, 343);
            this.btnCancelarTodos.Name = "btnCancelarTodos";
            this.btnCancelarTodos.Size = new System.Drawing.Size(102, 32);
            this.btnCancelarTodos.TabIndex = 6;
            this.btnCancelarTodos.Text = "Cancelar Todos";
            this.btnCancelarTodos.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(686, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(369, 50);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(84, 29);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "cliente";
            // 
            // lblmesa
            // 
            this.lblmesa.AutoSize = true;
            this.lblmesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmesa.Location = new System.Drawing.Point(208, 13);
            this.lblmesa.Name = "lblmesa";
            this.lblmesa.Size = new System.Drawing.Size(155, 25);
            this.lblmesa.TabIndex = 8;
            this.lblmesa.Text = "Mesa/Delivery:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cliente:";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(45, 13);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(110, 29);
            this.lblPedido.TabIndex = 10;
            this.lblPedido.Text = "Pedido #";
            // 
            // btnServido
            // 
            this.btnServido.Location = new System.Drawing.Point(686, 175);
            this.btnServido.Name = "btnServido";
            this.btnServido.Size = new System.Drawing.Size(102, 32);
            this.btnServido.TabIndex = 11;
            this.btnServido.Text = "Servido";
            this.btnServido.UseVisualStyleBackColor = true;
            this.btnServido.Click += new System.EventHandler(this.btnServido_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(686, 267);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 32);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Apagar";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // FormRegistroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnServido);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmesa);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnCancelarTodos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblMesaDelivery);
            this.Controls.Add(this.dgvRegistro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistroPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Pedido";
            this.Load += new System.EventHandler(this.FormRegistroPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.Label lblMesaDelivery;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelarTodos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblmesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Button btnServido;
        private System.Windows.Forms.Button btnDel;
    }
}