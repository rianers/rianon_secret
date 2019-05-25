namespace WindowsFormsApp5 {
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
            this.b = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnConferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(246, 71);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(187, 31);
            this.b.TabIndex = 0;
            this.b.Text = "Informe sua idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(281, 126);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 1;
            // 
            // btnConferir
            // 
            this.btnConferir.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferir.Location = new System.Drawing.Point(252, 192);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(153, 44);
            this.btnConferir.TabIndex = 2;
            this.btnConferir.Text = "Conferir";
            this.btnConferir.UseVisualStyleBackColor = true;
            this.btnConferir.Click += new System.EventHandler(this.btnConferir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConferir);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.b);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnConferir;
    }
}

