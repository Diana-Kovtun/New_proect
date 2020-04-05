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
    public partial class Form2 : Form
    {
        public Form2(String temp)
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            switch (temp)
            {
                case "2":
                    {
                        textBox3.Hide();   
                        label3.Hide();
                        textBox4.Hide();
                        label4.Hide();
                        textBox5.Hide();
                        label5.Hide();
                        break;
                    }
                case "3":
                    {
                        textBox4.Hide();
                        label4.Hide();
                        textBox5.Hide();
                        label5.Hide();
                      
                        break;

                    }
                case "4":
                    {
                        textBox5.Hide();
                        label5.Hide();
                       
                        break;
                    }
                case "5":
                    {
                      
                        break;
                    }
         

            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Вы не ввели имя, попробуйте ещё раз");
            }
            else
            {
                Form3 d = new Form3(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                this.Hide();
                d.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
