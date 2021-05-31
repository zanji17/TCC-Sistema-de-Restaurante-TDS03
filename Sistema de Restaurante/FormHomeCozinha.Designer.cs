
namespace Restaurante
{
    partial class FormHomeCozinha
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
            this.dgvPratoConfirmado = new System.Windows.Forms.DataGridView();
            this.dgvPC = new System.Windows.Forms.DataGridView();
            this.dgvPR = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clbPR = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratoConfirmado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPR)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPratoConfirmado
            // 
            this.dgvPratoConfirmado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPratoConfirmado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPratoConfirmado.Location = new System.Drawing.Point(12, 34);
            this.dgvPratoConfirmado.Name = "dgvPratoConfirmado";
            this.dgvPratoConfirmado.Size = new System.Drawing.Size(1035, 97);
            this.dgvPratoConfirmado.TabIndex = 3;
            // 
            // dgvPC
            // 
            this.dgvPC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPC.Location = new System.Drawing.Point(12, 341);
            this.dgvPC.Name = "dgvPC";
            this.dgvPC.Size = new System.Drawing.Size(1035, 74);
            this.dgvPC.TabIndex = 4;
            // 
            // dgvPR
            // 
            this.dgvPR.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPR.Location = new System.Drawing.Point(12, 179);
            this.dgvPR.Name = "dgvPR";
            this.dgvPR.Size = new System.Drawing.Size(1035, 103);
            this.dgvPR.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pratos Rápidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pratos Cancelados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pratos Confirmados";
            // 
            // clbPR
            // 
            this.clbPR.FormattingEnabled = true;
            this.clbPR.Location = new System.Drawing.Point(1087, 98);
            this.clbPR.Name = "clbPR";
            this.clbPR.Size = new System.Drawing.Size(120, 184);
            this.clbPR.TabIndex = 10;
            this.clbPR.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbPR_ItemCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1073, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "Selecione os Tipos \r\nde Pratos Rápidos";
            // 
            // FormHomeCozinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 427);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clbPR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPR);
            this.Controls.Add(this.dgvPC);
            this.Controls.Add(this.dgvPratoConfirmado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHomeCozinha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home da Cozinha";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratoConfirmado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPratoConfirmado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesaDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quatidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adicionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retirarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAtendenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvPC;
        private System.Windows.Forms.DataGridView dgvPR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbPR;
        private System.Windows.Forms.Label label4;
    }
}