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
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MovieTime.Forms
{
    public partial class SeansEkle : Form
    {

        SqlCommand cmd;
        SqlDataReader dr;

        public SeansEkle()
        {
            InitializeComponent();
        }

        //Seans hakkinda
        string seans = "";
        private void radioBtnSecme()
        {
            if (_10_15_seansRadioBtn.Checked == true) seans = _10_15_seansRadioBtn.Text;
            else if (_13_00_seansRadioBtn.Checked == true) seans = _13_00_seansRadioBtn.Text;
            else if (_16_45_seansRadioBtn.Checked == true) seans = _16_45_seansRadioBtn.Text;
            else if (_18_15_seansRadioBtn.Checked == true) seans = _18_15_seansRadioBtn.Text;
            else if (_19_00_seansRadioBtn.Checked == true) seans = _19_00_seansRadioBtn.Text;
            else if (_20_45_seansRadioBtn.Checked == true) seans = _20_45_seansRadioBtn.Text;
            else if (_22_15_seansRadioBtn.Checked == true) seans = _22_15_seansRadioBtn.Text;
            else if (_23_45_seansRadioBtn.Checked == true) seans = _23_45_seansRadioBtn.Text;
        }


        //Veri tabanina (Seans Bilgiler) veri eklemek
        private void filmEkleBtn_Click(object sender, EventArgs e)
        {
            string filmAdi = filmAdiComB.Text;
            string salonAdi = salonAdiComB.Text;
            string tarih = filmTarihiDateTimeP.Text;

            //Seans Secme
            radioBtnSecme();
            if (seans != "")
            {
                SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
                try
                {
                    string insertCommand = "Insert into SeansBil_Tablo (FilmAdi, SalonAdi, Tarih, Seans) values ('" + filmAdi + "','" + salonAdi + "','" + tarih + "','" + seans + "')";
                    cmd = new SqlCommand(insertCommand, con);
                    con.Open();
                    //add query 
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Seans ekleme işleme yapıldı !", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bu salon bu saatte daha once secmissiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else if (seans != "")
            {
                MessageBox.Show("Seans seçimi yapınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //radio btnlar normala geri (unchecked) cevirmek icin
            _10_15_seansRadioBtn.Checked = false;
            _13_00_seansRadioBtn.Checked = false;
            _16_45_seansRadioBtn.Checked = false;
            _18_15_seansRadioBtn.Checked = false;
            _19_00_seansRadioBtn.Checked = false;
            _20_45_seansRadioBtn.Checked = false;
            _22_15_seansRadioBtn.Checked = false;
            _23_45_seansRadioBtn.Checked = false;

            //clear the text boxes and picture box
            filmAdiComB.SelectedItem = null;
            salonAdiComB.SelectedItem = null;
            filmTarihiDateTimeP.Text = DateTime.Now.ToShortDateString();
        }


        //Form Acildigi zaman film ve salon bizim Comboxlara geliyor
        private void SeansEkle_Load(object sender, EventArgs e)
        {
            FilmVeSalonGetir(filmAdiComB, "select * from Film_Bilgileri", "FilmAdi");
            FilmVeSalonGetir(salonAdiComB, "select * from SalonBil_Tablo", "SalonAdi");
        }

        private void FilmVeSalonGetir(Guna2ComboBox comboBox, string sql, string columnAdi)
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
            try
            {

                con.Open();
                cmd = new SqlCommand(sql, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //ComboBox
                    comboBox.Items.Add(dr[columnAdi].ToString());
                }

            }
            catch (Exception ex)
            {
                con.Close();
            }

        }

        private void filmTarihiDateTimeP_ValueChanged(object sender, EventArgs e)
        {

            foreach (Control itm in groupBoxSeans.Controls)
            {
                itm.Enabled = true;
                itm.Visible = true;
            }

            if (DateTime.Parse(DateTime.Now.ToShortDateString()) == DateTime.Parse(filmTarihiDateTimeP.Text))
            {
                foreach (Control itm2 in groupBoxSeans.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(itm2.Text))
                    {
                        itm2.Visible = false;
                    }
                }

                KarsilastirmaTarih();
            }

            else if (DateTime.Parse(DateTime.Now.ToShortDateString()) < DateTime.Parse(filmTarihiDateTimeP.Text))
            {
                KarsilastirmaTarih();
            }
            else if (DateTime.Parse(DateTime.Now.ToShortDateString()) > DateTime.Parse(filmTarihiDateTimeP.Text))
            {
                MessageBox.Show("Geriye donus islem yapilmaz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filmTarihiDateTimeP.Text = DateTime.Now.ToShortDateString();
            }
        }

        //Tarih Karsilastirma
        private void KarsilastirmaTarih()
        {

            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from SeansBil_Tablo where SalonAdi='" + salonAdiComB.Text + "' and Tarih='" + filmTarihiDateTimeP.Text + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    foreach (Control itm3 in groupBoxSeans.Controls)
                    {
                        if (dr["Seans"].ToString() == itm3.Text)
                        {
                            itm3.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void salonAdiComB_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (Control itm in groupBoxSeans.Controls)
            {
                itm.Enabled = true;
                itm.Visible = true;
            }

            if (DateTime.Parse(DateTime.Now.ToShortDateString()) == DateTime.Parse(filmTarihiDateTimeP.Text))
            {
                foreach (Control itm2 in groupBoxSeans.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(itm2.Text))
                    {
                        itm2.Visible = false;
                    }
                }

                KarsilastirmaTarih();
            }

            else if (DateTime.Parse(DateTime.Now.ToShortDateString()) < DateTime.Parse(filmTarihiDateTimeP.Text))
            {
                KarsilastirmaTarih();
            }
            else if (DateTime.Parse(DateTime.Now.ToShortDateString()) > DateTime.Parse(filmTarihiDateTimeP.Text))
            {
                MessageBox.Show("Geriye donus islem yapilmaz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filmTarihiDateTimeP.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void filmAdiComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            KarsilastirmaTarih();
        }
    }

}
