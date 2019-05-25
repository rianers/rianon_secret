using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2 {
    public partial class Hospital : Form {
        double valorConsulta;
        double valorInternacao;
        double valorExame;

        private double valorTotalServico;
        private const double parametroDeCalculo = 0.15;


        public Hospital() {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e) {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {

        }

     

        private void lblTotalServ_Click(object sender, EventArgs e) {

            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                this.valorTotalServico = this.valorConsulta + this.valorInternacao + this.valorExame;
                lblTotalServ.Text = Convert.ToString(valorTotalServico);
                lblTotalServ.Visible = true;
                Console.WriteLine(lblTotalServ);
                //       lblTotalServ.Text = "R$" + valor;
            }

        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void lblConsulta_CheckedChanged(object sender, EventArgs e) {
            if(chbConsulta.Checked == true) {
                this.valorConsulta = 75.00;
                lblConsulta.Visible = true;
            }
            else {
                lblConsulta.Visible = false;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e) {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if(radioButton1.Checked == true) {
                radioButton4.Visible = false;
            radioButton5.Visible = false;
             }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            if (radioButton2.Checked == true)
            {
                radioButton4.Visible = true;
                radioButton5.Visible = true;

                mostraValorServiço();
            }
            else
            {
                radioButton4.Visible = false;
                radioButton5.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked == true)
            {
                radioButton4.Visible = false;
                radioButton5.Visible = false;
            }
        }

         private void radioButton4_CheckedChanged(object sender, EventArgs e) {
        /*     if (radioButton4.Checked == true)
            {
                lblTotalForma.Visible = true;
                String  x = lblTotalForma.Text;
                Double valorDouble = Double.Parse(x);
                Double valorDesconto = valorDouble * parametroDeCalculo;
                Console.WriteLine(valorDesconto);
            }  */
        }

        private void lblTotalServ_Click_1 (object sender, EventArgs e) {
            lblTotalServ.Visible = false;
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                this.valorTotalServico = this.valorConsulta + this.valorInternacao + this.valorExame;
                lblTotalServ.Text = Convert.ToString(valorTotalServico);
                lblTotalServ.Visible = true;
                Console.WriteLine(lblTotalServ);
         //       lblTotalServ.Text = "R$" + valor;
            }
        }

        private void lblTotalForma_Click(object sender, EventArgs e) {
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalPagar_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPlanoConv_Click(object sender, EventArgs e)
        {

        }

        private void lblConsulta_Click(object sender, EventArgs e)
        {
            String valorConsulta = lblConsulta.Text;

        }

        private void chbInternacao_CheckedChanged(object sender, EventArgs e)
        {
            if (chbInternacao.Checked == true)
            {
                this.valorInternacao = 510.00;
                lblInternacao.Visible = true;
            }
            else
            {
                lblInternacao.Visible = false;
            }
        }

        private void chbExames_CheckedChanged(object sender, EventArgs e)
        {
            if (chbExames.Checked == true)
            {
                this.valorExame = 150.00;
                lblExames.Visible = true;
            }
            else
            {
                lblExames.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void mostraValorServiço()
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                this.valorTotalServico = this.valorConsulta + this.valorInternacao + this.valorExame;
                lblTotalServ.Text = Convert.ToString(valorTotalServico);
                lblTotalServ.Visible = true;
                Console.WriteLine(lblTotalServ);
                //       lblTotalServ.Text = "R$" + valor;
            }

        }

        private void Hospital_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxPaciente.Text = String.Empty;
            txtBoxTelefone.Text = String.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            chbConsulta.Checked = false;
            chbInternacao.Checked = false;
            chbExames.Checked = false;
            lblTotalServ.Text = String.Empty;

        }

        public void abrirCalculadora()
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}
