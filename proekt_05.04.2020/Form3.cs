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
    public partial class Form3 : Form
    {
        
        public static int ochki1 = 0;
        public static int correctanswers1 = 0;
        public static int ochki2 = 0;
        public static int correctanswers2 = 0;
        public static int ochki3 = 0;
        public static int correctanswers3 = 0;
        public static int ochki4 = 0;
        public static int correctanswers4 = 0;
        public static int ochki5 = 0;
        public static int correctanswers5 = 0;
        public static String name1;
        public static String name2;
        public static String name3;
        public static String name4;
        public static String name5;
        public static int I = 0;
        int[] Kolvo = new int[I];
        public Form3(string temp, string temp1, string temp2, string temp3, string temp4)
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            label8.BackColor = Color.FromArgb(0, 0, 0, 0);
            label9.BackColor = Color.FromArgb(0, 0, 0, 0);
            label10.BackColor = Color.FromArgb(0, 0, 0, 0);
            label11.BackColor = Color.FromArgb(0, 0, 0, 0);
            label12.BackColor = Color.FromArgb(0, 0, 0, 0);
            label13.BackColor = Color.FromArgb(0, 0, 0, 0);
            label14.BackColor = Color.FromArgb(0, 0, 0, 0);
            label15.BackColor = Color.FromArgb(0, 0, 0, 0);
            label16.BackColor = Color.FromArgb(0, 0, 0, 0);
            label17.BackColor = Color.FromArgb(0, 0, 0, 0);
            label18.BackColor = Color.FromArgb(0, 0, 0, 0);
            label19.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label19.Hide();
            label1.Text = temp;
            label2.Text = temp1;
            label3.Text = temp2;
            label4.Text = temp3;
            label5.Text = temp4;
            Form3.name1 = label1.Text;
            Form3.name2 = label2.Text;
            Form3.name3 = label3.Text;
            Form3.name4 = label4.Text;
            Form3.name5 = label5.Text;
          


            if (temp2 == "")
            {
             label13.Hide();
             label3.Hide();
             label14.Hide();
             label4.Hide();
             label15.Hide();
             label16.Hide();
             label17.Hide();
             label5.Hide();
             label18.Hide();
           
             }
            
            if(temp3=="") 
            {
            label5.Hide();
            label17.Hide();
            label18.Hide();
            label4.Hide();
            label15.Hide();
            label16.Hide();

            }
           
            if(temp4 =="")
            {
            label5.Hide();
            label17.Hide();
            label18.Hide();
            
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 7);
            label19.Text = a.ToString();
            Form4 c = new Form4(label19.Text,label1.Text, label2.Text, label3.Text, label4.Text, label5.Text);
            c.ShowDialog();
            label9.Text = ochki1.ToString();
            label10.Text = correctanswers1.ToString();
            label11.Text = ochki2.ToString();
            label12.Text = correctanswers2.ToString();
            label13.Text = ochki3.ToString();
            label14.Text = correctanswers3.ToString();
            label15.Text = ochki4.ToString();
            label16.Text = correctanswers4.ToString();
            label17.Text = ochki5.ToString();
            label18.Text = correctanswers5.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
