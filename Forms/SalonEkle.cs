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
    public partial class SalonEkle : Form
    {
        

        public SalonEkle()
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

        private void filmEkleBtn_Click(object sender, EventArgs e)
        {
            string salonAdi = salonAdiTxtB.Text;  
            try
            {
                SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);

                    con.Open();
                    string command = "Insert into SalonBil_Tablo (SalonAdi) values ('" + salonAdi + "')";
                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Salon eklendi !", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                salonAdiTxtB.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aynı salonu daha önce eklediniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
