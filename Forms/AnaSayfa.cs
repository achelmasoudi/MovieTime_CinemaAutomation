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
    public partial class AnaSayfa : Form
    {

        SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
        SqlCommand cmd;
        SqlDataReader dr;

        PictureBox resim;
        Label filmAdi;
        Guna2Panel panel;
        Label filmKategorisiVeSuresi;
        Guna2Panel panel2;

        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand( "select Resim , FilmAdi , FilmKategorisi , FilmSuresi from Film_Bilgileri" , con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    filmBilgileriTasarimi();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("hata var !");
            }
            finally
            {
                con.Close();
            }
        }

        private void filmBilgileriTasarimi()
        {
            panel2 = new Guna2Panel();
            panel2.Width = 161;
            panel2.Height = 270;
            panel2.BackColor = Color.Transparent;

            panel = new Guna2Panel();
            panel.Width = 153;
            panel.Height = 259;
            panel.BackColor = Color.Transparent;
            panel.BorderColor = Color.FromArgb(87, 33, 182);
            panel.BorderThickness = 2;

            resim = new PictureBox();
            resim.Width = 147;
            resim.Height = 217;
            resim.SizeMode = PictureBoxSizeMode.StretchImage;
            resim.BackgroundImageLayout = ImageLayout.Zoom;
            resim.ImageLocation = dr["Resim"].ToString();
            resim.Location = new Point(3, 3);

            filmAdi = new Label();
            filmAdi.Text = dr["FilmAdi"].ToString();
            filmAdi.BackColor = Color.Transparent;
            filmAdi.ForeColor = Color.Red;
            filmAdi.Font = new Font("aladin", 11, FontStyle.Regular);
            filmAdi.TextAlign = ContentAlignment.MiddleCenter;
            filmAdi.Location = new Point(0, 219);
            filmAdi.Width = 153;

            filmKategorisiVeSuresi = new Label();
            filmKategorisiVeSuresi.Text = dr["FilmKategorisi"].ToString() + " , " + dr["FilmSuresi"].ToString();
            filmKategorisiVeSuresi.BackColor = Color.Transparent;
            filmKategorisiVeSuresi.ForeColor = Color.DimGray;
            filmKategorisiVeSuresi.Font = new Font("Microsoft JhengHei UI", 8, FontStyle.Regular);
            filmKategorisiVeSuresi.TextAlign = ContentAlignment.MiddleCenter;
            filmKategorisiVeSuresi.Location = new Point(0, 236);
            filmKategorisiVeSuresi.Width = 153;



            panel2.Controls.Add(panel);
            panel.Controls.Add(resim);
            panel.Controls.Add(filmAdi);
            panel.Controls.Add(filmKategorisiVeSuresi);
            flowLayoutPanel.Controls.Add(panel2);
        }
    }
}
