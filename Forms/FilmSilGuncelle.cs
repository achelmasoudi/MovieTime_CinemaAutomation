using Guna.UI2.WinForms;
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
    public partial class FilmSilGuncelle : Form
    {

        SqlCommand cmd;
        SqlDataReader dr;

        public FilmSilGuncelle()
        {
            InitializeComponent();
        }

        private void FilmSilGuncelle_Load(object sender, EventArgs e)
        {
            FilmGetir();
        }

        private void filmComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmAdiTxtB.Text = "";
            yonetmenTxtB.Text = "";
            filmKategorisiComB.Text = null;
            filmSuresiTxtB.Text = "";
            filmDiliComB.Text = null;

            FilmBilgileriGoster();
        }

        private void FilmGetir()
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
            try
            {

                con.Open();
                cmd = new SqlCommand("select * from Film_Bilgileri", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    filmComB.Items.Add(dr["FilmAdi"].ToString());
                }

            }
            catch (Exception ex)
            {
                con.Close();
            }

        }

        private void FilmBilgileriGoster()
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);

            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Film_Bilgileri where FilmAdi='" + filmComB.SelectedItem + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    filmPosteriPicB.ImageLocation = dr["Resim"].ToString();
                    filmAdiTxtB.Text = dr["FilmAdi"].ToString();
                    yonetmenTxtB.Text = dr["Yonetmen"].ToString();
                    filmKategorisiComB.Text = dr["FilmKategorisi"].ToString();
                    filmSuresiTxtB.Text = dr["FilmSuresi"].ToString();
                    filmDiliComB.Text = dr["FilmDili"].ToString();
                   

                }
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }
        
        private void filmSilBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);


            DialogResult dialog = MessageBox.Show("Filmi silmek istediğinize emin misiniz? ?", "Silmek", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(dialog == DialogResult.OK)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("delete from Film_Bilgileri where FilmAdi='" + filmComB.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Film başarıyla silindi !" , "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Information);

                    filmComB.Items.Remove(filmComB.SelectedItem);
                    filmAdiTxtB.Text = "";
                    yonetmenTxtB.Text = "";
                    filmKategorisiComB.Text = null;
                    filmSuresiTxtB.Text = "";
                    filmDiliComB.Text = null;
                    filmPosteriPicB.Image = null;
                    filmComB.Text = null;
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
                cmd = new SqlCommand("update Film_Bilgileri set FilmAdi='" +filmAdiTxtB.Text+ "' , Yonetmen='" +yonetmenTxtB.Text+ "' , FilmKategorisi='" +filmKategorisiComB.Text+ "' , FilmSuresi='" +filmSuresiTxtB.Text+ "' , FilmDili='" +filmDiliComB.Text+ "' where FilmAdi='" +filmComB.SelectedItem+ "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Film başarıyla güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                filmAdiTxtB.Text = "";
                yonetmenTxtB.Text = "";
                filmKategorisiComB.Text = null;
                filmSuresiTxtB.Text = "";
                filmDiliComB.Text = null;
                filmPosteriPicB.Image = null;

                filmComB.Items.Remove(filmComB.SelectedItem);
                filmComB.Text = "";
                filmComB.Text = null;

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
