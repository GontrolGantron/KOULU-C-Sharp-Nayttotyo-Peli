using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOULU_C_Sharp_Nayttotyo_Peli
{
    public partial class Form4 : Form
    {
        public int Gold;
        public int XP;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            UpdateInventory();
        }

        public void UpdateInventory()
        {
            listBox1.Items.Clear();

            foreach (string item in Inventory.Items)
            {
                listBox1.Items.Add(item);
            }

            label5.Text = $"Gold: {Gold}";
            label6.Text = $"XP: {XP}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
