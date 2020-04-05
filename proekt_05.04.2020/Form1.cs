using System;   
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt_05._04._2020
{
    public partial class Form1 : Form
    {
        public static string kolvo;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {  
            kolvo = textBox1.Text;
            if (kolvo == "2" || kolvo == "3" || kolvo == "4" || kolvo == "5")
            {
                Form2 f = new Form2(kolvo);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            if(kolvo == "")
            {
                MessageBox.Show("Вы не ввели количество игроков");
            }
            else
            {
                MessageBox.Show("Количество игроков должно быть от 2 до 5, попробуйте ещё раз");
            }
           
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
