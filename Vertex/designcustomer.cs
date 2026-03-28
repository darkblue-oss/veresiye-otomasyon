using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vertex
{
    public partial class designcustomer : Form
    {
        public designcustomer()
        {
            InitializeComponent();
            SqlConnection baglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = db1; Integrated Security = True");

            try
            {
                baglanti.Open();
                SqlCommand bring1 = new SqlCommand("SELECT customer_name FROM customer_table where customer_ıd =" + Form1.instance.musteri_id, baglanti);
                textBox1.Text = Convert.ToString(bring1.ExecuteScalar());


            }
            catch (Exception)
            {


            }
            finally { baglanti.Close(); }

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = db1; Integrated Security = True");
        private void save_customer_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string type = "";            
            if (radioButton1.Checked = true) 
            {
                type = "MÜŞTERİ";
            } 
            else if (radioButton2.Checked = true)
            {
                type = "FİRMA";

            }
            try
            {
                baglanti.Open();
                SqlCommand design1 = new SqlCommand("UPDATE customer_table SET customer_name= '"+name+"' WHERE customer_ıd =" + Form1.instance.musteri_id, baglanti);
                SqlCommand design2 = new SqlCommand("UPDATE customer_table SET customer_type='"+type+"' WHERE customer_ıd=" + Form1.instance.musteri_id, baglanti);
                if ((radioButton1.Checked && !string.IsNullOrWhiteSpace(textBox1.Text)) || (radioButton2.Checked && !string.IsNullOrWhiteSpace(textBox1.Text)))
                {
                    design1.ExecuteNonQuery();
                    design2.ExecuteNonQuery();
                    this.Close();
                }

                else { MessageBox.Show("LÜTFEN BİLGİLERİ EKSİKSİZ DOLDURUN"); }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { baglanti.Close(); }
        }
    }
}
