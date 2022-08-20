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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Pessoas_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dGVPessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\71888\source\repos\BancoDeFofos\Eucalipto.mdf;Integrated Security=True
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\71888\source\repos\BancoDeFofos\Eucalipto.mdf;Integrated Security=True");

            conn.Open();
            string select = "SELECT * FROM dbo.Pessoa";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] elementos = new string[5];

                for (int i = 0; i < elementos.Length; i++)
                {
                    elementos[i] = dr[i].ToString();
                }

                dGVPessoa.Rows.Add(elementos);
            }
            conn.Close();   
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
