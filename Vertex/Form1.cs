using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Vertex
{
    public partial class Form1 : Form

    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            update_datas();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowTemplate.Height = 70;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 24);
            dataGridView1.Columns["customer_ıd"].Width = 100;
            dataGridView1.Columns["customer_type"].Width = 300;
            dataGridView1.Columns["customer_loan"].Width = 200;
            dataGridView1.Columns["customer_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["customer_loan"].HeaderText = "BAKİYE";
            dataGridView1.Columns["customer_type"].HeaderText = "KAYIT TİPİ";
            dataGridView1.Columns["customer_ıd"].HeaderText = "ID";
            dataGridView1.Columns["customer_name"].HeaderText = "İSİM";
            dataGridView1.Columns["customer_ıd"].HeaderText = "ID";
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = db1; Integrated Security = True");

        int rowindex;
        public string musteri_id = "";
        int brc;
        int islem_id;
        int silinen_tutar;
        int silinen_type;

        public void data_sett()
        {
            comboBox1.DropDownHeight = 100;
            comboBox1.IntegralHeight = false;
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AllowUserToOrderColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.RowTemplate.Height = 70;
            dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 24);
            dataGridView2.Columns["customer_ıd"].Width = 100;
            dataGridView2.Columns["islem_tutar"].Width = 200;
            dataGridView2.Columns["islem_type"].Width = 300;
            dataGridView2.Columns["islem_text"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 24);
        }
        int loan;
        public void update_loan()
        {
            SqlCommand loandata = new SqlCommand("SELECT COUNT (*) FROM customer_table", baglanti);
            int snc = Convert.ToInt32(loandata.ExecuteScalar());
            for (int i = 0; i < snc; i++)
            {

            }

        }
        public void update_datas()
        {
            try
            {
                baglanti.Open();
                string data_query = "SELECT customer_ıd, customer_name,customer_type, customer_loan FROM customer_table ORDER BY customer_ıd ASC";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(data_query, baglanti);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally { baglanti.Close(); }
        }

        public void update_cust_datas()
        {
            baglanti.Open();
            DataGridViewRow row = dataGridView1.Rows[rowindex];
            string label = Convert.ToString(row.Cells["customer_name"].Value);
            label1.Text = label;
            musteri_id = Convert.ToString(row.Cells["customer_ıd"].Value);
            string islem_query = "SELECT customer_ıd ,islem_text,islem_id, islem_tutar,islem_type FROM islemler where customer_ıd =" + musteri_id;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(islem_query, baglanti);
            DataTable dt2 = new DataTable();
            dataAdapter.Fill(dt2); dataGridView2.DataSource = dt2;
            baglanti.Close();
        }

        private void add_customer_Click(object sender, EventArgs e)
        {
            add_customer f2 = new add_customer();
            f2.ShowDialog();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* if (e.RowIndex > -1)
             {
                 try
                 {
                     rowindex = e.RowIndex;
                     baglanti.Open();
                     DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                     string label = Convert.ToString(row.Cells["customer_name"].Value);
                     label1.Text = label;
                     musteri_id = Convert.ToString(row.Cells["customer_ıd"].Value);
                     string islem_query = "SELECT customer_ıd ,islem_text, islem_tutar, islem_type FROM islemler where customer_ıd =" + musteri_id;
                     SqlDataAdapter dataAdapter = new SqlDataAdapter(islem_query, baglanti);
                     DataTable dt2 = new DataTable();
                     dataAdapter.Fill(dt2);
                     dataGridView2.DataSource = dt2;
                     data_sett();
                     SqlCommand lndata = new SqlCommand("SELECT customer_loan FROM customer_table where customer_ıd =" + musteri_id, baglanti);
                     brc = Convert.ToInt32(lndata.ExecuteScalar());
                     if (brc >= 0)
                     {
                         label2.ForeColor = Color.Green;
                         label2.Text = Convert.ToString(brc) + "  BORÇLU";
                     }
                     else
                     {
                         label2.ForeColor = Color.Red;
                         label2.Text = Convert.ToString(brc) + "  ALACAKLI";
                     }
                     panel1.Visible = false;
                     panel2.Visible = true;
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                 finally { baglanti.Close(); }
             }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;

        }

        public void delete_customer()
        {
            try
            {
                baglanti.Open();
                SqlCommand deletecmdislem = new SqlCommand("DELETE FROM islemler where customer_ıd=" + musteri_id, baglanti);
                SqlCommand deletecmduser = new SqlCommand("DELETE FROM customer_table where customer_ıd =" + musteri_id, baglanti);
                int sonc = deletecmdislem.ExecuteNonQuery();
                sonc += deletecmduser.ExecuteNonQuery();
                if (sonc > 0)
                {
                    MessageBox.Show("MÜŞTERİ KAYDI SİLİNDİ" + Convert.ToString(sonc));
                }

            }
            catch (Exception)
            {
            }
            finally { baglanti.Close(); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                loan loan = new loan();
                loan.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                nega nega = new nega();
                nega.ShowDialog();
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[hit.RowIndex].Cells[hit.ColumnIndex];

                }
            }
        }

        private void müşteriyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteri_id = Convert.ToString(dataGridView1.SelectedRows[0].Cells["customer_ıd"].Value);
            delete_customer();
            update_datas();

        }

        private void müşteriyiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            designcustomer design = new designcustomer();
            design.ShowDialog();
        }

        private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    rowindex = e.RowIndex;
                    baglanti.Open();
                    DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                    islem_id = Convert.ToInt32(row.Cells["islem_id"].Value);
                    silinen_tutar = Convert.ToInt32(row.Cells["islem_tutar"].Value);


                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { baglanti.Close(); }

            }  
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    rowindex = e.RowIndex;
                    baglanti.Open();
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string label = Convert.ToString(row.Cells["customer_name"].Value);
                    label1.Text = label;
                    musteri_id = Convert.ToString(row.Cells["customer_ıd"].Value);
                    string islem_query = "SELECT customer_ıd ,islem_text, islem_tutar, islem_type FROM islemler where customer_ıd =" + musteri_id;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(islem_query, baglanti);
                    DataTable dt2 = new DataTable();
                    dataAdapter.Fill(dt2);
                    dataGridView2.DataSource = dt2;
                    data_sett();
                    SqlCommand lndata = new SqlCommand("SELECT customer_loan FROM customer_table where customer_ıd =" + musteri_id, baglanti);
                    brc = Convert.ToInt32(lndata.ExecuteScalar());
                    if (brc >= 0)
                    {
                        label2.ForeColor = Color.Green;
                        label2.Text = Convert.ToString(brc) + "  BORÇLU";
                    }
                    else
                    {
                        label2.ForeColor = Color.Red;
                        label2.Text = Convert.ToString(brc) + "  ALACAKLI";
                    }
                    panel1.Visible = false;
                    panel2.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { baglanti.Close();
                    update_cust_datas();
                }
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    rowindex = e.RowIndex;
                    baglanti.Open();
                    DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                    islem_id = Convert.ToInt32(row.Cells["islem_id"].Value);
                    silinen_tutar = Convert.ToInt32(row.Cells["islem_tutar"].Value);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { baglanti.Close(); }


            }
        }
        int borc;
        int yeniborc;
        int snuc;
        
        private void iŞLEMİSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand delete_islem = new SqlCommand("DELETE FROM islemler where islem_id=" + islem_id, baglanti);
                SqlCommand deletelrn = new SqlCommand("SELECT islem_type_id FROM islemler where islem_id =" + islem_id, baglanti);
                SqlCommand deleteaddlrn = new SqlCommand("SELECT customer_loan FROM customer_table where customer_ıd =" + musteri_id, baglanti);

                borc =Convert.ToInt32( deleteaddlrn.ExecuteScalar());
                MessageBox.Show(Convert.ToString(islem_id));
                silinen_type= Convert.ToInt32(deletelrn.ExecuteScalar());
                
                
                if (silinen_type == 1)
                {
                    yeniborc = borc + silinen_tutar;
                    SqlCommand deleteadd1 = new SqlCommand("UPDATE customer_table SET customer_loan =" + yeniborc + " where customer_ıd = " + musteri_id, baglanti);

                    snuc = delete_islem.ExecuteNonQuery() +deleteadd1.ExecuteNonQuery();
                }
                else if (silinen_type == 2)
                {
                   yeniborc = borc - silinen_tutar;
                    SqlCommand deleteadd1 = new SqlCommand("UPDATE customer_table SET customer_loan =" + yeniborc + " where customer_ıd = " + musteri_id, baglanti);

                    snuc = delete_islem.ExecuteNonQuery() + deleteadd1.ExecuteNonQuery();

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
               baglanti.Close();
                update_datas();
                baglanti.Open();
                string islem_query = "SELECT customer_ıd ,islem_text,islem_id, islem_tutar,islem_type FROM islemler where customer_ıd =" + musteri_id;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(islem_query, baglanti);
                DataTable dt2 = new DataTable();
                dataAdapter.Fill(dt2); dataGridView2.DataSource = dt2;
                baglanti.Close();
            }
        }
    }
}
