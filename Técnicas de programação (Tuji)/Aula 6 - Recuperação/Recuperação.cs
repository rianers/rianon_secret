﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnConferir_Click(object sender, EventArgs e) {
            double n1;
            n1 = Convert.ToDouble(txtIdade.Text);
            if (n1 >= 18) {
                MessageBox.Show("Liberado");
            }

            else {
                MessageBox.Show("Entrada proibida");
            }
        }
    }
}