using System;
using System.Windows.Forms;
using System.IO;

namespace _4_MetinBelgesineVeriKaydetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyalar|*.txt";
            saveFileDialog1.Title = "Metin Belgesi Kayit";
            saveFileDialog1.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            MessageBox.Show("Belge Olusturuldu");
        }
    }
}
