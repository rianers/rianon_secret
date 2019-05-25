using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles15_05 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnConferir_Click(object sender, EventArgs e) {
            string nome = TxtNome.Text;
            int idade = Convert.ToInt16(TxtIdade.Text);

            if(rbMasculino.Checked && idade >= 18) 
            {
                MessageBox.Show(nome + " - Brother!");
            }
            else if(rbMasculino.Checked && idade < 18) 
            {
                MessageBox.Show(nome + " - Vaza fio");
            }
            else if(rbFeminino.Checked) 
                {
                if(idade < 18 &&
                    (cbCaipirinha.Checked || cbCerveja.Checked || cbSelvagem.Checked)
                    ) 
            {
                MessageBox.Show(nome + " - Entrada Liberada, mas só vai beber Refri");
            }
                else {
                    MessageBox.Show(nome + " - Entrada Liberada");
                     }
                }
            else if(rbNaoInformado.Checked) 
                {
                if(idade < 18 &&
                   (cbCaipirinha.Checked || cbCerveja.Checked || cbSelvagem.Checked)
                   ) 
            {
                MessageBox.Show(nome + " - Entrada Liberada");
            }
                }
            if(cbMusica.SelectedItem.Equals("Sertanejo")) {
                MessageBox.Show("Você escolheu=" + cbMusica.SelectedItem.ToString() + (" sertanejeiro"));
            }
            else if(cbMusica.SelectedItem.Equals("Funk")) {
                MessageBox.Show("Você escolheu=" + cbMusica.SelectedItem.ToString() + (" funkeiro"));
            }
            else if(cbMusica.SelectedItem.Equals("Pagode")) {
                MessageBox.Show("Você escolheu=" + cbMusica.SelectedItem.ToString() + (" pagodeiro"));
            }
            else if(cbMusica.SelectedItem.Equals("Rock")) {
                MessageBox.Show("Você escolheu=" + cbMusica.SelectedItem.ToString() + (" rockeiro"));
            }
            else if(cbMusica.SelectedItem.Equals("Eletrônica")) {
                MessageBox.Show("Você escolheu=" + cbMusica.SelectedItem.ToString() + (" agitadasso"));
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
