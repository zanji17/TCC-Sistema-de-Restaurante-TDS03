
namespace Restaurante
{
    partial class sugestao
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblSusgenstao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSim = new Guna.UI2.WinForms.Guna2Button();
            this.btnNao = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // lblSusgenstao
            // 
            this.lblSusgenstao.AutoSize = false;
            this.lblSusgenstao.BackColor = System.Drawing.Color.Transparent;
            this.lblSusgenstao.Font = new System.Drawing.Font("Yu Gothic Light", 13.2F);
            this.lblSusgenstao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSusgenstao.Location = new System.Drawing.Point(16, 97);
            this.lblSusgenstao.Name = "lblSusgenstao";
            this.lblSusgenstao.Size = new System.Drawing.Size(373, 92);
            this.lblSusgenstao.TabIndex = 8;
            this.lblSusgenstao.TabStop = false;
            this.lblSusgenstao.Text = "..a sugestão..";
            this.lblSusgenstao.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(10, 298);
            this.guna2Panel1.TabIndex = 7;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.guna2PictureBox1.Image = global::Restaurante.Properties.Resources.depositphotos_380379218_stock_illustration_question_icon_vector_question_mark;
            this.guna2PictureBox1.Location = new System.Drawing.Point(138, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(123, 109);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnSim
            // 
            this.btnSim.Animated = true;
            this.btnSim.AutoRoundedCorners = true;
            this.btnSim.BorderRadius = 22;
            this.btnSim.CheckedState.Parent = this.btnSim;
            this.btnSim.CustomImages.Parent = this.btnSim;
            this.btnSim.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSim.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSim.ForeColor = System.Drawing.Color.White;
            this.btnSim.HoverState.Parent = this.btnSim;
            this.btnSim.Location = new System.Drawing.Point(223, 216);
            this.btnSim.Name = "btnSim";
            this.btnSim.ShadowDecoration.Parent = this.btnSim;
            this.btnSim.Size = new System.Drawing.Size(97, 46);
            this.btnSim.TabIndex = 9;
            this.btnSim.Text = "Sim";
            this.btnSim.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnNao
            // 
            this.btnNao.Animated = true;
            this.btnNao.AutoRoundedCorners = true;
            this.btnNao.BorderRadius = 22;
            this.btnNao.CheckedState.Parent = this.btnNao;
            this.btnNao.CustomImages.Parent = this.btnNao;
            this.btnNao.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNao.ForeColor = System.Drawing.Color.White;
            this.btnNao.HoverState.Parent = this.btnNao;
            this.btnNao.Location = new System.Drawing.Point(84, 216);
            this.btnNao.Name = "btnNao";
            this.btnNao.ShadowDecoration.Parent = this.btnNao;
            this.btnNao.Size = new System.Drawing.Size(97, 46);
            this.btnNao.TabIndex = 9;
            this.btnNao.Text = "Não";
            this.btnNao.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // sugestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 298);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblSusgenstao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sugestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sugestao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sugestao_FormClosing);
            this.Load += new System.EventHandler(this.sugestao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSusgenstao;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnSim;
        private Guna.UI2.WinForms.Guna2Button btnNao;
    }
}