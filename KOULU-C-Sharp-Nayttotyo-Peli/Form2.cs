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

        // Päivitä inventoori kun Form2 avataan
        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateInventory();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        // Nappi kotiin
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            f1.Gold = Gold;
        }

        // Päivitä inventoori
        public void UpdateInventory()
        {
            listBox1.Items.Clear();

            foreach (string item in Inventory.Items)
            {
                listBox1.Items.Add(item);
            }
            label5.Text = $"Gold: {Gold}";
        }
        
        // Health Potion nappi
        private void button1_Click(object sender, EventArgs e)
        {
            if (Gold >= 80) {
                Inventory.Items.Add("Health Potion x1");
                Gold -= 80;
                UpdateInventory();
            }
        }

        // Power Potion nappi
        private void button2_Click(object sender, EventArgs e)
        {
            if (Gold >= 100) {
                Inventory.Items.Add("Power Potion x1");
                Gold -= 100;
                UpdateInventory();
            }
        }

        // Chaos Potion nappi
        private void button3_Click(object sender, EventArgs e)
        {
            if (Gold >= 120) {
                Inventory.Items.Add("Chaos Potion x1");
                Gold -= 120;
                UpdateInventory();
            }
        }
    }
}
