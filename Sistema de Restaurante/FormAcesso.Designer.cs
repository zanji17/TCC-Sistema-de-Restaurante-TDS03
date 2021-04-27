
namespace Restaurante
{
    partial class FormAcesso
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
            this.components = new System.ComponentModel.Container();
            this.TxtBoxLogin = new System.Windows.Forms.TextBox();
            this.BtnCadAcesso = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.dgvAcesso = new System.Windows.Forms.DataGridView();
            this.acessosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnEditarAcesso = new System.Windows.Forms.Button();
            this.BtnCadDeletar = new System.Windows.Forms.Button();
            this.BtnCadSair = new System.Windows.Forms.Button();
            this.TxtBoxCargo = new System.Windows.Forms.TextBox();
            this.TxtBoxSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBoxLogin
            // 
            this.TxtBoxLogin.Location = new System.Drawing.Point(68, 70);
            this.TxtBoxLogin.Name = "TxtBoxLogin";
            this.TxtBoxLogin.Size = new System.Drawing.Size(199, 20);
            this.TxtBoxLogin.TabIndex = 0;
            // 
            // BtnCadAcesso
            // 
            this.BtnCadAcesso.Location = new System.Drawing.Point(12, 216);
            this.BtnCadAcesso.Name = "BtnCadAcesso";
            this.BtnCadAcesso.Size = new System.Drawing.Size(64, 23);
            this.BtnCadAcesso.TabIndex = 1;
            this.BtnCadAcesso.Text = "Cadastrar";
            this.BtnCadAcesso.UseVisualStyleBackColor = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(17, 73);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // dgvAcesso
            // 
            this.dgvAcesso.AutoGenerateColumns = false;
            this.dgvAcesso.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAcesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcesso.DataSource = this.acessosBindingSource;
            this.dgvAcesso.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvAcesso.Location = new System.Drawing.Point(357, 43);
            this.dgvAcesso.Name = "dgvAcesso";
            this.dgvAcesso.Size = new System.Drawing.Size(441, 175);
            this.dgvAcesso.TabIndex = 3;
            // 
            // acessosBindingSource
            // 
            this.acessosBindingSource.DataMember = "Acessos";
            // 
            // BtnEditarAcesso
            // 
            this.BtnEditarAcesso.Location = new System.Drawing.Point(94, 216);
            this.BtnEditarAcesso.Name = "BtnEditarAcesso";
            this.BtnEditarAcesso.Size = new System.Drawing.Size(64, 23);
            this.BtnEditarAcesso.TabIndex = 4;
            this.BtnEditarAcesso.Text = "Editar";
            this.BtnEditarAcesso.UseVisualStyleBackColor = true;
            // 
            // BtnCadDeletar
            // 
            this.BtnCadDeletar.Location = new System.Drawing.Point(176, 216);
            this.BtnCadDeletar.Name = "BtnCadDeletar";
            this.BtnCadDeletar.Size = new System.Drawing.Size(64, 23);
            this.BtnCadDeletar.TabIndex = 5;
            this.BtnCadDeletar.Text = "Deletar";
            this.BtnCadDeletar.UseVisualStyleBackColor = true;
            // 
            // BtnCadSair
            // 
            this.BtnCadSair.Location = new System.Drawing.Point(258, 216);
            this.BtnCadSair.Name = "BtnCadSair";
            this.BtnCadSair.Size = new System.Drawing.Size(64, 23);
            this.BtnCadSair.TabIndex = 6;
            this.BtnCadSair.Text = "Sair";
            this.BtnCadSair.UseVisualStyleBackColor = true;
            this.BtnCadSair.Click += new System.EventHandler(this.BtnCadSair_Click);
            // 
            // TxtBoxCargo
            // 
            this.TxtBoxCargo.Location = new System.Drawing.Point(68, 145);
            this.TxtBoxCargo.Name = "TxtBoxCargo";
            this.TxtBoxCargo.Size = new System.Drawing.Size(199, 20);
            this.TxtBoxCargo.TabIndex = 7;
            // 
            // TxtBoxSenha
            // 
            this.TxtBoxSenha.Location = new System.Drawing.Point(68, 105);
            this.TxtBoxSenha.Name = "TxtBoxSenha";
            this.TxtBoxSenha.Size = new System.Drawing.Size(199, 20);
            this.TxtBoxSenha.TabIndex = 8;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(17, 112);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(17, 152);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 10;
            this.lblCargo.Text = "Cargo";
            // 
            // FormAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 279);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.TxtBoxSenha);
            this.Controls.Add(this.TxtBoxCargo);
            this.Controls.Add(this.BtnCadSair);
            this.Controls.Add(this.BtnCadDeletar);
            this.Controls.Add(this.BtnEditarAcesso);
            this.Controls.Add(this.dgvAcesso);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.BtnCadAcesso);
            this.Controls.Add(this.TxtBoxLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Acesso";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxLogin;
        private System.Windows.Forms.Button BtnCadAcesso;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.DataGridView dgvAcesso;
        private System.Windows.Forms.BindingSource acessosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idacessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnEditarAcesso;
        private System.Windows.Forms.Button BtnCadDeletar;
        private System.Windows.Forms.Button BtnCadSair;
        private System.Windows.Forms.TextBox TxtBoxCargo;
        private System.Windows.Forms.TextBox TxtBoxSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCargo;
    }
}