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
    public partial class FilmEkle : Form
    {      
        public FilmEkle()
        {
            InitializeComponent();
            filmPosteriPicB.Visible = false;

        }

        private void posterSecBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " Image File | *.JPG; *.PNG *.GIF";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                filmPosteriPicB.Visible = true;
                filmPosteriPicB.ImageLocation = openFileDialog1.FileName.ToString();
            }
            
        }

        private void filmEkleBtn_Click(object sender, EventArgs e)
        {
            string filmAdi = filmAdiTxtB.Text;
            string yonetmen = yonetmenTxtB.Text;
            string filmKategorisi = filmKategorisiComB.Text;
            string filmSuresi = filmSuresiTxtB.Text;
            string filmDili = filmDiliComB.Text;

            if(filmPosteriPicB.Image != null)
            {
                if (!filmAdi.Equals(""))
                {
                    if (!yonetmen.Equals(""))
                    {
                        if (!filmKategorisi.Equals(""))
                        {
                            if (!filmSuresi.Equals(""))
                            {
                                if (!filmDili.Equals(""))
                                {
                                    SqlConnection con = new SqlConnection(ConnectDB.sqlConnection);

                                    try
                                    {

                                        
                                            con.Open();
                                            string command = "Insert into Film_Bilgileri (FilmAdi , Yonetmen , FilmKategorisi , FilmSuresi , FilmDili , Resim) values ('" +filmAdi+ "','"+ yonetmen + "','"+ filmKategorisi+ "','"+ filmSuresi + "','"+filmDili +"','"+ filmPosteriPicB.ImageLocation + "')";
                                            SqlCommand cmd = new SqlCommand(command , con);
                                            cmd.ExecuteNonQuery();
                                        
                                        MessageBox.Show("Film bilgileri eklendi !", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        //clear the text boxes and picture box
                                        filmAdiTxtB.Clear();
                                        yonetmenTxtB.Clear();
                                        filmSuresiTxtB.Clear();
                                        filmPosteriPicB.Visible = false;
                                        filmKategorisiComB.SelectedItem = null;
                                        filmDiliComB.SelectedItem = null;

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Bu film daha önce eklendi !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    finally
                                    {
                                        con.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Film'in dilini seçiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Film'in süresini seçiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Film'in kategorisini seçiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yönetmen adını giriniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Film'in adını giriniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Film'in pösterini seçiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salonEkleBtn_Click(object sender, EventArgs e)
        {
            SalonEkle salonEkle = new SalonEkle();
            salonEkle.ShowDialog();
        }
    }
}
