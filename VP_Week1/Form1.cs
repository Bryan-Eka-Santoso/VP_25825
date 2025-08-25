using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Week1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            MessageBox.Show("Test");
            DialogResult hasil = MessageBox.Show(textBox1.Text, "Apakah kamu yakin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(hasil == DialogResult.Yes) {
                MessageBox.Show("Benar");
            } else
            {
                MessageBox.Show("Salah");
            }   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
