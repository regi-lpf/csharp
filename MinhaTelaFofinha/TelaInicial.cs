using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaTelaFofinha
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtUser.Text == "Margot" && TxtPassword.Text == "Aposentadoria")
            {
                MessageBox.Show("Sra. Margot, que bom que você ainda não se aposentou");
                TelaAlunos ta = new TelaAlunos(this);
                ta.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Você não é a Sra. Margot");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
