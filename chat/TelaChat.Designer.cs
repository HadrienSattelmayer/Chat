namespace chat
{
    partial class TelaChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaChat));
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.botaoEnviar = new System.Windows.Forms.Button();
            this.tbConversa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tbTexto
            // 
            this.tbTexto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTexto.Location = new System.Drawing.Point(2, 402);
            this.tbTexto.MinimumSize = new System.Drawing.Size(380, 38);
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTexto.Size = new System.Drawing.Size(549, 38);
            this.tbTexto.TabIndex = 0;
            // 
            // botaoEnviar
            // 
            this.botaoEnviar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.botaoEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoEnviar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.botaoEnviar.FlatAppearance.BorderSize = 0;
            this.botaoEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEnviar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.botaoEnviar.Location = new System.Drawing.Point(548, 402);
            this.botaoEnviar.Name = "botaoEnviar";
            this.botaoEnviar.Size = new System.Drawing.Size(86, 38);
            this.botaoEnviar.TabIndex = 3;
            this.botaoEnviar.Text = "Enviar";
            this.botaoEnviar.UseVisualStyleBackColor = false;
            this.botaoEnviar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbConversa
            // 
            this.tbConversa.Location = new System.Drawing.Point(2, 86);
            this.tbConversa.MinimumSize = new System.Drawing.Size(630, 300);
            this.tbConversa.Name = "tbConversa";
            this.tbConversa.Size = new System.Drawing.Size(632, 300);
            this.tbConversa.TabIndex = 4;
            this.tbConversa.TextChanged += new System.EventHandler(this.tbConversa_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 88);
            this.panel1.TabIndex = 2;
            // 
            // TelaChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.tbConversa);
            this.Controls.Add(this.botaoEnviar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbTexto);
            this.Name = "TelaChat";
            this.Text = "TelaChat";
            this.Load += new System.EventHandler(this.TelaChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.Button botaoEnviar;
        private System.Windows.Forms.TextBox tbConversa;
        private System.Windows.Forms.Panel panel1;
    }
}