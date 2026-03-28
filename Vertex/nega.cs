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
    public partial class nega : Form
    {
        public nega()
        {
            InitializeComponent();
        }
        string islem_acklama;
        int islem_tutar;
        int borcu;
     

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=db1;Integrated Security=True");
        int yeniborcu;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                islem_acklama = textBox1.Text;
                islem_tutar = Convert.ToInt32(textBox2.Text);
                SqlCommand insert = new SqlCommand("INSERT INTO islemler (islem_text, islem_tutar, islem_type, customer_ıd, islem_type_id) VALUES (@p1, @p2, @p3, @p4, @p5)", baglanti);
                insert.Parameters.AddWithValue("@p1", islem_acklama);
                insert.Parameters.AddWithValue("@p2", islem_tutar);
                insert.Parameters.AddWithValue("@p4", Form1.instance.musteri_id);
                insert.Parameters.AddWithValue("@p3", "TAHSİLAT");
                insert.Parameters.AddWithValue("@p5", 1);
                SqlCommand borc = new SqlCommand("SELECT customer_loan FROM customer_table where customer_ıd=" + Form1.instance.musteri_id, baglanti);
                borcu = Convert.ToInt32(borc.ExecuteScalar());
                yeniborcu = borcu - islem_tutar;
                SqlCommand updatee = new SqlCommand("UPDATE customer_table SET customer_loan =" + yeniborcu + " where customer_ıd =" + Form1.instance.musteri_id, baglanti);
                int sonuc = insert.ExecuteNonQuery();
                updatee.ExecuteNonQuery();
                if (yeniborcu < 0)
                {
                    Form1.instance.label2.ForeColor = System.Drawing.Color.Red;
                    Form1.instance.label2.Text = Convert.ToString(yeniborcu)+ "  ALACAKLI";
                }
                else
                {
                    Form1.instance.label2.ForeColor = System.Drawing.Color.Green;
                    Form1.instance.label2.Text = Convert.ToString(yeniborcu)+ "  BORÇLU";
                }

                if (sonuc > 0)
                {
                    Form1.instance.update_cust_datas();
                    Form1.instance.update_datas();
                    Form1.instance.data_sett();
                    this.Close();
                
                }
                else
                {
                    MessageBox.Show("KAYIT SIRASINDA HATA OLUŞTU");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
