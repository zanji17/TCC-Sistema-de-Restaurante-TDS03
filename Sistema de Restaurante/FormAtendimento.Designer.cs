
namespace Restaurante
{
    partial class FormAtendimento
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
            this.dgvAtendentes = new System.Windows.Forms.DataGridView();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAtendentes
            // 
            this.dgvAtendentes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAtendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendentes.Location = new System.Drawing.Point(12, 73);
            this.dgvAtendentes.Name = "dgvAtendentes";
            this.dgvAtendentes.Size = new System.Drawing.Size(658, 180);
            this.dgvAtendentes.TabIndex = 0;
            this.dgvAtendentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtendentes_CellClick);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 259);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(658, 174);
            this.dgvPedidos.TabIndex = 1;
            this.dgvPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 27, 13, 50, 15, 0);
            // 
            // FormAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 445);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.dgvAtendentes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Atendimento";
            this.Load += new System.EventHandler(this.FormAtendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAtendentes;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}