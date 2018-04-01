using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool number_checked = false; 
        int x;
        int newx;
        string problem;
        int score = 0;
        int user_input;
        bool checkButton = false;
        int step = 0;
        int answer_length;


        //проверка выбранной кнопки, x принимает значение radioButton.Tag
        private void radioChecked()
        {
            foreach (RadioButton rb in groupBox1.Controls)
            {
                if (rb.Checked == true)
                {
                    string y = rb.Tag.ToString();
                    x = Convert.ToInt32(y);
                    number_checked = true;
                }
            }
        }

        //сообщение об ошибке, если число не было выбрано
        private void error()
        {
            MessageBox.Show("Ошибка. Выберите число.");
        }
        
        //генерируем пример для решения
        public void to_solve()
        {
            radioChecked();
            if (number_checked == true)
            {
                step++;
                problem = x.ToString() + " * " + step.ToString() + " = ";
                problem_to_solve.Text = problem;
            }
            else if (number_checked == false)
            {
                error();
            }
        }

        // отключаем кнопки
        private void hide_buttons()
        {
            ready.Visible = false;
            start.Visible = false;
            problem_to_solve.Visible = true;
            answer.Visible = true;
            check.Visible = true;
        }

        //проверяем правильность ответа
        private void check_answer()
        {
            user_input = Convert.ToInt32(answer.Text);
            if (user_input == x * step)
            {
                confirm.Text = "верно";
                confirm.Visible = true;
                checkButton = false;
                answer.ReadOnly = true;
                score++;

            }
            else if (user_input != x * step)
            {
                confirm.Text = "неверно";
                confirm.Visible = true;
                checkButton = false;
                answer.ReadOnly = true;
            }

        }

        //проверка, была ли нажата кнопка "проверить"
        private void toggle_check()
        {
            if (check.Enabled == true)
            {
                check.Enabled = false;
            } else if (check.Enabled == false)
            {
                check.Enabled = true;
            }
        }

        //повторение таблицы умножения
        private void ready_Click(object sender, EventArgs e)
        {
            radioChecked();
            if (number_checked == true)
            {
                var Box = new List<string>();
                for (int i = 1; i <= 9; i++)
                {
                    newx = x * i;
                    problem = x.ToString() + " * " + i.ToString() + " = " + (newx).ToString();
                    Box.Add(problem);
                }
                var message = string.Join(Environment.NewLine, Box);
                MessageBox.Show(message);
            }else if (number_checked == false)
            {
                error();
            }

        }

        //кнопка запуска программы
        public void start_Click(object sender, EventArgs e)
        {
            radioChecked();
            if (number_checked == true)
            {
                to_solve();
                hide_buttons();
            }
            else if (number_checked == false)
            {
                error();
            }
        }
             
        //кнопка проверки ответа
        private void check_Click(object sender, EventArgs e)
        {
            answer_length = answer.Text.Length;

            if (answer_length > 0)
            {
                toggle_check();
                check_answer();
                next.Visible = true;
            } else if (answer_length == 0)
            {
                MessageBox.Show("Ошибка. Введите свой ответ");
            }

        }

        //переход к следующему заданию
        private void next_Click(object sender, EventArgs e)
        {
            toggle_check();
            next.Visible = false;
            if (step <= 9) {
                answer.Text = "";
                confirm.Text = "";
                answer.ReadOnly = false;
                to_solve();
                if(step==10){
                    next.Text = "Закончить тест";
                
                }
            }
            else if(step>9)
            {
                problem_to_solve.Visible = false;
                answer.Visible = false;
                confirm.Visible = false;
                check.Visible = false;
                next.Visible = false;

                score_label.Text = "Вы набрали " + score.ToString() + " очков";
                score_label.Visible = true;
                
            }

            
            
        }
    }
}