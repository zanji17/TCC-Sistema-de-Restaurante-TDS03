
namespace Restaurante
{
    partial class FormPratosProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.clbCategoria = new System.Windows.Forms.CheckedListBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.dgvPratosProdutos = new System.Windows.Forms.DataGridView();
            this.clbIngredientes = new System.Windows.Forms.CheckedListBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.clbAdicional = new System.Windows.Forms.CheckedListBox();
            this.lbAdicional = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clbRetirar = new System.Windows.Forms.CheckedListBox();
            this.lblRetiravel = new System.Windows.Forms.Label();
            this.chkCozinha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratosProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(289, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // clbCategoria
            // 
            this.clbCategoria.CheckOnClick = true;
            this.clbCategoria.FormattingEnabled = true;
            this.clbCategoria.Location = new System.Drawing.Point(12, 134);
            this.clbCategoria.Name = "clbCategoria";
            this.clbCategoria.Size = new System.Drawing.Size(115, 79);
            this.clbCategoria.TabIndex = 2;
            this.clbCategoria.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbCategoria_ItemCheck);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 38);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTipo.Location = new System.Drawing.Point(53, 35);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(289, 20);
            this.txtTipo.TabIndex = 3;
            this.txtTipo.Enter += new System.EventHandler(this.txtTipo_Enter);
            // 
            // dgvPratosProdutos
            // 
            this.dgvPratosProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPratosProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPratosProdutos.Location = new System.Drawing.Point(348, 9);
            this.dgvPratosProdutos.Name = "dgvPratosProdutos";
            this.dgvPratosProdutos.Size = new System.Drawing.Size(440, 425);
            this.dgvPratosProdutos.TabIndex = 5;
            this.dgvPratosProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPratosProdutos_CellClick);
            // 
            // clbIngredientes
            // 
            this.clbIngredientes.FormattingEnabled = true;
            this.clbIngredientes.Location = new System.Drawing.Point(12, 239);
            this.clbIngredientes.Name = "clbIngredientes";
            this.clbIngredientes.Size = new System.Drawing.Size(115, 79);
            this.clbIngredientes.TabIndex = 8;
            this.clbIngredientes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbIngredientes_ItemCheck);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(267, 118);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(75, 23);
            this.btnCad.TabIndex = 10;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(267, 176);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(267, 205);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Apagar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(267, 234);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(9, 118);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(32, 13);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Tipo";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.Location = new System.Drawing.Point(12, 223);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(77, 13);
            this.lblIngredientes.TabIndex = 15;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(267, 147);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // clbAdicional
            // 
            this.clbAdicional.FormattingEnabled = true;
            this.clbAdicional.Location = new System.Drawing.Point(12, 376);
            this.clbAdicional.Name = "clbAdicional";
            this.clbAdicional.Size = new System.Drawing.Size(115, 79);
            this.clbAdicional.TabIndex = 17;
            this.clbAdicional.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbAdicional_ItemCheck);
            // 
            // lbAdicional
            // 
            this.lbAdicional.FormattingEnabled = true;
            this.lbAdicional.Location = new System.Drawing.Point(133, 376);
            this.lbAdicional.Name = "lbAdicional";
            this.lbAdicional.Size = new System.Drawing.Size(128, 82);
            this.lbAdicional.TabIndex = 18;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 93);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Ingredientes do Prato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Opções de Adicionais do Prato";
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(104, 349);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(157, 21);
            this.cbModelo.TabIndex = 20;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Modelo Pronto";
            // 
            // clbRetirar
            // 
            this.clbRetirar.FormattingEnabled = true;
            this.clbRetirar.Location = new System.Drawing.Point(146, 134);
            this.clbRetirar.Name = "clbRetirar";
            this.clbRetirar.Size = new System.Drawing.Size(115, 184);
            this.clbRetirar.TabIndex = 22;
            // 
            // lblRetiravel
            // 
            this.lblRetiravel.AutoSize = true;
            this.lblRetiravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiravel.Location = new System.Drawing.Point(143, 118);
            this.lblRetiravel.Name = "lblRetiravel";
            this.lblRetiravel.Size = new System.Drawing.Size(58, 13);
            this.lblRetiravel.TabIndex = 23;
            this.lblRetiravel.Text = "Retirável";
            // 
            // chkCozinha
            // 
            this.chkCozinha.AutoSize = true;
            this.chkCozinha.Location = new System.Drawing.Point(53, 61);
            this.chkCozinha.Name = "chkCozinha";
            this.chkCozinha.Size = new System.Drawing.Size(130, 17);
            this.chkCozinha.TabIndex = 25;
            this.chkCozinha.Text = "Será Feito na Cozinha";
            this.chkCozinha.UseVisualStyleBackColor = true;
            // 
            // FormPratosProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.chkCozinha);
            this.Controls.Add(this.lblRetiravel);
            this.Controls.Add(this.clbRetirar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAdicional);
            this.Controls.Add(this.clbAdicional);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.clbIngredientes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvPratosProdutos);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.clbCategoria);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPratosProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pratos/Produtos";
            this.Load += new System.EventHandler(this.FormPratosProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratosProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.CheckedListBox clbCategoria;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.DataGridView dgvPratosProdutos;
        private System.Windows.Forms.CheckedListBox clbIngredientes;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.CheckedListBox clbAdicional;
        private System.Windows.Forms.ListBox lbAdicional;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbRetirar;
        private System.Windows.Forms.Label lblRetiravel;
        private System.Windows.Forms.CheckBox chkCozinha;
    }
}

