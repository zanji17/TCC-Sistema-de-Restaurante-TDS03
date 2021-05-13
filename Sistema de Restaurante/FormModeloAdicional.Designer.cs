
namespace Restaurante
{
    partial class FormModeloAdicional
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
            this.clbAdicionais = new System.Windows.Forms.CheckedListBox();
            this.lbAdicionais = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // clbAdicionais
            // 
            this.clbAdicionais.FormattingEnabled = true;
            this.clbAdicionais.Location = new System.Drawing.Point(12, 53);
            this.clbAdicionais.Name = "clbAdicionais";
            this.clbAdicionais.Size = new System.Drawing.Size(138, 229);
            this.clbAdicionais.TabIndex = 0;
            this.clbAdicionais.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbAdicionais_ItemCheck);
            // 
            // lbAdicionais
            // 
            this.lbAdicionais.FormattingEnabled = true;
            this.lbAdicionais.Location = new System.Drawing.Point(175, 53);
            this.lbAdicionais.Name = "lbAdicionais";
            this.lbAdicionais.Size = new System.Drawing.Size(149, 238);
            this.lbAdicionais.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Modelo";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(347, 12);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Criar";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // dgvModelos
            // 
            this.dgvModelos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelos.Location = new System.Drawing.Point(447, 12);
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.Size = new System.Drawing.Size(455, 277);
            this.dgvModelos.TabIndex = 5;
            this.dgvModelos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModelos_CellClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(347, 104);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(347, 150);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Apagar";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(347, 58);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(347, 196);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // FormModeloAdicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 307);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvModelos);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbAdicionais);
            this.Controls.Add(this.clbAdicionais);
            this.Name = "FormModeloAdicional";
            this.Text = "Modelo de Adicional";
            this.Load += new System.EventHandler(this.FormModeloAdicional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbAdicionais;
        private System.Windows.Forms.ListBox lbAdicionais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}