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
    public partial class Form1 : Form
    {
        public int Gold = 100;
        public int XP = 0;

        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        // Nappi kaivokseen
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Gold = Gold;
            f3.Show();
            f3.UpdateInventory();
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Päivitä inventoori kun Form1 avataan
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateInventory();
        }

        // Nappi kauppaan
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Gold = Gold;
            f2.Show();
            f2.UpdateInventory();
            Visible = false;
        }

        // Nappi taisteluun
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Gold = Gold;
            f4.Show();
            f4.UpdateInventory();
            Visible = false;
        }

        // Päivitä inventoori
        private void UpdateInventory()
        {
            listBox1.Items.Clear();

            foreach (string item in Inventory.Items)
            {
                listBox1.Items.Add(item);
            }

            label5.Text = $"Gold: {Gold}";
            label6.Text = $"XP: {XP}";
        }
    }
}
