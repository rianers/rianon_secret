using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e) {
            {
                double N1, N2;
                N1 = Convert.ToDouble(txtbox1.Text);
                N2 = Convert.ToDouble(txtbox2.Text);

                if (N1 == N2) {
                    MessageBox.Show("Números iguais", "Resposta");
                }
                else {
                    MessageBox.Show("Números diferentes", "Resposta");
                }
            }
        }
    }
}
