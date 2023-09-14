namespace testeWeb
{
    partial class WebCam
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
            this.salvar = new System.Windows.Forms.Button();
            this.iniciar = new System.Windows.Forms.Button();
            this.encerrar = new System.Windows.Forms.Button();
            this.imagem = new System.Windows.Forms.PictureBox();
            this.camera = new System.Windows.Forms.ComboBox();
            this.recorte = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recorte)).BeginInit();
            this.SuspendLayout();
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(703, 413);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(219, 37);
            this.salvar.TabIndex = 0;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // iniciar
            // 
            this.iniciar.Location = new System.Drawing.Point(155, 449);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(219, 37);
            this.iniciar.TabIndex = 1;
            this.iniciar.Text = "Iniciar";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // encerrar
            // 
            this.encerrar.Location = new System.Drawing.Point(155, 504);
            this.encerrar.Name = "encerrar";
            this.encerrar.Size = new System.Drawing.Size(219, 37);
            this.encerrar.TabIndex = 2;
            this.encerrar.Text = "Encerrar";
            this.encerrar.UseVisualStyleBackColor = true;
            this.encerrar.Click += new System.EventHandler(this.encerrar_Click);
            // 
            // imagem
            // 
            this.imagem.Location = new System.Drawing.Point(32, 40);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(497, 312);
            this.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagem.TabIndex = 3;
            this.imagem.TabStop = false;
            // 
            // camera
            // 
            this.camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camera.FormattingEnabled = true;
            this.camera.Location = new System.Drawing.Point(145, 413);
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(243, 24);
            this.camera.TabIndex = 5;
            // 
            // recorte
            // 
            this.recorte.Location = new System.Drawing.Point(559, 40);
            this.recorte.Name = "recorte";
            this.recorte.Size = new System.Drawing.Size(497, 312);
            this.recorte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recorte.TabIndex = 6;
            this.recorte.TabStop = false;
            // 
            // WebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 578);
            this.Controls.Add(this.recorte);
            this.Controls.Add(this.camera);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.encerrar);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.salvar);
            this.Name = "WebCam";
            this.Text = "WebCam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebCam_FormClosing);
            this.Load += new System.EventHandler(this.WebCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recorte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Button encerrar;
        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.ComboBox camera;
        private System.Windows.Forms.PictureBox recorte;
    }
}

