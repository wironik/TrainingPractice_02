using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrainingPractice_02
{
    public partial class Form1 : Form
    {
        public int number=0;
        public int s = 0;
        public int m = 3;
        public string[] record = new string[10];
        public int size = 0;
        public string path = @"..\..\record.txt";
        public Form1()//инициализация формы
        {
            InitializeComponent();

            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            label1.Text = "Оставшееся время: " + Convert.ToString(m) + ":0" + Convert.ToString(s);
            label10.Text = "";
            label6.Text = "Перед вами будет картинка с числами. Ваша задача - за 3 минуты " +
                " успеть нажать на цифры от 1 до 51 в порядке возрастания. В случае, если нажать не ту цифру, счетчик обнулится, но игра продолжится, " +
                "поэтому будьте внимательнее.";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                int i = 0;
                if (record[0] == null)
                    size = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    record[i] = line;
                    i++;
                    size++;
                }
            }
            if (record[0] != null)
                for (int i = 0; i < size; i++)
                    label10.Text += Convert.ToString(i + 1) + ".   ------   " + Convert.ToString(record[i]) + "\n";
            else
                label10.Text = "Записи отсутствуют";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var point = this.PointToClient(Cursor.Position);
            if ((point.X>189 && point.X<236) && (point.Y>351 && point.Y<417) && number==0)//1
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 479 && point.X < 528 && point.Y > 148 && point.Y < 216 && number==1)//2
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 381 && point.X < 429 && point.Y > 317 && point.Y < 353 && number == 2)//3
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 190 && point.X < 238 && point.Y > 81 && point.Y < 147 && number == 3)//4
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 381 && point.X < 479 && point.Y > 148 && point.Y < 216 && number == 4)//5
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 92 && point.X < 142 && point.Y > 182 && point.Y < 216 && number == 5)//6
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 575 && point.X < 673 && point.Y > 251 && point.Y < 283 && number == 6)//7
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 530 && point.X < 576 && point.Y > 82 && point.Y < 147 && number == 7)//8
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 574 && point.X < 673 && point.Y > 352 && point.Y < 418 && number == 8)//9
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 189 && point.X < 238 && point.Y > 282 && point.Y < 316 && number == 9)//10
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 382 && point.X < 479 && point.Y > 82 && point.Y < 115 && number == 10)//11
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 190 && point.X < 287 && point.Y > 147 && point.Y < 182 && number == 11)//12
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 287 && point.X < 334 && point.Y > 81 && point.Y < 115 && number == 12)//13
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 237 && point.X < 283 && point.Y > 351 && point.Y < 416 && number == 13)//14
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 528 && point.X < 575 && point.Y > 147 && point.Y < 216 && number == 14)//15
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 284 && point.X < 381 && point.Y > 283 && point.Y < 352 && number == 15)//16
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 381 && point.X < 479 && point.Y > 384 && point.Y < 417 && number == 16)//17
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 333 && point.X < 381 && point.Y > 217 && point.Y < 283 && number == 17)//18
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 188 && point.X < 237 && point.Y > 315 && point.Y < 351 && number == 18)//19
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 430 && point.X < 479 && point.Y > 284 && point.Y < 317 && number == 19)//20
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 92 && point.X < 189 && point.Y > 216 && point.Y < 283 && number == 20)//21
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 92 && point.X < 189 && point.Y > 383 && point.Y < 417 && number == 21)//22
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 574 && point.X < 672 && point.Y > 216 && point.Y < 252 && number == 22)//23
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 479 && point.X < 529 && point.Y > 82 && point.Y < 148 && number == 23)//24
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 287 && point.X < 382 && point.Y > 114 && point.Y < 148 && number == 24)//25
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 381 && point.X < 478 && point.Y > 352 && point.Y < 384 && number == 25)//26
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 285 && point.X < 333 && point.Y > 216 && point.Y < 283 && number == 26)//27
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 142 && point.X < 190 && point.Y > 182 && point.Y < 216 && number == 27)//28
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 576 && point.X < 673 && point.Y > 82 && point.Y < 146 && number == 28)//29
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 93 && point.X < 189 && point.Y > 80 && point.Y < 147 && number == 29)//30
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 526 && point.X < 573 && point.Y > 283 && point.Y < 353 && number == 30)//31
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 189 && point.X < 286 && point.Y > 182 && point.Y < 216 && number == 31)//32
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 92 && point.X < 189 && point.Y > 283 && point.Y < 351 && number == 32)//33
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 334 && point.X < 383 && point.Y > 81 && point.Y < 116 && number == 33)//34
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 478 && point.X < 574 && point.Y > 352 && point.Y < 417 && number == 34)//35
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 383 && point.X < 479 && point.Y > 115 && point.Y < 149 && number == 35)//36
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 381 && point.X < 429 && point.Y > 283 && point.Y < 317 && number == 36)//37
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 334 && point.X < 381 && point.Y > 148 && point.Y < 216 && number == 37)//38
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 188 && point.X < 285 && point.Y > 216 && point.Y < 283 && number == 38)//39
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 284 && point.X < 381 && point.Y > 351 && point.Y < 416 && number == 39)//40
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 92 && point.X < 189 && point.Y > 147 && point.Y < 182 && number == 40)//41
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 574 && point.X < 672 && point.Y > 283 && point.Y < 352 && number == 41)//42
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 429 && point.X < 478 && point.Y > 317 && point.Y < 352 && number == 42)//43
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 237 && point.X < 287 && point.Y > 81 && point.Y < 147 && number == 43)//44
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 479 && point.X < 574 && point.Y > 217 && point.Y < 283 && number == 44)//45
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 238 && point.X < 284 && point.Y > 283 && point.Y < 351 && number == 45)//46
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 286 && point.X < 334 && point.Y > 148 && point.Y < 217 && number == 46)//47
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 478 && point.X < 526 && point.Y > 283 && point.Y < 353 && number == 47)//48
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 575 && point.X < 673 && point.Y > 146 && point.Y < 216 && number == 48)//49
            {
                number++;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
            else if (point.X > 381 && point.X < 479 && point.Y > 217 && point.Y < 283 && number == 49)//50
            {
                number++;
                label2.Text = "Число: "+Convert.ToString(number)+" из 51";
            }
            else if (point.X > 91 && point.X < 188 && point.Y > 350 && point.Y < 383 && number == 50)//51
            {
                label10.Text = "";
                timer1.Stop();
                int time=180;
                int res = time-(m * 60 + s);
                m = res / 60;
                s = res % 60;
                using (StreamWriter sr = new StreamWriter(path))
                {
                    int result;
                    int last;
                    int i = 0;
                    string line;
                    if (s>=0&&s<10)
                        line = m+":0"+s;
                    else
                        line = m + ":" + s;
                    if (size < 10)
                        size++;
                    if (record[9]!=null)
                    {
                        int.TryParse(string.Join("", line.Where(c => char.IsDigit(c))), out result);
                        int.TryParse(string.Join("", record[size-2].Where(c => char.IsDigit(c))), out last);
                        if (result <= last)
                            record[size - 1] = line;
                    }
                    else
                    {
                        record[size - 1] = line;
                    }
                    Array.Sort(record, i, size);
                    while (i !=size)
                    {
                        sr.Write(record[i]+"\n");
                        i++;
                    }
                    if (record[0] == line)
                        label5.Visible = true;
                    else
                        label5.Visible = false;
                    label4.Text = "Вы победили!\nВаш результат: "+ Convert.ToString(line);
                }
                for (int i = 0; i < size; i++)
                    label10.Text += Convert.ToString(i + 1) + ".   ------   " + Convert.ToString(record[i]) + "\n";
                m = 3;
                s = 0;
                number = 0;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
                if (s >= 0 && s < 10)
                    label1.Text = "Оставшееся время: " + Convert.ToString(m) + ":0" + Convert.ToString(s);
                else
                    label1.Text = "Оставшееся время: " + Convert.ToString(m) + ":" + Convert.ToString(s);
                panel3.Visible = true;
                panel2.Visible = false;
            }
            else
            {
                number=0;
                label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            }
        }

        private void button1_Click(object sender, EventArgs e)//начать игру(работает)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)//выход (работает)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)//работа таймера (работает)
        {
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == 0 && s == 0)
            {
                timer1.Stop();
                label4.Text = "Время вышло! \n\nВы проиграли";
                panel3.Visible = true;
                label5.Visible = false;
                panel2.Visible = false;
            }
            if (s >= 0 && s < 10)
                label1.Text = "Оставшееся время: " + Convert.ToString(m) + ":0" + Convert.ToString(s);
            else
                label1.Text = "Оставшееся время: " + Convert.ToString(m) + ":" + Convert.ToString(s);
        }

        private void button8_Click(object sender, EventArgs e)//вернуться в меню после окончания игры(работает)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)//начать заново после окончания игры(работает)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            number = 0;
            label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            m = 3;
            s = 0;
            label1.Text = "Оставшееся время: " + Convert.ToString(m) + ":" + Convert.ToString(s);
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)//таблица рекордов(работает)
        {
            panel5.Visible = true;
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)//как играть(работает)
        {
            panel4.Visible = true;
            panel1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)//вернуться в главное меню после правил(работает)
        {
            panel1.Visible = true;
            panel4.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)//вернуться в главное меню после рекордов(работает)
        {
            panel1.Visible = true;
            panel5.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)//очистить список рекордов
        {
            using (StreamWriter sr = new StreamWriter(path))
            {
                int i = 0;
                Array.Clear(record, i, size);
                size = 0;
                sr.Write("");
            }
            label10.Text = "Записи отсутствуют";
        }

        private void button12_Click(object sender, EventArgs e)//продолжить после паузы
        {
            timer1.Start();
            panel2.Visible = true;
            panel6.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)//начать заново после паузы
        {
            number = 0;
            label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            if (m != -1 && s != 0)
            {
                timer1.Stop();
                m = 3;
                s = 0;
                if (s >= 0 && s < 10)
                    label1.Text = "Оставшееся время: " + Convert.ToString(m) + ":0" + Convert.ToString(s);
                else
                    label1.Text = "Оставшееся время: " + Convert.ToString(m) + ":" + Convert.ToString(s);
            }
            timer1.Start();
            panel2.Visible = true;
            panel6.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)//вернуться в главное меню после паузы
        {
            number = 0;
            if (m != 0 && s != 0)
            {
                m = 3;
                s = 0;
            }
            if (s >= 0 && s < 10)
                label1.Text = "Оставшееся время: " + Convert.ToString(m) + ":0" + Convert.ToString(s);
            else
                label1.Text = "Оставшееся время: " + Convert.ToString(m) + ":" + Convert.ToString(s);
            label2.Text = "Число: " + Convert.ToString(number) + " из 51";
            panel1.Visible = true;
            panel6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)//пауза
        {
            timer1.Stop();
            panel6.Visible = true;
            panel2.Visible = false;
        }
    }

}
