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

namespace MovieTime
{
    public partial class UcretGuncelle : Form
    {

        SqlCommand cmd;

        public UcretGuncelle()
        {
            InitializeComponent();
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

        private void filmGuncelleBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);

            if (ogrenciUcreti.Text=="" || tamUcreti.Text=="")
            {
                MessageBox.Show("Lütfen ücretleri giriniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("update Ucret_Tablo set OgrenciUcreti='" + ogrenciUcreti.Text + "' , TamUcreti='" + tamUcreti.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ücretleri başarıyla güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ogrenciUcreti.Text = "";
                    tamUcreti.Text = "";
                }
                    catch (Exception ex)
                {
                    MessageBox.Show("Sayı olarak giriniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
