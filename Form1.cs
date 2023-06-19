using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace TcNoDogrulama
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (TbTc.Text != "" && TbName.Text != "" && TbSurname.Text != "")
            {
                long TcNo = long.Parse(TbTc.Text);
                string ad = TbName.Text;
                string soyad = TbSurname.Text;
                int DYıl = dateTimePicker1.Value.Year;

                KimlkBilgileri.KPSPublicSoapClient kk = new KimlkBilgileri.KPSPublicSoapClient();
                bool sonuc = kk.TCKimlikNoDogrula(TcNo, ad, soyad, DYıl);
                if (sonuc)
                {
                    MessageBox.Show("Girilen Kimlik Bilgileri Doğrulandı !", "Geçerli Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Girilen Bilgiler Yanlış !", "Geçersiz Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun", "Geçersiz Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
