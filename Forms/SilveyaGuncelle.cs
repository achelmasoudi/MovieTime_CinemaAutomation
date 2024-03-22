using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTime.Forms
{
    public partial class SilveyaGuncelle : Form
    {
        public SilveyaGuncelle()
        {
            InitializeComponent();
        }

        private void filmSilGuncelleBtn_Click(object sender, EventArgs e)
        {
            FilmSilGuncelle filmSilGuncelle = new FilmSilGuncelle();
            filmSilGuncelle.ShowDialog();
        }

        private void salonSilGuncelleBtn_Click(object sender, EventArgs e)
        {
            SalonSilGuncelle salonSilGuncelle = new SalonSilGuncelle();
            salonSilGuncelle.ShowDialog();
        }

        private void ucretGuncelleBtn_Click(object sender, EventArgs e)
        {
            UcretGuncelle ucretGuncelle = new UcretGuncelle();
            ucretGuncelle.ShowDialog();
        }
    }
}
