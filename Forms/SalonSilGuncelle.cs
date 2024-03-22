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

namespace MovieTime.Forms
{
    public partial class SalonSilGuncelle : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public SalonSilGuncelle()
        {
            InitializeComponent();
        }


        private void SalonSilGuncelle_Load(object sender, EventArgs e)
        {
            SalonGetir();
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
            salonAdiTxtB.Text = "";
            SalonGoster();
            
        }

        private void SalonGoster()
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);

            try
            {
                con.Open();
                cmd = new SqlCommand("select * from SalonBil_Tablo where SalonAdi='" + salonComB.SelectedItem+ "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    salonAdiTxtB.Text = dr["SalonAdi"].ToString();
                }
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }

        private void salonSilBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);

            DialogResult dialog = MessageBox.Show("Salonu silmek istediğinize emin misiniz? ?", "Silmek", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("delete from SalonBil_Tablo where SalonAdi='" + salonComB.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salonu başarıyla silindi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    salonComB.Items.Remove(salonComB.SelectedItem);
                    salonAdiTxtB.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata");
                }
            }
            
        }

        private void filmGuncelleBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);

            try
            {
                con.Open();
                cmd = new SqlCommand("update SalonBil_Tablo set SalonAdi='" + salonAdiTxtB.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salonu başarıyla güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                salonComB.Items.Remove(salonComB.SelectedItem);
                salonAdiTxtB.Text = "";
                salonComB.Text = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
