using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasled
{
    public partial class Form1 : Form
    {
        List<Drinks> drinksiList = new List<Drinks>();
        public Form1()
        {
            InitializeComponent();
            button1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Clear();
            this.drinksiList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 20; ++i)
            {
                switch(rnd.Next() %3)
                {
                    case 0:
                        this.drinksiList.Add(Alco.Generator());
                        break;
                    case 1: 
                        this.drinksiList.Add(Juice.Generator());
                        break;
                    case 2: 
                        this.drinksiList.Add(Soda.Generator());
                        break;
                       
                }
                
            }
            ShowInfo();
        }
        private void ShowInfo()
        {
            int juiceCount = 0; 
            int sodaCount = 0;   
            int alcoCount = 0;  

            foreach(var napitki in this.drinksiList)
            {
                if(napitki is Alco)
                {
                    alcoCount+= 1;
                    richTextBox3.Text += "Алкоголь\n";
                   
                }
                else if(napitki is Juice)
                {
                    juiceCount += 1;
                    richTextBox3.Text += "Сок\n";

                }
                else if (napitki is Soda)
                {
                    sodaCount += 1;
                    richTextBox3.Text += "Газировка\n";

                }
            }
            richTextBox1.Text += "Алкоголь\tСок\tГазировка";
            richTextBox1.Text += "\n";
            richTextBox1.Text += String.Format("{0}\t\t{1}\t\t{2}",alcoCount, juiceCount, sodaCount);
           
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            richTextBox1.Clear();
            richTextBox3.Clear();
            if (this.drinksiList.Count == 0)
            {
                richTextBox2.Text = "В автомате ничего не осталось((((";
                return;
            }

            
            var napitki = this.drinksiList[0];
            this.drinksiList.RemoveAt(0);


            richTextBox2.Text = napitki.GetInfo();

            ShowInfo();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void условиеЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Придумать иерархию классов.\n\nДолжен быть 1 базовый класс, и 3 класса наследника.У базового класса должно быть, как минимум одно свойство передающиеся по наследству остальным, у каждого из классов наследников должно быть как минимум два уникальных свойства.\n\nРеализовать эмулятор торгового автомата НАПИТКОВ!");
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
