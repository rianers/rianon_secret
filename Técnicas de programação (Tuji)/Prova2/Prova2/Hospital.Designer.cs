namespace Prova2 {
    partial class Hospital {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox lblTotalFormaPG;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital));
            this.lblTotalForma = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxTelefone = new System.Windows.Forms.TextBox();
            this.txtBoxPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblExames = new System.Windows.Forms.Label();
            this.lblInternacao = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.chbExames = new System.Windows.Forms.CheckBox();
            this.chbInternacao = new System.Windows.Forms.CheckBox();
            this.chbConsulta = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotalServ = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalPlanoConv = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblTotalPlano = new System.Windows.Forms.Label();
            this.lblttlpgr = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            lblTotalFormaPG = new System.Windows.Forms.GroupBox();
            lblTotalFormaPG.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalFormaPG
            // 
            lblTotalFormaPG.Controls.Add(this.lblTotalForma);
            lblTotalFormaPG.Controls.Add(this.radioButton5);
            lblTotalFormaPG.Controls.Add(this.radioButton4);
            lblTotalFormaPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalFormaPG.ForeColor = System.Drawing.SystemColors.HotTrack;
            lblTotalFormaPG.Location = new System.Drawing.Point(10, 79);
            lblTotalFormaPG.Name = "lblTotalFormaPG";
            lblTotalFormaPG.Size = new System.Drawing.Size(491, 78);
            lblTotalFormaPG.TabIndex = 1;
            lblTotalFormaPG.TabStop = false;
            lblTotalFormaPG.Text = "Formas de Pagamento";
            // 
            // lblTotalForma
            // 
            this.lblTotalForma.AutoSize = true;
            this.lblTotalForma.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTotalForma.Location = new System.Drawing.Point(322, 34);
            this.lblTotalForma.Name = "lblTotalForma";
            this.lblTotalForma.Size = new System.Drawing.Size(105, 20);
            this.lblTotalForma.TabIndex = 4;
            this.lblTotalForma.Text = "lnlTotalForma";
            this.lblTotalForma.Visible = false;
            this.lblTotalForma.Click += new System.EventHandler(this.lblTotalForma_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radioButton5.Location = new System.Drawing.Point(133, 39);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(80, 24);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "à prazo";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radioButton4.Location = new System.Drawing.Point(23, 39);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(72, 24);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "à vista";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPaciente.Location = new System.Drawing.Point(0, 38);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(71, 20);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.Text = "Paciente";
            this.lblPaciente.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTelefone.Location = new System.Drawing.Point(0, 77);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.txtBoxTelefone);
            this.groupBox1.Controls.Add(this.txtBoxPaciente);
            this.groupBox1.Controls.Add(this.lblPaciente);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Paciente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Location = new System.Drawing.Point(91, 71);
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(751, 26);
            this.txtBoxTelefone.TabIndex = 3;
            this.txtBoxTelefone.TextChanged += new System.EventHandler(this.txtBoxTelefone_TextChanged);
            // 
            // txtBoxPaciente
            // 
            this.txtBoxPaciente.Location = new System.Drawing.Point(91, 32);
            this.txtBoxPaciente.Name = "txtBoxPaciente";
            this.txtBoxPaciente.Size = new System.Drawing.Size(751, 26);
            this.txtBoxPaciente.TabIndex = 2;
            this.txtBoxPaciente.TextChanged += new System.EventHandler(this.txtBoxPaciente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hospital Nossa Senhora da Lapa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 73);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plano de Saúde";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radioButton3.Location = new System.Drawing.Point(206, 39);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Privado";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radioButton2.Location = new System.Drawing.Point(91, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Particular";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radioButton1.Location = new System.Drawing.Point(10, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SUS";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblExames);
            this.groupBox3.Controls.Add(this.lblInternacao);
            this.groupBox3.Controls.Add(this.lblConsulta);
            this.groupBox3.Controls.Add(this.chbExames);
            this.groupBox3.Controls.Add(this.chbInternacao);
            this.groupBox3.Controls.Add(this.chbConsulta);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(12, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 152);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviços";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblExames
            // 
            this.lblExames.AutoSize = true;
            this.lblExames.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblExames.Location = new System.Drawing.Point(212, 119);
            this.lblExames.Name = "lblExames";
            this.lblExames.Size = new System.Drawing.Size(58, 20);
            this.lblExames.TabIndex = 7;
            this.lblExames.Text = "150.00";
            this.lblExames.Visible = false;
            // 
            // lblInternacao
            // 
            this.lblInternacao.AutoSize = true;
            this.lblInternacao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblInternacao.Location = new System.Drawing.Point(211, 82);
            this.lblInternacao.Name = "lblInternacao";
            this.lblInternacao.Size = new System.Drawing.Size(58, 20);
            this.lblInternacao.TabIndex = 6;
            this.lblInternacao.Text = "510.00";
            this.lblInternacao.Visible = false;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblConsulta.Location = new System.Drawing.Point(211, 38);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(49, 20);
            this.lblConsulta.TabIndex = 5;
            this.lblConsulta.Text = "75.00";
            this.lblConsulta.Visible = false;
            this.lblConsulta.Click += new System.EventHandler(this.lblConsulta_Click);
            // 
            // chbExames
            // 
            this.chbExames.AutoSize = true;
            this.chbExames.ForeColor = System.Drawing.SystemColors.InfoText;
            this.chbExames.Location = new System.Drawing.Point(7, 119);
            this.chbExames.Name = "chbExames";
            this.chbExames.Size = new System.Drawing.Size(175, 24);
            this.chbExames.TabIndex = 2;
            this.chbExames.Text = "Exames Laboritoriais";
            this.chbExames.UseVisualStyleBackColor = true;
            this.chbExames.CheckedChanged += new System.EventHandler(this.chbExames_CheckedChanged);
            // 
            // chbInternacao
            // 
            this.chbInternacao.AutoSize = true;
            this.chbInternacao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.chbInternacao.Location = new System.Drawing.Point(7, 78);
            this.chbInternacao.Name = "chbInternacao";
            this.chbInternacao.Size = new System.Drawing.Size(105, 24);
            this.chbInternacao.TabIndex = 1;
            this.chbInternacao.Text = "Internação";
            this.chbInternacao.UseVisualStyleBackColor = true;
            this.chbInternacao.CheckedChanged += new System.EventHandler(this.chbInternacao_CheckedChanged);
            // 
            // chbConsulta
            // 
            this.chbConsulta.AutoSize = true;
            this.chbConsulta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.chbConsulta.Location = new System.Drawing.Point(7, 38);
            this.chbConsulta.Name = "chbConsulta";
            this.chbConsulta.Size = new System.Drawing.Size(91, 24);
            this.chbConsulta.TabIndex = 0;
            this.chbConsulta.Text = "Consulta";
            this.chbConsulta.UseVisualStyleBackColor = true;
            this.chbConsulta.CheckedChanged += new System.EventHandler(this.lblConsulta_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(12, 515);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(860, 89);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operações";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button4.Location = new System.Drawing.Point(672, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Encerrar - Alt + E";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button3.Location = new System.Drawing.Point(461, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Calculadora - Alt + C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button2.Location = new System.Drawing.Point(260, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Calcular - Alt + A";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(56, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Limpar - Alt + L";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTotalServ);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.lblTotalPlanoConv);
            this.groupBox5.Controls.Add(this.lblTotalPagar);
            this.groupBox5.Controls.Add(this.lblTotalPlano);
            this.groupBox5.Controls.Add(this.lblttlpgr);
            this.groupBox5.Controls.Add(lblTotalFormaPG);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox5.Location = new System.Drawing.Point(369, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(507, 265);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Formas de Pagamento";
            // 
            // lblTotalServ
            // 
            this.lblTotalServ.AutoSize = true;
            this.lblTotalServ.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTotalServ.Location = new System.Drawing.Point(332, 42);
            this.lblTotalServ.Name = "lblTotalServ";
            this.lblTotalServ.Size = new System.Drawing.Size(91, 20);
            this.lblTotalServ.TabIndex = 8;
            this.lblTotalServ.Text = "lblTotalServ";
            this.lblTotalServ.Visible = false;
            this.lblTotalServ.Click += new System.EventHandler(this.lblTotalServ_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(29, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor Total de Serviços:";
            // 
            // lblTotalPlanoConv
            // 
            this.lblTotalPlanoConv.AutoSize = true;
            this.lblTotalPlanoConv.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTotalPlanoConv.Location = new System.Drawing.Point(332, 233);
            this.lblTotalPlanoConv.Name = "lblTotalPlanoConv";
            this.lblTotalPlanoConv.Size = new System.Drawing.Size(51, 20);
            this.lblTotalPlanoConv.TabIndex = 6;
            this.lblTotalPlanoConv.Text = "label6";
            this.lblTotalPlanoConv.Visible = false;
            this.lblTotalPlanoConv.Click += new System.EventHandler(this.lblTotalPlanoConv_Click);
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTotalPagar.Location = new System.Drawing.Point(332, 191);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(101, 20);
            this.lblTotalPagar.TabIndex = 5;
            this.lblTotalPagar.Text = "lblTotalPagar";
            this.lblTotalPagar.Visible = false;
            this.lblTotalPagar.Click += new System.EventHandler(this.lblTotalPagar_Click);
            // 
            // lblTotalPlano
            // 
            this.lblTotalPlano.AutoSize = true;
            this.lblTotalPlano.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTotalPlano.Location = new System.Drawing.Point(10, 233);
            this.lblTotalPlano.Name = "lblTotalPlano";
            this.lblTotalPlano.Size = new System.Drawing.Size(261, 20);
            this.lblTotalPlano.TabIndex = 3;
            this.lblTotalPlano.Text = "Cobrar do Governo/Plano de Saude";
            // 
            // lblttlpgr
            // 
            this.lblttlpgr.AutoSize = true;
            this.lblttlpgr.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblttlpgr.Location = new System.Drawing.Point(6, 192);
            this.lblttlpgr.Name = "lblttlpgr";
            this.lblttlpgr.Size = new System.Drawing.Size(106, 20);
            this.lblttlpgr.TabIndex = 2;
            this.lblttlpgr.Text = "Total a pagar:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Prova2.Properties.Resources.hospital_small;
            this.pictureBox2.Location = new System.Drawing.Point(735, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 123);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Prova2.Properties.Resources.hospital_small;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 123);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 606);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hospital";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hospital_Load);
            lblTotalFormaPG.ResumeLayout(false);
            lblTotalFormaPG.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbExames;
        private System.Windows.Forms.CheckBox chbInternacao;
        private System.Windows.Forms.CheckBox chbConsulta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTotalPlano;
        private System.Windows.Forms.Label lblttlpgr;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotalForma;
        private System.Windows.Forms.Label lblTotalPlanoConv;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblTotalServ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblExames;
        private System.Windows.Forms.Label lblInternacao;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtBoxTelefone;
        private System.Windows.Forms.TextBox txtBoxPaciente;
    }
}

