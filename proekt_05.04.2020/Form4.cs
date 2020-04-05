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
    public partial class Form4 : Form
    {
        public static int check;
        
        public static String[] Questions = new String[20] { "На каком остраве располагается столица Японии?", "Белый дом в США построен из:",
                "Национальное блюдо Ирака:", "В какой стране появился танец Полька?", "В какой стране впервые появилось метро?",
                "Знаменитый сыр рокфор получают из молока:", "Крупное хозяйство в Бразилии называется:", "Караван-сарай - это название:",
                "Самый большой полуостров на земле:", "Столица Канады:", "Самый большой город Турции:", "Донжон - это:", "Хиранива - это:",
                "Большая часть электроэнергии в России вырабатывается на:", "Ирландию называют:", "Где в России в 1877г. был построен первый пароход?",
                "Самый большой футбольный стадион мира находится в:", "Страна утренней свежести:", "Столица Саудовской Аравии:", "Борисфен - это древнее название реки:" };
        public static String[] CorrectAnswer = new String[20] { "Хонсю", "Песчаника", "Финики", "Чехии", "В Великобритании", "Овец", "Фазенда",
                "Постоялого двора", "Аравийский", "Оттава", "Стамбул", "Башня", "Японский сад", "ТЭС", "Изумрудный остров", "В Сормове",
                "В Бразилии", "Корея", "Эр-Рияд", "Днепр" };
        public static String[] WrongAnswer = new String[40] { "Хоккаидо", "Кюсю", "Известняка", "Мрамора", "Бананы", "Ананасы", "Венгрии", "Польше", "Германии", "Франции", "Коров",
                "Коз", "Ранчо", "Гасиенда", "Дома-богача", "Фермы", "Таймыр", "Калифорния", "Афины", "Бразилиа", "Анкара", "Сеул", "Стена", "Ворота", "Японский город",
                "Японское ругательство", "АЭС", "ГЭС", "Алмазный остров", "Сапфировый остров", "В Таганроге", "В Северодвинске", "В Италии", "Во Франции", "Япония",
                "Китай", "Дамаск", "Дели", "Дунай", "Одер"};
        public Form4(string temp, string name1, string name2, string name3, string name4, string name5)
        {
            InitializeComponent();
            label2.Text = temp;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            label8.BackColor = Color.FromArgb(0, 0, 0, 0);
            label9.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
           
       

            switch (Form3.I) {
                case 0:
                    label4.Text = Questions[0];
                    label5.Text = WrongAnswer[0];
                    label6.Text = CorrectAnswer[0];
                    label7.Text = WrongAnswer[1];
                    if (name5 == "" && name4 == "" && name3 == "")
                      {
                label1.Text = name1;
                
            }
            if (name4 == "" && name5 == ""&&name3!="")
            {
               label1.Text = name1;
                
            }
            if (name5 == ""&&name4!="")
            {
                label1.Text = name1;
                
            }
            if(name5!="")
            {
                label1.Text = name1;
            }
                    break;
                case 1:
                    {
                        label4.Text = Questions[1];
                        label6.Text = WrongAnswer[2];
                        label5.Text = CorrectAnswer[1];
                        label7.Text = WrongAnswer[3];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name2;
                            
                        }
                        if(name5!="")
                        {
                            label1.Text = name2;
                            
                        }
                        break;
                    }
                case 2:
                    {
                        label4.Text = Questions[2];
                        label6.Text = WrongAnswer[4];
                        label7.Text = CorrectAnswer[2];
                        label5.Text = WrongAnswer[5];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name1;
                            
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name3;
                            
                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name3;
                           
                        }
                        if (name5 != "")
                        {
                            label1.Text = name3;
                            
                        }
                        break;
                    }
                case 3:
                    {
                        label4.Text = Questions[3];
                        label6.Text = WrongAnswer[6];
                        label5.Text = CorrectAnswer[3];
                        label7.Text = WrongAnswer[7];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name1;
                           
                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name4;
                            
                        }
                        if (name5 != "")
                        {
                            label1.Text = name4;
                            
                        }
                        break;
                    }
                case 4:
                    {
                        label4.Text = Questions[4];
                        label7.Text = WrongAnswer[8];
                        label5.Text = CorrectAnswer[4];
                        label6.Text = WrongAnswer[9];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name1;
                           
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name1;
                           
                        }
                        if (name5 != "")
                        {
                            label1.Text = name5;
                            
                        }
                        break;
                    }
                case 5:
                    {
                        label4.Text = Questions[5];
                        label6.Text = WrongAnswer[10];
                        label5.Text = CorrectAnswer[5];
                        label7.Text = WrongAnswer[11];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name3;
                            
                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name2;
                           
                        }
                        if (name5 != "")
                        {
                            label1.Text = name1;
                           
                        }
                        break;
                    }
                case 6:
                    {
                        label4.Text = Questions[6];
                        label6.Text = WrongAnswer[12];
                        label5.Text = CorrectAnswer[6];
                        label7.Text = WrongAnswer[13];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name1;
                            
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name1;
                            
                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name3;
                            
                        }
                        if (name5 != "")
                        {
                            label1.Text = name2;
                           
                        }
                        break;
                    }
                case 7:
                    {
                        label4.Text = Questions[7];
                        label5.Text = WrongAnswer[14];
                        label6.Text = CorrectAnswer[7];
                        label7.Text = WrongAnswer[15];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name4;
                            
                        }
                        if (name5 != "")
                        {
                            label1.Text = name3;
                            
                        }
                        break;
                    }
                case 8:
                    {
                        label4.Text = Questions[8];
                        label6.Text = WrongAnswer[16];
                        label7.Text = CorrectAnswer[8];
                        label5.Text = WrongAnswer[17];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name1;
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name3;
                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name1;
                        }
                        if (name5 != "")
                        {
                            label1.Text = name4;
                            
                        }
                        break;
                    }
                case 9:
                    {
                        label4.Text = Questions[9];
                        label6.Text = WrongAnswer[18];
                        label5.Text = CorrectAnswer[9];
                        label7.Text = WrongAnswer[19];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name1;
                            
                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name2;
                            
                        }
                        if(name5!="")
                        {
                            label1.Text = name5;
                        }
                        break;
                    }
                case 10:
                    {
                        label4.Text = Questions[10];
                        label6.Text = WrongAnswer[20];
                        label5.Text = CorrectAnswer[10];
                        label7.Text = WrongAnswer[21];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name3;
                            
                        }
                        if (name5 != "")
                        {
                            label1.Text = name1;
                           
                        }
                        break;
                    }
                case 11:
                    {
                        label4.Text = Questions[11];
                        label6.Text = WrongAnswer[22];
                        label5.Text = CorrectAnswer[11];
                        label7.Text = WrongAnswer[23];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name3;
                            
                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name4;
                            
                        }
                        if (name5 != "")
                        {
                            label1.Text = name2;
                           
                        }
                        break;
                    }
                case 12:
                    {
                        label4.Text = Questions[12];
                        label6.Text = WrongAnswer[24];
                        label5.Text = CorrectAnswer[12];
                        label7.Text = WrongAnswer[25];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name1;
                            
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name1;
                            
                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name1;
                            
                        }
                        if (name5 != "")
                        {
                            label1.Text = name3;
                            
                        }
                        break;
                    }
                case 13:
                    {
                        label4.Text = Questions[13];
                        label6.Text = WrongAnswer[26];
                        label5.Text = CorrectAnswer[13];
                        label7.Text = WrongAnswer[27];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name2;
                            
                        }
                        if (name5 != "")
                        {
                            label1.Text = name4;
                            
                        }
                        break;
                    }
                case 14:
                    {
                        label4.Text = Questions[14];
                        label5.Text = WrongAnswer[28];
                        label7.Text = CorrectAnswer[14];
                        label6.Text = WrongAnswer[29];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name1;
                            
                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name3;
                            
                        }
                        if (name5 == "" && name4 != "")

                        {
                            label1.Text = name3;
                            
                        }
                        if (name5 != "")
                        {
                            label1.Text = name5;
                            
                        }
                        break;
                    }
                    case 15:
                    {
                        label4.Text = Questions[15];
                        label5.Text = WrongAnswer[30];
                        label6.Text = CorrectAnswer[15];
                        label7.Text = WrongAnswer[31];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name2;

                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name1;

                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name4;

                        }
                        if (name5 != "")
                        {
                            label1.Text = name1;

                        }
                        break;
                    }
                    case 16:
                    {
                        label4.Text = Questions[16];
                        label6.Text = WrongAnswer[32];
                        label5.Text = CorrectAnswer[16];
                        label7.Text = WrongAnswer[33];
                        if (name5 == ""&&name4 ==""&&name3 =="")
                        {
                            label1.Text = name1;

                        }
                        if (name4 == "" &&name5 =="" && name3 != "")
                        {
                            label1.Text = name2;

                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name1;

                        }
                        if (name5 != "")
                        {
                            label1.Text = name2;

                        }
                        break;
                    }
                    case 17:
                    {
                        label4.Text = Questions[17];
                        label6.Text = WrongAnswer[34];
                        label7.Text = CorrectAnswer[17];
                        label5.Text = WrongAnswer[36];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name2;

                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name3;

                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name2;

                        }
                        if (name5 != "")
                        {
                            label1.Text = name3;

                        }
                        break;
                    }
                    case 18:
                    {
                        label4.Text = Questions[18];
                        label6.Text = WrongAnswer[36];
                        label5.Text = CorrectAnswer[18];
                        label7.Text = WrongAnswer[37];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name1;

                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name1;

                        }
                        if (name5 == "" && name4 != "")
                        {
                            label1.Text = name3;

                        }
                        if (name5 != "")
                        {
                            label1.Text = name4;

                        }
                        break;
                    }
                    case 19:
                    {
                        label4.Text = Questions[19];
                        label5.Text = WrongAnswer[38];
                        label6.Text = CorrectAnswer[19];
                        label7.Text = WrongAnswer[39];
                        if (name5 == "" && name4 == "" && name3 == "")
                        {
                            label1.Text = name2;

                        }
                        if (name4 == "" && name5 == "" && name3 != "")
                        {
                            label1.Text = name2;

                        }
                        if (name5 == ""&&name4!="")
                        {
                            label1.Text = name4;

                        }
                        if (name5 != "")
                        {
                            label1.Text = name5;

                        }
                        break;
                    }
                case 20:
                    Form5 s = new Form5();
                    this.Hide();
                    s.ShowDialog();
                    this.Close();
                    break;
            }
            if(label1.Text == name1)
            {
                check = 1;
            }
            if(label1.Text == name2)
            {
                check = 2;
            }
            if (label1.Text == name3)
            {
                check = 3;
            }
            if(label1.Text == name4)
            {
                check = 4;
            }
            if(label1.Text == name5)
            {
                check = 5;
            }

        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == CorrectAnswer[0] || textBox1.Text == CorrectAnswer[1] || textBox1.Text == CorrectAnswer[2]
                || textBox1.Text == CorrectAnswer[3] || textBox1.Text == CorrectAnswer[4] || textBox1.Text == CorrectAnswer[5]
                || textBox1.Text == CorrectAnswer[6] || textBox1.Text == CorrectAnswer[7] || textBox1.Text == CorrectAnswer[8]
                || textBox1.Text == CorrectAnswer[9] || textBox1.Text == CorrectAnswer[10] || textBox1.Text == CorrectAnswer[11]
                || textBox1.Text == CorrectAnswer[12]|| textBox1.Text == CorrectAnswer[13]|| textBox1.Text == CorrectAnswer[14]
                || textBox1.Text == CorrectAnswer[15]|| textBox1.Text == CorrectAnswer[16]|| textBox1.Text == CorrectAnswer[17]
                || textBox1.Text == CorrectAnswer[18]|| textBox1.Text == CorrectAnswer[19])
            {
                 MessageBox.Show("Правильный ответ");
                switch (check)
                {
                    case 1:
                        {
                            Form3.ochki1 = Form3.ochki1 + Convert.ToInt32(label2.Text);
                            Form3.correctanswers1 = Form3.correctanswers1 + 1;
                            break;
                        }
                    case 2:
                        {
                            Form3.ochki2 = Form3.ochki2 + Convert.ToInt32(label2.Text);
                            Form3.correctanswers2 = Form3.correctanswers2 + 1;
                            break;
                        }
                    case 3:
                        {
                            Form3.ochki3 = Form3.ochki3 + Convert.ToInt32(label2.Text);
                            Form3.correctanswers3 = Form3.correctanswers3 + 1;
                            break;
                        }
                    case 4:
                        {
                            Form3.ochki4 = Form3.ochki4 + Convert.ToInt32(label2.Text);
                            Form3.correctanswers4 = Form3.correctanswers4 + 1;
                            break;
                        }
                    case 5:
                        {
                            Form3.ochki1 = Form3.ochki1 + Convert.ToInt32(label2.Text);
                            Form3.correctanswers1 = Form3.correctanswers1 + 1;
                            break;
                        }
                }
               
            };
            

            if(textBox1.Text != CorrectAnswer[0] && textBox1.Text != CorrectAnswer[1] && textBox1.Text != CorrectAnswer[2]
               && textBox1.Text != CorrectAnswer[3] && textBox1.Text != CorrectAnswer[4] && textBox1.Text != CorrectAnswer[5]
               && textBox1.Text != CorrectAnswer[6] && textBox1.Text != CorrectAnswer[7] && textBox1.Text != CorrectAnswer[8]
               && textBox1.Text != CorrectAnswer[9] && textBox1.Text != CorrectAnswer[10] && textBox1.Text != CorrectAnswer[11]
               && textBox1.Text != CorrectAnswer[12] && textBox1.Text != CorrectAnswer[13] && textBox1.Text != CorrectAnswer[14]
               && textBox1.Text != CorrectAnswer[15] && textBox1.Text != CorrectAnswer[16] && textBox1.Text != CorrectAnswer[17]
               && textBox1.Text != CorrectAnswer[18] && textBox1.Text != CorrectAnswer[19])
            {
                MessageBox.Show("Неправильный ответ");
            }

            
            if (textBox1.Text == "")
            {
               

                MessageBox.Show("Вы не ввели ответ, попробуйте ещё раз");
            }
            else
            {
                Form3.I = Form3.I + 1;
                this.Close();
            }
        }
    }
}
