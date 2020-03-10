using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeorVer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSolution_Click(object sender, EventArgs e)
        {
            double[] P = new double[6];
            bool Error = false;
            //todo: сделать проверку данных
            try
            {
                P[0] = Convert.ToDouble(textBox1.Text);
                P[1] = Convert.ToDouble(textBox2.Text);
                P[2] = Convert.ToDouble(textBox3.Text);
                P[3] = Convert.ToDouble(textBox4.Text);
                P[4] = Convert.ToDouble(textBox5.Text);
                P[5] = Convert.ToDouble(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Используйе запятую для ввода десятичных дробей и не оставляйте окошки пустые!");
                Error = true;
            }

            double Result = 0;
            for (int i = 0; i < 6; i++)
            {
                if (P[i] < 0 || P[i] > 1)
                {
                    Error = true;
                    MessageBox.Show(String.Format("Неверные данные в P(A{0}) вероятности", i + 1));
                }
            }

            if (RadioExSecond.Checked && !Error)
            {
                Result = verSummSovmSob(P[0], (verSummSovmSob(P[1], P[2]) * P[3] * verSummSovmSob(P[4], P[5])));
                MessageBox.Show("Результат вычислений " + Result);
            }
            if(RadioExFirst.Checked && !Error)
            {
                for (int i = 0; i < 6; i++)
                {
                    double temp = 1 - P[i];
                    P[i] = temp;
                }
                Result = P[0] * verSummSovmSob(P[1], P[3] * P[4] * P[5]) * P[2];
                MessageBox.Show("Результат вычислений " + Result);
            }
        }

        double verSummSovmSob(double a, double b)
        {
            return a + b - a * b;
        }

        private void RadioExFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioExFirst.Checked)
            {
                PicSys.Image = new Bitmap("Ex1.png");
                PicFormule.Image = new Bitmap("Ex1F.png");
                LabelAi.Text = "Задана схема. Пусть Ai - событие при котором за время T не выйдет из строя.";
            }
        }

        private void RadioExSecond_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioExSecond.Checked)
            {
                PicSys.Image = new Bitmap("Ex2(1).png");
                PicFormule.Image = new Bitmap("Ex2F.png");
                LabelAi.Text = "Задана схема. Пусть Ai - событие при котором за время T выйдет из строя.";
            }
        }
    }
}
