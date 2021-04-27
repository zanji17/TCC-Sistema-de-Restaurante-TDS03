
namespace Restaurante
{
    partial class FormAtendente
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
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvAtend = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpfCadAtend = new System.Windows.Forms.Label();
            this.lbLoginCadAtend = new System.Windows.Forms.Label();
            this.lblSenhaCadAntend = new System.Windows.Forms.Label();
            this.lblNomeCadAtend = new System.Windows.Forms.Label();
            this.btnSairCadAtend = new System.Windows.Forms.Button();
            this.btnCadAtend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtend)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(111, 35);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 20);
            this.btnLocalizar.TabIndex = 27;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(22, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(75, 20);
            this.txtId.TabIndex = 11;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(19, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "ID";
            // 
            // dgvAtend
            // 
            this.dgvAtend.AccessibleName = "";
            this.dgvAtend.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAtend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtend.Location = new System.Drawing.Point(192, 35);
            this.dgvAtend.Name = "dgvAtend";
            this.dgvAtend.Size = new System.Drawing.Size(407, 238);
            this.dgvAtend.TabIndex = 24;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(103, 289);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 21;
            this.btnAtualizar.Text = "Atualizar ";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(182, 289);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 23;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(22, 194);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(161, 20);
            this.txtLogin.TabIndex = 18;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(25, 253);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(158, 20);
            this.txtSenha.TabIndex = 19;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(22, 141);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(161, 20);
            this.txtCpf.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(161, 20);
            this.txtNome.TabIndex = 12;
            // 
            // lblCpfCadAtend
            // 
            this.lblCpfCadAtend.AutoSize = true;
            this.lblCpfCadAtend.Location = new System.Drawing.Point(22, 124);
            this.lblCpfCadAtend.Name = "lblCpfCadAtend";
            this.lblCpfCadAtend.Size = new System.Drawing.Size(27, 13);
            this.lblCpfCadAtend.TabIndex = 17;
            this.lblCpfCadAtend.Text = "CPF";
            // 
            // lbLoginCadAtend
            // 
            this.lbLoginCadAtend.AutoSize = true;
            this.lbLoginCadAtend.Location = new System.Drawing.Point(19, 177);
            this.lbLoginCadAtend.Name = "lbLoginCadAtend";
            this.lbLoginCadAtend.Size = new System.Drawing.Size(33, 13);
            this.lbLoginCadAtend.TabIndex = 16;
            this.lbLoginCadAtend.Text = "Login";
            // 
            // lblSenhaCadAntend
            // 
            this.lblSenhaCadAntend.AutoSize = true;
            this.lblSenhaCadAntend.Location = new System.Drawing.Point(22, 236);
            this.lblSenhaCadAntend.Name = "lblSenhaCadAntend";
            this.lblSenhaCadAntend.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaCadAntend.TabIndex = 15;
            this.lblSenhaCadAntend.Text = "Senha";
            // 
            // lblNomeCadAtend
            // 
            this.lblNomeCadAtend.AutoSize = true;
            this.lblNomeCadAtend.Location = new System.Drawing.Point(19, 74);
            this.lblNomeCadAtend.Name = "lblNomeCadAtend";
            this.lblNomeCadAtend.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCadAtend.TabIndex = 14;
            this.lblNomeCadAtend.Text = "Nome ";
            // 
            // btnSairCadAtend
            // 
            this.btnSairCadAtend.Location = new System.Drawing.Point(262, 289);
            this.btnSairCadAtend.Name = "btnSairCadAtend";
            this.btnSairCadAtend.Size = new System.Drawing.Size(75, 23);
            this.btnSairCadAtend.TabIndex = 26;
            this.btnSairCadAtend.Text = "Sair";
            this.btnSairCadAtend.UseVisualStyleBackColor = true;
            // 
            // btnCadAtend
            // 
            this.btnCadAtend.Location = new System.Drawing.Point(22, 289);
            this.btnCadAtend.Name = "btnCadAtend";
            this.btnCadAtend.Size = new System.Drawing.Size(75, 23);
            this.btnCadAtend.TabIndex = 20;
            this.btnCadAtend.Text = "Cadastrar";
            this.btnCadAtend.UseVisualStyleBackColor = true;
            // 
            // FormAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 344);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvAtend);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCpfCadAtend);
            this.Controls.Add(this.lbLoginCadAtend);
            this.Controls.Add(this.lblSenhaCadAntend);
            this.Controls.Add(this.lblNomeCadAtend);
            this.Controls.Add(this.btnSairCadAtend);
            this.Controls.Add(this.btnCadAtend);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendentes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvAtend;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCpfCadAtend;
        private System.Windows.Forms.Label lbLoginCadAtend;
        private System.Windows.Forms.Label lblSenhaCadAntend;
        private System.Windows.Forms.Label lblNomeCadAtend;
        private System.Windows.Forms.Button btnSairCadAtend;
        private System.Windows.Forms.Button btnCadAtend;
    }
}