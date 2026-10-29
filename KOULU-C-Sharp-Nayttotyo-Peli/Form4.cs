using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace KOULU_C_Sharp_Nayttotyo_Peli
{
    public partial class Form4 : Form
    {
        public int Gold;
        public int XP;
        public int PlayerHP = 100;
        public int EnemyHP = 150;
        string[] EnemyNames = { "Boney", "Orchid", "Xarth", "Frank", "Bunt", "Bonk", "Hallow", "Executioner", "Holdow", "Willow", "Black Spot", "Krita", "Barler" };
        string[] MonsterTypes = { "Skeleton", "Zombie", "Goblin", "Crawler", "Orc" };

        Random randy = new Random();

        public Form4()
        {
            InitializeComponent();
        }

        // Päivitä inventoori kun Form4 avataan
        private void Form4_Load(object sender, EventArgs e)
        {
            string EnemyName = EnemyNames[randy.Next(EnemyNames.Length)];
            label1.Text = $"Name: {EnemyName}";
            UpdateInventory();
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
            label6.Text = $"XP: {XP}";
            label2.Text = $"HP: {EnemyHP}";
            label3.Text = $"HP: {PlayerHP}";

            if (PlayerHP <= 0)
            {
                MessageBox.Show("Game Over! The enemy slained you with critical damage!");
                Application.Restart();
            }

            if (XP >= 100)
            {
                MessageBox.Show("Level Up! You feel power draining down your veins as you power up!");
                XP -= 100;
                PlayerHP += 20;
            }
        }

        // Käytä itemi
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);

            UpdateInventory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerHP -= 10;
            EnemyHP -= 20;

            if (EnemyHP <= 0)
            {
                MessageBox.Show("Battle Won! Enemy was defeated with brutal force.");
                Gold += randy.Next(50, 141);
                XP += randy.Next(20, 81);
                EnemyHP = randy.Next(100, 241);

                string EnemyName = EnemyNames[randy.Next(EnemyNames.Length)];
                label1.Text = $"Name: {EnemyName}";

                string MonsterType = MonsterTypes[randy.Next(MonsterTypes.Length)];
                label7.Text = $"{MonsterType}";
            }

            UpdateInventory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayerHP -= 2;
            UpdateInventory();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
            f1.Gold = Gold;
        }
    }
}
