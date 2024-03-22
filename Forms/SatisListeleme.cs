using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieTime.Forms
{
    public partial class SatisListeleme : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public SatisListeleme()
        {
            InitializeComponent();
        }


        private void TariheGoreListeleme()
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
            DataTable table = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Satis_Bilgileri where Tarih like '" + dateTimePicker1.Text + "'", con);
                dataAdapter.Fill(table);
                guna2DataGridView1.DataSource = table;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

        }

        private void SatisListeleme_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);

            try
            {
                con.Open();
                string command = "SELECT * FROM Satis_Bilgileri Order By id";
                SqlCommand cmd = new SqlCommand(command, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            ToplamUcretFunc();

            SalonGetir();
        }

        private void tumSatislarBtn_Click(object sender, EventArgs e)
        {
            tumSatislar();
            ToplamUcretFunc();
        }

        private void tumSatislar()
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
            try
            {
                con.Open();
                string command = "SELECT * FROM Satis_Bilgileri";
                SqlCommand cmd = new SqlCommand(command, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);
                guna2DataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void ToplamUcretFunc()
        {
            int toplamUcret = 0;

            for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
            {
                try
                {
                    toplamUcret += Convert.ToInt32(guna2DataGridView1.Rows[i].Cells["Ucret"].Value);

                }

                catch(Exception ex)
                {
                    MessageBox.Show("Hata var !!");
                }
            }

            ucretToplami.Text = toplamUcret + " TL";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TariheGoreListeleme();
            ToplamUcretFunc();
        }

        private void satislarSilBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);


            DialogResult dialog = MessageBox.Show("Satışları silmek istediğinize emin misiniz? ?", "Silmek", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("delete from Satis_Bilgileri where Tarih like '" + dateTimePicker1.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Satışları başarıyla silindi !", "Silmek", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TariheGoreListeleme();
                    ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata");
                }
            }

        }

        private void SalonGetir()
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from SalonBil_Tablo", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    salonComB.Items.Add(dr["SalonAdi"].ToString());
                }

            }
            catch (Exception ex)
            {
                con.Close();
            }
        }

        private void salonComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            salonaGoreListeleme();
            ToplamUcretFunc();
        }

        private void salonaGoreListeleme()
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Satis_Bilgileri where SalonAdi='" + salonComB.SelectedItem + "'", con);
                dataAdapter.Fill(table);
                guna2DataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

        }

        int i = 0;
        private void guna2DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            i = e.RowIndex;
            try
            {

                koltukNoTxtB.Text = guna2DataGridView1.Rows[i].Cells[1].Value.ToString();
                AdSoyadTxtB.Text = guna2DataGridView1.Rows[i].Cells[6].Value.ToString();
            }

            catch(Exception ex)
            {

            }
        }

        private void bilgileriGuncelleBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);

            bool bl = false;
            for(int i=1; i<113; i++)
            {
                if(koltukNoTxtB.Text=="Koltuk_"+i)
                {
                    bl= true;
                }
            }

            if(bl)
            {
                if(AdSoyadTxtB.Text!="")
                {
                    try
                    {
                        con.Open();
                        cmd = new SqlCommand("update Satis_Bilgileri set KoltukNo='" + koltukNoTxtB.Text + "' , Ad_Soyad='" + AdSoyadTxtB.Text + "' where id='" + guna2DataGridView1.Rows[i].Cells[0].Value + "'", con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Bilgileri başarıyla güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        koltukNoTxtB.Text = "";
                        AdSoyadTxtB.Text = "";
                        tumSatislar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata var !");
                    }
                }
                else
                {
                    MessageBox.Show("Adını ve soyadını giriniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if(!bl)
            {
                MessageBox.Show("Aradıgınız koltuk bulunamadı !" , "Hata var !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
