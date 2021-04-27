
namespace Restaurante
{
    partial class FormRelatorioPedidos
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnVerDetalhes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(38, 12);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(637, 266);
            this.dgvPedidos.TabIndex = 0;
            // 
            // btnVerDetalhes
            // 
            this.btnVerDetalhes.ForeColor = System.Drawing.Color.Black;
            this.btnVerDetalhes.Location = new System.Drawing.Point(284, 298);
            this.btnVerDetalhes.Name = "btnVerDetalhes";
            this.btnVerDetalhes.Size = new System.Drawing.Size(160, 31);
            this.btnVerDetalhes.TabIndex = 1;
            this.btnVerDetalhes.Text = "Ver Detalhes";
            this.btnVerDetalhes.UseVisualStyleBackColor = true;
            this.btnVerDetalhes.Click += new System.EventHandler(this.btnVerDetalhes_Click);
            // 
            // FormRelatorioPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 351);
            this.Controls.Add(this.btnVerDetalhes);
            this.Controls.Add(this.dgvPedidos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelatorioPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Pedidos";
            this.Load += new System.EventHandler(this.FormRelatorioPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnVerDetalhes;
    }
}