namespace WindowsFormsApp4 {
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
            this.txtN1 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.Label();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.AutoSize = true;
            this.txtN1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(39, 33);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(151, 25);
            this.txtN1.TabIndex = 0;
            this.txtN1.Text = "Digite um número";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(225, 38);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(162, 20);
            this.txtbox1.TabIndex = 1;
            // 
            // txtN2
            // 
            this.txtN2.AutoSize = true;
            this.txtN2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(39, 106);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(151, 25);
            this.txtN2.TabIndex = 2;
            this.txtN2.Text = "Digite um número";
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(225, 111);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(162, 20);
            this.txtbox2.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Maroon;
            this.btn1.Location = new System.Drawing.Point(44, 198);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(343, 35);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "CALCULAR";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.txtN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtN1;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Label txtN2;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Button btn1;
    }
}

