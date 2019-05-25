namespace aula1 {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Design = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Design
            // 
            this.Design.AutoSize = true;
            this.Design.Location = new System.Drawing.Point(28, 34);
            this.Design.Name = "Design";
            this.Design.Size = new System.Drawing.Size(83, 13);
            this.Design.TabIndex = 0;
            this.Design.Text = "Digite seu nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(29, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(227, 20);
            this.txtNome.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Design);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hello World ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Design;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
    }
}

