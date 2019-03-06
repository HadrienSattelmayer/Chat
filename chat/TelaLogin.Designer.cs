namespace chat
{
    partial class TelaLogin
    {
       
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.labelNaoCadastrado = new System.Windows.Forms.Label();
            this.labelImagemLogo = new System.Windows.Forms.Label();
            this.painelLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoEntrar = new System.Windows.Forms.Button();
            this.painelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSenha
            // 
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbSenha, "tbSenha");
            this.tbSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tbLogin, "tbLogin");
            this.tbLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelNaoCadastrado
            // 
            resources.ApplyResources(this.labelNaoCadastrado, "labelNaoCadastrado");
            this.labelNaoCadastrado.BackColor = System.Drawing.Color.Transparent;
            this.labelNaoCadastrado.ForeColor = System.Drawing.Color.White;
            this.labelNaoCadastrado.Name = "labelNaoCadastrado";
            this.labelNaoCadastrado.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelImagemLogo
            // 
            resources.ApplyResources(this.labelImagemLogo, "labelImagemLogo");
            this.labelImagemLogo.BackColor = System.Drawing.Color.Transparent;
            this.labelImagemLogo.Name = "labelImagemLogo";
            this.labelImagemLogo.Click += new System.EventHandler(this.label4_Click);
            // 
            // painelLogin
            // 
            this.painelLogin.BackColor = System.Drawing.SystemColors.GrayText;
            this.painelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelLogin.Controls.Add(this.label2);
            this.painelLogin.Controls.Add(this.label1);
            this.painelLogin.Controls.Add(this.botaoEntrar);
            this.painelLogin.Controls.Add(this.labelNaoCadastrado);
            this.painelLogin.Controls.Add(this.labelImagemLogo);
            this.painelLogin.Controls.Add(this.tbSenha);
            this.painelLogin.Controls.Add(this.tbLogin);
            resources.ApplyResources(this.painelLogin, "painelLogin");
            this.painelLogin.Name = "painelLogin";
            this.painelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.painelLogin_Paint);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // botaoEntrar
            // 
            this.botaoEntrar.BackColor = System.Drawing.Color.Gray;
            this.botaoEntrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.botaoEntrar.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.botaoEntrar, "botaoEntrar");
            this.botaoEntrar.ForeColor = System.Drawing.Color.White;
            this.botaoEntrar.Name = "botaoEntrar";
            this.botaoEntrar.UseVisualStyleBackColor = false;
            this.botaoEntrar.Click += new System.EventHandler(this.botaoEntrar_Click);
            // 
            // TelaLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.painelLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaLogin_FormClosing);
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.painelLogin.ResumeLayout(false);
            this.painelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label labelNaoCadastrado;
        private System.Windows.Forms.Label labelImagemLogo;
        private System.Windows.Forms.Panel painelLogin;
        private System.Windows.Forms.Button botaoEntrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

