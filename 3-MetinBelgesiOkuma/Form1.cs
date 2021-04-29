using System;
using System.IO;
using System.Windows.Forms;

namespace _3_MetinBelgesiOkuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string satir = sr.ReadLine();
                while (satir!=null)
                {
                    listBox1.Items.Add(satir);
                    satir = sr.ReadLine();
                }
            }
        }
    }
}
