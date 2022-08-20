using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeFofos
{
    public partial class InserePessoa : Form
    {
        public InserePessoa()
        {
            InitializeComponent();
        }

        private void InserePessoa_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ConnectionString.Conn.Open();

            string insert = $"INSERT INTO dbo.Pessoa (Nome,Cpf,DataNascimento,Telefone) VALUES ('{txtNome.Text}','{txtCpf.Text}','{dTPNascimento.Value.ToString("u")}','{txtTelefone.Text}')";
            SqlCommand cmd = new SqlCommand(insert, ConnectionString.Conn);
            cmd.ExecuteNonQuery();

            ConnectionString.Conn.Close();

            txtNome.Clear();
            txtCpf.Clear();
            dTPNascimento.Value = new DateTime;
            txtTelefone.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
