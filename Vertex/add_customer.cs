using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace Vertex
{
    public partial class add_customer : Form
    {
        public add_customer()
        {
            InitializeComponent();

        }
        // Form2'nin en başında Form1 tipinde bir değişken tutmalısın



        SqlConnection baglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = db1; Integrated Security = True");


        string i;

        private void save_customer_Click(object sender, EventArgs e)
        {
            string kayit = textBox1.Text;
            int sonuc = 0;
            try
            {

                if (radioButton1.Checked) { i = "MÜŞTERİ"; }
                else if (radioButton2.Checked) { i = "FİRMA"; }


                baglanti.Open();


                SqlCommand kayit_cmd = new SqlCommand("INSERT INTO customer_table (customer_name, customer_type, customer_phone, " +
                    "customer_adress, customer_loan) VALUES (@p1, @p2, @p3, @p4, @p5) ", baglanti);
                kayit_cmd.Parameters.AddWithValue("@p1", kayit);
                kayit_cmd.Parameters.AddWithValue("@p2", i);
                kayit_cmd.Parameters.AddWithValue("@p3", 0);
                kayit_cmd.Parameters.AddWithValue("@p4", "boş");
                kayit_cmd.Parameters.AddWithValue("@p5", 0);





                if ((radioButton1.Checked && !string.IsNullOrWhiteSpace(textBox1.Text)) || (radioButton2.Checked && !string.IsNullOrWhiteSpace(textBox1.Text)))
                {
                    ; //firma olarak atanacak değer 0 dır
                    sonuc = kayit_cmd.ExecuteNonQuery();
                }

                else { MessageBox.Show("LÜTFEN MÜŞTERİ VEYA FİRMA SEÇENEĞİNİ SEÇİN"); sonuc = 2; }

                if (sonuc == 1)
                {
                    this.Close();
                }
                else if (sonuc == 0) { MessageBox.Show("KAYIT SIRASINDA HATA OLUŞTU "); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            finally
            {
                baglanti.Close();
            }

            Form1.instance.update_datas();


        }

        private void add_customer_Load(object sender, EventArgs e)
        {

        }
    }


}
