using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_3___Ricardo_Vasconcellos
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = Convert.ToDouble(txtNum1.Text);
            n2 = Convert.ToDouble(txtNum2.Text);

            if (n1 == n2){
                MessageBox.Show("Numeros iguais", "Resposta1");
             } else { 
            
                if (n1 > n2) {
                    MessageBox.Show(n1 + " Maior que " + n2, "Numeros diferentes");

                }
                else {
                    MessageBox.Show(n1 + " Menor que " + n2, "Numeros diferentes")      ;
                }
            }

           

        }
           

        
    }
}
