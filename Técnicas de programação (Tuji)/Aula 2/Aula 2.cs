using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, Res;
            n1 = Convert.ToDouble(txt1Nota.Text);
            n2 = Convert.ToDouble(txt2Nota.Text);
            n3 = Convert.ToDouble(txt3Nota.Text);
            n4 = Convert.ToDouble(txt4Nota.Text);
            Res = (n1 + n2 + n3 + n4) / 4;
            if (Res > 6) {
                MessageBox.Show("Aluno Aprovado com a Média: "+Res+"!", "Janela");
            }
            else if (Res == 6) {
                MessageBox.Show("Aluno de Recuperação!", "Janela");
            }
            else {
                MessageBox.Show("Aluno Reprovado! Sua nota pífia foi de: " + Res, "Janela");
            }
   

