using System;
using System.IO;
using System.Windows.Forms;

namespace _2_MetinBelgesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaAdi, dosyaYolu;
        StreamWriter sw;

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            dosyaAdi = txtDosyaAdi.Text;
            sw = File.CreateText(dosyaYolu + "\\" + dosyaAdi + ".txt");
            sw.Close();
        }

        private void btnYolSec_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                dosyaYolu = folderBrowserDialog1.SelectedPath.ToString();
                txtDosyaYolu.Text = dosyaYolu;
            }
        }
    }
}
