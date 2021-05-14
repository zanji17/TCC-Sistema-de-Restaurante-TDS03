
namespace Restaurante
{
    partial class FormIngrediente
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
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.dgvIngred = new System.Windows.Forms.DataGridView();
            this.ckAdicional = new System.Windows.Forms.CheckBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngred)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(313, 137);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(73, 23);
            this.btnDel.TabIndex = 26;
            this.btnDel.Text = "Apagar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(313, 98);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 23);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Detalhes";
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.Location = new System.Drawing.Point(68, 137);
            this.txtDetalhes.Multiline = true;
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(218, 66);
            this.txtDetalhes.TabIndex = 23;
            // 
            // dgvIngred
            // 
            this.dgvIngred.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvIngred.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngred.Location = new System.Drawing.Point(392, 12);
            this.dgvIngred.Name = "dgvIngred";
            this.dgvIngred.Size = new System.Drawing.Size(396, 191);
            this.dgvIngred.TabIndex = 22;
            this.dgvIngred.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngred_CellClick);
            // 
            // ckAdicional
            // 
            this.ckAdicional.AutoSize = true;
            this.ckAdicional.Location = new System.Drawing.Point(67, 104);
            this.ckAdicional.Name = "ckAdicional";
            this.ckAdicional.Size = new System.Drawing.Size(69, 17);
            this.ckAdicional.TabIndex = 21;
            this.ckAdicional.Text = "Adicional";
            this.ckAdicional.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(11, 62);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 19;
            this.lblTipo.Text = "Tipo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(218, 20);
            this.txtNome.TabIndex = 18;
            // 
            // txtTipo
            // 
            this.txtTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTipo.Location = new System.Drawing.Point(67, 62);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(219, 20);
            this.txtTipo.TabIndex = 17;
            this.txtTipo.Enter += new System.EventHandler(this.txtTipo_Enter);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(313, 12);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(73, 23);
            this.btnCad.TabIndex = 16;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(313, 180);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(73, 23);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(313, 57);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(73, 23);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 219);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetalhes);
            this.Controls.Add(this.dgvIngred);
            this.Controls.Add(this.ckAdicional);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.btnSair);
            this.Name = "FormIngrediente";
            this.Text = "Ingredientes";
            this.Load += new System.EventHandler(this.FormIngrediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.DataGridView dgvIngred;
        private System.Windows.Forms.CheckBox ckAdicional;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}