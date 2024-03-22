using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace MovieTime.Forms
{
    public partial class BiletSat : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public BiletSat()
        {
            InitializeComponent();
        }


        private void BiletSat_Load(object sender, EventArgs e)
        {
            //Film Adi ve Salon Adi Veri tabanidan getirecegiz
            FilmVeSalonGetir(filmComB, "select * from Film_Bilgileri", "FilmAdi");
            FilmVeSalonGetir(salonComB, "select * from SalonBil_Tablo", "SalonAdi");

            //Koltuklar Koyma
            BosKoltuklarKoyma();

        }

        int sayac = 0;
        private void BosKoltuklarKoyma()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(28, 28);
                    btn.BackColor = Color.FromArgb(87, 33, 182);

                    btn.FlatStyle = FlatStyle.Flat;


                    btn.Location = new Point(j * 32 + 27, i * 35 + 10);
                    btn.Name = "Koltuk_" + sayac;
                    btn.Text = sayac.ToString();
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Aladin", 6 , FontStyle.Regular);

                    if (j == 7)
                    {
                        continue;
                    }
                    sayac++;
                    this.koltukPanel.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        //koltugu tikladigimizda koltuk text boxta degeri gosteriyor
        private void Btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (btn.BackColor == Color.FromArgb(87, 33, 182))
            {
                koltukNoTxtB.Text = btn.Name;

            }
            else if (btn.BackColor == Color.Red)
            {
                biletIptalKoltukNoTxtB.Text = btn.Name;
            }
        }

        private void DoluKoltuklar_DataBase()
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
            con.Open();

            string command = "select * from Satis_Bilgileri where FilmAdi='" + filmComB.SelectedItem + "' and SalonAdi='" + salonComB.Text + "' and Tarih='" + filmTarihiComB.SelectedItem + "' and Saat='" + filmSeansiComB.SelectedItem + "'";
            cmd = new SqlCommand(command, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                foreach (Control itm in koltukPanel.Controls)
                {
                
                    if (itm is Button)
                    {
                        if (dr["KoltukNo"].ToString() == itm.Name)
                        {
                            itm.BackColor = Color.Red;
                        }
                    }

                }
            }

        }

        private void YenidenRenklendir()
        {
            foreach (Control itm in koltukPanel.Controls)
            {
                if (itm is Button)
                {
                    itm.BackColor = Color.FromArgb(87, 33, 182);
                }
            }
        }

        private void DoluKoltuklar_ComBoBoxta_Goster()
        {
            biletIptalKoltukNoTxtB.Text = "";

            foreach (Control itm in koltukPanel.Controls)
            {
                if (itm is Button)
                {
                    if (itm.BackColor == Color.Red)
                    {
                        itm.BackColor = Color.Red;
                    }
                }
            }
        }

        //FilmVeSalonGetir
        private void FilmVeSalonGetir(Guna2ComboBox comboBox, string sql, string columnAdi)
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
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


        //FilmPosteriGoster
        private void FilmPosteriGoster()
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
                }
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }

        private void filmComB_SelectedIndexChanged(object sender, EventArgs e)
        {

            salonComB.Text = null;
            filmTarihiComB.Text = null;
            filmSeansiComB.Text = null;
            koltukNoTxtB.Text = "";
            ucretTxtB.Text = "";

            FilmPosteriGoster();

            YenidenRenklendir();
            DoluKoltuklar_ComBoBoxta_Goster();
        }

        private void biletSatBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);

            if (filmComB.Text!="")
            {
                if(salonComB.Text!="")
                {
                    if(filmTarihiComB.Text!="")
                    {
                        if(filmSeansiComB.Text!="")
                        {
                            if (koltukNoTxtB.Text != "")
                            {
                                if (AdSoyadTxtB.Text != "")
                                {
                                    if (tarifeComB.Text != "")
                                    {
                                        insertData();
                                        koltukNoTxtB.Text = "";
                                        
                                        tarifeComB.Text = null;
                                        AdSoyadTxtB.Text = "";
                                        ucretTxtB.Text = "";

                                        YenidenRenklendir();
                                        DoluKoltuklar_DataBase();
                                        DoluKoltuklar_ComBoBoxta_Goster();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Tarife seçiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Adı ve Soyadı girininiz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Koltuk seçimi yapınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Film'in Seansı seçimi yapınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Film'in Tarihi seçimi yapınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Salon seçimi yapınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Film'in seçimi yapınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void insertData()
        {
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
            try
            {
                con.Open();
                string command = "INSERT INTO Satis_Bilgileri (KoltukNo, SalonAdi, FilmAdi, Tarih, Tarife, Ad_Soyad, Ucret, SatisTarihi, Saat) VALUES('" + koltukNoTxtB.Text + "', '" + salonComB.Text + "', '" + filmComB.Text + "', '" + filmTarihiComB.Text + "', '" + tarifeComB.Text + "', '" + AdSoyadTxtB.Text + "', '" + ucretTxtB.Text + "', '" + DateTime.Now.ToString() + "', '" + filmSeansiComB.Text + "')";
                SqlCommand cmd = new SqlCommand(command, con);
                cmd.ExecuteNonQuery();



                string comman = "SELECT id, KoltukNo, SalonAdi, FilmAdi, Tarih, Tarife, Ad_Soyad, Ucret, SatisTarihi, Saat FROM Satis_Bilgileri WHERE(id = SCOPE_IDENTITY())";

                
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

        private void FilmTarihiGetir()
        {
            filmTarihiComB.Text = "";
            filmSeansiComB.Text = "";
            filmTarihiComB.Items.Clear();
            filmSeansiComB.Items.Clear();

            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from SeansBil_Tablo where FilmAdi='" + filmComB.SelectedItem + "' and SalonAdi='" + salonComB.SelectedItem + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (DateTime.Parse(dr["Tarih"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                    {
                        if (!filmTarihiComB.Items.Contains(dr["Tarih"].ToString()))
                            filmTarihiComB.Items.Add(dr["Tarih"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
            }

        }

        private void salonComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmTarihiGetir();
        }


        private void FilmSeansiGetir()
        {
            filmSeansiComB.Text = "";
            filmSeansiComB.Items.Clear();
            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from SeansBil_Tablo where FilmAdi='" + filmComB.SelectedItem + "' and SalonAdi='" + salonComB.SelectedItem + "' and Tarih='" + filmTarihiComB.SelectedItem + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (DateTime.Parse(dr["Tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                    {
                        if (DateTime.Parse(dr["Seans"].ToString()) > DateTime.Parse(DateTime.Now.ToShortTimeString()))
                            filmSeansiComB.Items.Add(dr["Seans"].ToString());
                    }
                    else if (DateTime.Parse(dr["Tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                    {
                        filmSeansiComB.Items.Add(dr["Seans"].ToString());
                    }
                } 
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }

        private void filmTarihiComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmSeansiGetir();
        }

        private void filmSeansiComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            YenidenRenklendir();
            DoluKoltuklar_DataBase();
            DoluKoltuklar_ComBoBoxta_Goster();
        }

        private void biletIptalBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Bileti iptal etmek istediğinize emin misiniz ?", "Iptal" , MessageBoxButtons.OKCancel , MessageBoxIcon.Question);

            if(dialog == DialogResult.OK)
            {
                if (biletIptalKoltukNoTxtB.Text != "")
                {
                    SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);

                    try
                    {
                        con.Open();

                        string command = "delete from Satis_Bilgileri where KoltukNo='" + biletIptalKoltukNoTxtB.Text + "' and SalonAdi='" + salonComB.Text + "' and FilmAdi='" + filmComB.Text + "' and Tarih='" + filmTarihiComB.Text + "' and Saat='" + filmSeansiComB.Text + "'";
                        SqlCommand cmd = new SqlCommand(command, con);
                        cmd.ExecuteNonQuery();


                        foreach (Control itm in koltukPanel.Controls)
                        {

                            if (itm is Button)
                            {
                                if (biletIptalKoltukNoTxtB.Text == itm.Name)
                                {
                                    itm.BackColor = Color.FromArgb(87, 33, 182);
                                }
                            }

                        }
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
                else
                    MessageBox.Show("Koltuk seçimi yapınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void tarifeComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucretTxtB.Text = "";

            SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Ucret_Tablo", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if(tarifeComB.SelectedItem == "Öğrenci")
                    {
                        ucretTxtB.Text = dr["OgrenciUcreti"].ToString();
                    }
                    else if (tarifeComB.SelectedItem == "Tam")
                    {
                        ucretTxtB.Text = dr["TamUcreti"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
            }
            
        }
    }
}
