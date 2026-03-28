using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Vertex
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=db1;Integrated Security=True");
private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text;
                string password = "";
                baglanti.Open();
                SqlCommand logkomut = new SqlCommand("SELECT password FROM users where username =@p1", baglanti);
                logkomut.Parameters.AddWithValue("@p1", username);
                SqlDataReader sqlDataReader = logkomut.ExecuteReader();
                while (sqlDataReader.Read())

                {
                    password = sqlDataReader[0].ToString();
                }
                if (password == textBox2.Text) 
                {
                    this.Hide();
                    Form1 gir = new Form1();
                    gir.ShowDialog();
                    this.Close();
                    
                }
                else {MessageBox.Show("YANLIŞ ŞİFRE VEYA KULLANICI ADI"); }
            }
            catch (Exception ex )
            {
                MessageBox.Show("BAĞLANTI HATASI"+ ex.Message);
                this.Close();
            }
            finally {baglanti.Close(); }
        }
    }
}
