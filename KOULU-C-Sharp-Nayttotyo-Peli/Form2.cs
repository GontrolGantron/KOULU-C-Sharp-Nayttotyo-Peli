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
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public int Gold;
        public int XP;

        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateInventory();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        public void UpdateInventory()
        {
            listBox1.Items.Clear();

            foreach (string item in Inventory.Items)
            {
                listBox1.Items.Add(item);
            }
            label5.Text = $"Gold: {Gold}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventory.Items.Add("Health Potion x1");
            UpdateInventory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventory.Items.Add("Power Potion x1");
            UpdateInventory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inventory.Items.Add("Chaos Potion x1");
            UpdateInventory();
        }
    }
}
