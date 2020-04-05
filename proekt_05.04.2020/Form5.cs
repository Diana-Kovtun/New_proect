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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox3.BackColor = Color.FromArgb(0, 0, 0, 0);
            if (Form3.ochki1>Form3.ochki2&& Form3.ochki1 > Form3.ochki3&& Form3.ochki1 > Form3.ochki4&& Form3.ochki1 > Form3.ochki5)
            {
                label2.Text = Form3.name1;
            }
            if (Form3.ochki2 > Form3.ochki1 && Form3.ochki2 > Form3.ochki3 && Form3.ochki2 > Form3.ochki4 && Form3.ochki2 > Form3.ochki5)
            {
                label2.Text = Form3.name2;
            }
            if (Form3.ochki3 > Form3.ochki1 && Form3.ochki3 > Form3.ochki2 && Form3.ochki2 > Form3.ochki4 && Form3.ochki3 > Form3.ochki5)
            {
                label2.Text = Form3.name3;
            }
            if (Form3.ochki4 > Form3.ochki1 && Form3.ochki4 > Form3.ochki2 && Form3.ochki4 > Form3.ochki3 && Form3.ochki4 > Form3.ochki5)
            {
                label2.Text = Form3.name4;
            }
            if (Form3.ochki5 > Form3.ochki1 && Form3.ochki5 > Form3.ochki2 && Form3.ochki5 > Form3.ochki3 && Form3.ochki5 > Form3.ochki4)
            {
                label2.Text = Form3.name5;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
