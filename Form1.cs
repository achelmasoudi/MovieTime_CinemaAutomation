using Guna.UI2.WinForms;
using MovieTime.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTime
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        private Guna2Button currentBtn;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.offPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            Form childForm = new Forms.AnaSayfa();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.offPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

            //Selected Home Button
            Bitmap selectedIconHome = Properties.Resources.selectedHome;
            HomeBtn.ForeColor = Color.White;
            HomeBtn.Image = selectedIconHome;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Programı kapatmak istediğinize emin misiniz? ?", "Silmek", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            sideBar.Height = HomeBtn.Height;
            sideBar.Top = HomeBtn.Top;

            //Selected Home Button
            Bitmap selectedIconHome = Properties.Resources.selectedHome;
            HomeBtn.ForeColor = Color.White;
            HomeBtn.Image = selectedIconHome;

            //UnSelected Buttons
            Bitmap unSelectedIconAddMovie = Properties.Resources.unselectedAddMovie;
            filmEkleBtn.ForeColor = Color.LightGray;
            filmEkleBtn.Image = unSelectedIconAddMovie;
            Bitmap unSelectedIconSeansEkle = Properties.Resources.unselectedSeansEkle;
            seansEkleBtn.ForeColor = Color.LightGray;
            seansEkleBtn.Image = unSelectedIconSeansEkle;
            Bitmap unSelectedIconBiletSat = Properties.Resources.unselectedBilet;
            biletSatBtn.ForeColor = Color.LightGray;
            biletSatBtn.Image = unSelectedIconBiletSat;
            Bitmap unSelectedIconSatisListeleme = Properties.Resources.unselectedSatisListeleme;
            satisListelemeBtn.ForeColor = Color.LightGray;
            satisListelemeBtn.Image = unSelectedIconSatisListeleme;
            Bitmap unSelectedIconSilGuncelle = Properties.Resources.unselectedDeleteMovie;
            SilGuncelleBtn.ForeColor = Color.LightGray;
            SilGuncelleBtn.Image = unSelectedIconSilGuncelle;

            OpenChildForm(new Forms.AnaSayfa(), sender);
        }

        private void filmEkleBtn_Click(object sender, EventArgs e)
        {
            sideBar.Height = filmEkleBtn.Height;
            sideBar.Top = filmEkleBtn.Top;

            //Selected Add Movie Button
            Bitmap selectedIconAddMovie = Properties.Resources.selectedAddMovie;
            filmEkleBtn.ForeColor = Color.White;
            filmEkleBtn.Image = selectedIconAddMovie;

            //UnSelected Buttons
            Bitmap unSelectedIconHome = Properties.Resources.unselectedHome;
            HomeBtn.ForeColor = Color.LightGray;
            HomeBtn.Image = unSelectedIconHome;
            Bitmap unSelectedIconSeansEkle = Properties.Resources.unselectedSeansEkle;
            seansEkleBtn.ForeColor = Color.LightGray;
            seansEkleBtn.Image = unSelectedIconSeansEkle;
            Bitmap unSelectedIconBiletSat = Properties.Resources.unselectedBilet;
            biletSatBtn.ForeColor = Color.LightGray;
            biletSatBtn.Image = unSelectedIconBiletSat;
            Bitmap unSelectedIconSatisListeleme = Properties.Resources.unselectedSatisListeleme;
            satisListelemeBtn.ForeColor = Color.LightGray;
            satisListelemeBtn.Image = unSelectedIconSatisListeleme;
            Bitmap unSelectedIconSilGuncelle = Properties.Resources.unselectedDeleteMovie;
            SilGuncelleBtn.ForeColor = Color.LightGray;
            SilGuncelleBtn.Image = unSelectedIconSilGuncelle;

            OpenChildForm(new Forms.FilmEkle(), sender);
        }

        private void seansEkleBtn_Click(object sender, EventArgs e)
        {
            sideBar.Height = seansEkleBtn.Height;
            sideBar.Top = seansEkleBtn.Top;

            //Selected Add Movie Button
            Bitmap selectedIconSeansEkle = Properties.Resources.selectedSeansEkle;
            seansEkleBtn.ForeColor = Color.White;
            seansEkleBtn.Image = selectedIconSeansEkle;

            //UnSelected Buttons
            Bitmap unSelectedIconHome = Properties.Resources.unselectedHome;
            HomeBtn.ForeColor = Color.LightGray;
            HomeBtn.Image = unSelectedIconHome;
            Bitmap unSelectedIconAddMovie = Properties.Resources.unselectedAddMovie;
            filmEkleBtn.ForeColor = Color.LightGray;
            filmEkleBtn.Image = unSelectedIconAddMovie;
            Bitmap unSelectedIconBiletSat = Properties.Resources.unselectedBilet;
            biletSatBtn.ForeColor = Color.LightGray;
            biletSatBtn.Image = unSelectedIconBiletSat;
            Bitmap unSelectedIconSatisListeleme = Properties.Resources.unselectedSatisListeleme;
            satisListelemeBtn.ForeColor = Color.LightGray;
            satisListelemeBtn.Image = unSelectedIconSatisListeleme;
            Bitmap unSelectedIconSilGuncelle = Properties.Resources.unselectedDeleteMovie;
            SilGuncelleBtn.ForeColor = Color.LightGray;
            SilGuncelleBtn.Image = unSelectedIconSilGuncelle;

            OpenChildForm(new SeansEkle(), sender);
        }

        private void biletSatBtn_Click(object sender, EventArgs e)
        {
            sideBar.Height = biletSatBtn.Height;
            sideBar.Top = biletSatBtn.Top;

            //Selected Bilet Sat Button
            Bitmap selectedIconBiletSat = Properties.Resources.selectedBilet;
            biletSatBtn.ForeColor = Color.White;
            biletSatBtn.Image = selectedIconBiletSat;

            //UnSelected Buttons
            Bitmap unSelectedIconHome = Properties.Resources.unselectedHome;
            HomeBtn.ForeColor = Color.LightGray;
            HomeBtn.Image = unSelectedIconHome;
            Bitmap unSelectedIconSeansEkle = Properties.Resources.unselectedSeansEkle;
            seansEkleBtn.ForeColor = Color.LightGray;
            seansEkleBtn.Image = unSelectedIconSeansEkle;
            Bitmap unSelectedIconAddMovie = Properties.Resources.unselectedAddMovie;
            filmEkleBtn.ForeColor = Color.LightGray;
            filmEkleBtn.Image = unSelectedIconAddMovie;
            Bitmap unSelectedIconSatisListeleme = Properties.Resources.unselectedSatisListeleme;
            satisListelemeBtn.ForeColor = Color.LightGray;
            satisListelemeBtn.Image = unSelectedIconSatisListeleme;
            Bitmap unSelectedIconSilGuncelle = Properties.Resources.unselectedDeleteMovie;
            SilGuncelleBtn.ForeColor = Color.LightGray;
            SilGuncelleBtn.Image = unSelectedIconSilGuncelle;

            OpenChildForm(new Forms.BiletSat(), sender);

        }

        private void satisListelemeBtn_Click(object sender, EventArgs e)
        {
            sideBar.Height = satisListelemeBtn.Height;
            sideBar.Top = satisListelemeBtn.Top;

            //Selected SatisListeleme Button
            Bitmap selectedIconSatisListeleme = Properties.Resources.selectedSatisListeleme;
            satisListelemeBtn.ForeColor = Color.White;
            satisListelemeBtn.Image = selectedIconSatisListeleme;

            //UnSelected Buttons
            Bitmap unSelectedIconHome = Properties.Resources.unselectedHome;
            HomeBtn.ForeColor = Color.LightGray;
            HomeBtn.Image = unSelectedIconHome;
            Bitmap unSelectedIconSeansEkle = Properties.Resources.unselectedSeansEkle;
            seansEkleBtn.ForeColor = Color.LightGray;
            seansEkleBtn.Image = unSelectedIconSeansEkle;
            Bitmap unSelectedIconAddMovie = Properties.Resources.unselectedAddMovie;
            filmEkleBtn.ForeColor = Color.LightGray;
            filmEkleBtn.Image = unSelectedIconAddMovie;
            Bitmap unSelectedIconBiletSat = Properties.Resources.unselectedBilet;
            biletSatBtn.ForeColor = Color.LightGray;
            biletSatBtn.Image = unSelectedIconBiletSat;
            Bitmap unSelectedIconSilGuncelle = Properties.Resources.unselectedDeleteMovie;
            SilGuncelleBtn.ForeColor = Color.LightGray;
            SilGuncelleBtn.Image = unSelectedIconSilGuncelle;

            OpenChildForm(new SatisListeleme(), sender);
        }

        private void filmSilGuncelleBtn_Click(object sender, EventArgs e)
        {
            sideBar.Height = SilGuncelleBtn.Height;
            sideBar.Top = SilGuncelleBtn.Top;

            //Selected FilmSilGuncelle Button
            Bitmap selectedIconSilGuncelle = Properties.Resources.selectedDeleteMovie;
            SilGuncelleBtn.ForeColor = Color.White;
            SilGuncelleBtn.Image = selectedIconSilGuncelle;


            //UnSelected Buttons
            Bitmap unSelectedIconHome = Properties.Resources.unselectedHome;
            HomeBtn.ForeColor = Color.LightGray;
            HomeBtn.Image = unSelectedIconHome;
            Bitmap unSelectedIconSatisListeleme = Properties.Resources.unselectedSatisListeleme;
            satisListelemeBtn.ForeColor = Color.LightGray;
            satisListelemeBtn.Image = unSelectedIconSatisListeleme;
            Bitmap unSelectedIconSeansEkle = Properties.Resources.unselectedSeansEkle;
            seansEkleBtn.ForeColor = Color.LightGray;
            seansEkleBtn.Image = unSelectedIconSeansEkle;
            Bitmap unSelectedIconAddMovie = Properties.Resources.unselectedAddMovie;
            filmEkleBtn.ForeColor = Color.LightGray;
            filmEkleBtn.Image = unSelectedIconAddMovie;
            Bitmap unSelectedIconBiletSat = Properties.Resources.unselectedBilet;
            biletSatBtn.ForeColor = Color.LightGray;
            biletSatBtn.Image = unSelectedIconBiletSat;

            OpenChildForm(new SilveyaGuncelle(), sender);
        }
    }
}
