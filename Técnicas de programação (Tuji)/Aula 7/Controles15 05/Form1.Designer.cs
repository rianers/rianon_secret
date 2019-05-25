namespace Controles15_05
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbNaoInformado = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConferir = new System.Windows.Forms.Button();
            this.TxtIdade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.cbSelvagem = new System.Windows.Forms.CheckBox();
            this.cbCaipirinha = new System.Windows.Forms.CheckBox();
            this.cbCerveja = new System.Windows.Forms.CheckBox();
            this.cbMusica = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(111, 36);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(279, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(111, 135);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(92, 22);
            this.rbMasculino.TabIndex = 2;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFeminino.Location = new System.Drawing.Point(221, 135);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(87, 22);
            this.rbFeminino.TabIndex = 3;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbNaoInformado
            // 
            this.rbNaoInformado.AutoSize = true;
            this.rbNaoInformado.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoInformado.Location = new System.Drawing.Point(329, 135);
            this.rbNaoInformado.Name = "rbNaoInformado";
            this.rbNaoInformado.Size = new System.Drawing.Size(125, 22);
            this.rbNaoInformado.TabIndex = 4;
            this.rbNaoInformado.TabStop = true;
            this.rbNaoInformado.Text = "Não Informado";
            this.rbNaoInformado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Idade:";
            // 
            // btnConferir
            // 
            this.btnConferir.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferir.Location = new System.Drawing.Point(368, 442);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(203, 66);
            this.btnConferir.TabIndex = 6;
            this.btnConferir.Text = "Conferir";
            this.btnConferir.UseVisualStyleBackColor = true;
            this.btnConferir.Click += new System.EventHandler(this.btnConferir_Click);
            // 
            // TxtIdade
            // 
            this.TxtIdade.Location = new System.Drawing.Point(111, 85);
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(89, 20);
            this.TxtIdade.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gênero:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.cbSelvagem);
            this.groupBox1.Controls.Add(this.cbCaipirinha);
            this.groupBox1.Controls.Add(this.cbCerveja);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 85);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preferências";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(497, 47);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(144, 26);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Refrigerante";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // cbSelvagem
            // 
            this.cbSelvagem.AutoSize = true;
            this.cbSelvagem.Location = new System.Drawing.Point(330, 47);
            this.cbSelvagem.Name = "cbSelvagem";
            this.cbSelvagem.Size = new System.Drawing.Size(119, 26);
            this.cbSelvagem.TabIndex = 2;
            this.cbSelvagem.Text = "Selvagem";
            this.cbSelvagem.UseVisualStyleBackColor = true;
            // 
            // cbCaipirinha
            // 
            this.cbCaipirinha.AutoSize = true;
            this.cbCaipirinha.Location = new System.Drawing.Point(170, 47);
            this.cbCaipirinha.Name = "cbCaipirinha";
            this.cbCaipirinha.Size = new System.Drawing.Size(122, 26);
            this.cbCaipirinha.TabIndex = 1;
            this.cbCaipirinha.Text = "Caipirinha";
            this.cbCaipirinha.UseVisualStyleBackColor = true;
            // 
            // cbCerveja
            // 
            this.cbCerveja.AutoSize = true;
            this.cbCerveja.Location = new System.Drawing.Point(22, 47);
            this.cbCerveja.Name = "cbCerveja";
            this.cbCerveja.Size = new System.Drawing.Size(99, 26);
            this.cbCerveja.TabIndex = 0;
            this.cbCerveja.Text = "Cerveja";
            this.cbCerveja.UseVisualStyleBackColor = true;
            // 
            // cbMusica
            // 
            this.cbMusica.FormattingEnabled = true;
            this.cbMusica.Items.AddRange(new object[] {
            "Selecione...",
            "Sertanejo",
            "Funk",
            "Pagode",
            "Rock",
            "Eletrônica"});
            this.cbMusica.Location = new System.Drawing.Point(111, 316);
            this.cbMusica.Name = "cbMusica";
            this.cbMusica.Size = new System.Drawing.Size(292, 21);
            this.cbMusica.TabIndex = 11;
            this.cbMusica.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Música";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 556);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMusica);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIdade);
            this.Controls.Add(this.btnConferir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbNaoInformado);
            this.Controls.Add(this.rbFeminino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Controles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbNaoInformado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConferir;
        private System.Windows.Forms.TextBox TxtIdade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox cbSelvagem;
        private System.Windows.Forms.CheckBox cbCaipirinha;
        private System.Windows.Forms.CheckBox cbCerveja;
        private System.Windows.Forms.ComboBox cbMusica;
        private System.Windows.Forms.Label label4;
    }
}

