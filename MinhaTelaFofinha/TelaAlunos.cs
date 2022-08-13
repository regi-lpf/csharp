using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaTelaFofinha
{
    public partial class TelaAlunos : Form
    {
        private string filePath = @"C:\Users\71888\Desktop\BD.txt";
        private TelaInicial telaInicial;
        private bool addAlunos = false;

        public TelaAlunos()
        {
            InitializeComponent();
            PreencheDGV(); 
        }

        public TelaAlunos(TelaInicial tela)
        {
            telaInicial = tela;
            InitializeComponent();
            PreencheDGV();
        }

        private void TelaAlunos_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (addAlunos)
            {
                string[] elementos = new string[6];
                elementos[0] = txtNome.Text;
                elementos[1] = txtIdade.Text;
                elementos[2] = txtSerie.Text;
                elementos[3] = txtNota1.Text;
                elementos[4] = txtNota2.Text;
                elementos[5] = txtNota3.Text;

                dGVAlunos.Rows.Add(elementos);

                txtNome.Clear();
                txtIdade.Clear();
                txtSerie.Clear();
                txtNota1.Clear();
                txtNota2.Clear();
                txtNota3.Clear();

                addAlunos = !addAlunos;
                AlteraModo();

            }
            else
            {
                telaInicial.Show();

                this.Close();
            }
            
        }

        public void PreencheDGV()
        {
            string[] linhas = File.ReadAllLines(filePath);

            for (int i = 1; i < linhas.Length; i++)
            {
                string[] elementos = linhas[i].Split('|');
                dGVAlunos.Rows.Add(elementos);
            }
        }

        public void AlteraModo()
        {
            label1.Visible = addAlunos;
            label2.Visible = addAlunos;
            label3.Visible = addAlunos;
            label4.Visible = addAlunos;
            label5.Visible = addAlunos;
            label6.Visible = addAlunos;
            txtNome.Visible = addAlunos;
            txtIdade.Visible = addAlunos;
            txtSerie.Visible = addAlunos;
            txtNota1.Visible = addAlunos;
            txtNota2.Visible = addAlunos;
            txtNota3.Visible = addAlunos;

            dGVAlunos.Visible = addAlunos;
        }

        private void dGVAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (addAlunos)
            {
                string[] elementos = new string[6];
                elementos[0] = txtNome.Text;
                elementos[1] = txtIdade.Text;
                elementos[2] = txtSerie.Text;
                elementos[3] = txtNota1.Text;
                elementos[4] = txtNota2.Text;
                elementos[5] = txtNota3.Text;

                dGVAlunos.Rows.Add(elementos);

                txtNome.Clear();
                txtIdade.Clear();
                txtSerie.Clear();
                txtNota1.Clear();
                txtNota2.Clear();
                txtNota3.Clear();

                addAlunos = !addAlunos;
                AlteraModo();

            }
            else
            {
                List<string> elementos = new List<string>();
                elementos.Add(@"Nome|Idade|Serie|Nota 1|Nota 2|Nota 3");

                foreach (DataGridView item in dGVAlunos.Rows)
                {
                    string valor = "";
                    for (int i = 0; i < 6; i++)
                    {
                        valor = item.Cells[i].Value = '|';
                    }
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            addAlunos = !addAlunos;
            AlteraModo();
        }
    }
}
