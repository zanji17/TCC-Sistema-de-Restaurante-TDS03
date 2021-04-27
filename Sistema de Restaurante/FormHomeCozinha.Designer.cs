
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
            this.TextBoxAtendente = new System.Windows.Forms.TextBox();
            this.btnChamar = new System.Windows.Forms.Button();
            this.lblAtendente = new System.Windows.Forms.Label();
            this.dgvPratoConfirmado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratoConfirmado)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxAtendente
            // 
            this.TextBoxAtendente.Location = new System.Drawing.Point(422, 321);
            this.TextBoxAtendente.Name = "TextBoxAtendente";
            this.TextBoxAtendente.Size = new System.Drawing.Size(100, 20);
            this.TextBoxAtendente.TabIndex = 0;
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(528, 318);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(75, 23);
            this.btnChamar.TabIndex = 1;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            // 
            // lblAtendente
            // 
            this.lblAtendente.AutoSize = true;
            this.lblAtendente.Location = new System.Drawing.Point(360, 324);
            this.lblAtendente.Name = "lblAtendente";
            this.lblAtendente.Size = new System.Drawing.Size(56, 13);
            this.lblAtendente.TabIndex = 2;
            this.lblAtendente.Text = "Atendente";
            // 
            // dgvPratoConfirmado
            // 
            this.dgvPratoConfirmado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPratoConfirmado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPratoConfirmado.Location = new System.Drawing.Point(82, 32);
            this.dgvPratoConfirmado.Name = "dgvPratoConfirmado";
            this.dgvPratoConfirmado.Size = new System.Drawing.Size(832, 224);
            this.dgvPratoConfirmado.TabIndex = 3;
            // 
            // FormHomeCozinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 356);
            this.Controls.Add(this.dgvPratoConfirmado);
            this.Controls.Add(this.lblAtendente);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.TextBoxAtendente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHomeCozinha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home da Cozinha";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratoConfirmado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxAtendente;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.Label lblAtendente;
        private System.Windows.Forms.DataGridView dgvPratoConfirmado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesaDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quatidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adicionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retirarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAtendenteDataGridViewTextBoxColumn;
    }
}