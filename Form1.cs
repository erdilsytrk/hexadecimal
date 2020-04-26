using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "{0:X}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            textBox1.Clear();
            string okunacak = textBox2.Text;
            string hexformat = comboBox1.Text;
            foreach (string line in File.ReadLines(okunacak))
            {
                if (line != null) { textBox1.AppendText(line.ToString()); }
            }
            string str = textBox1.Text;
            char[] charValues = str.ToCharArray();
            string hexOutput = "";
            foreach (char _eachChar in charValues)
            {
                int value31 = Convert.ToInt32(_eachChar);
                hexOutput += String.Format(hexformat, value31);
            }
            textBox1.Text = hexOutput;
            }
            catch
            {
                MessageBox.Show("Kaynak dosyasını seçmediniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            textBox2.Text = file.FileName;
        }

        
    }
}
