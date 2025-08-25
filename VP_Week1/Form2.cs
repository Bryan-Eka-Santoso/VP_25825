using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Week1.Models;

namespace VP_Week1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        BindingList<barang> arrBarang;
        private void Form2_Load(object sender, EventArgs e)
        {
            arrBarang = new BindingList<barang>();

            listBox1.DataSource = arrBarang;
            //listBox1.DisplayMember="Name";
            listBox1.ValueMember = "Id";
        }
        private void txtHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            barang b = new barang(id, txtName.Text, txtDescription.Text, (int)numericUpDown1.Value);
            arrBarang.Add(b);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedValue.ToString());
        }
    }
}
