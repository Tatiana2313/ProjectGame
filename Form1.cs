using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Lab_10
{
    public partial class Form1 : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        string name;
        List<InfoGamers> gamer = new List<InfoGamers>();
        int a, b, answer, countCorrectAswers;
        int timeLeft, totaltime = 60;

        public Form1()
        {
            InitializeComponent();
            GamerName f = new GamerName();
            f.ShowDialog();
            name = f.Name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 36;

            // create a rounded rectangle path using the form's size and radius
            path.AddArc(0, 0, radius, radius, 180, 90); // top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // bottom-left corner

            // create a region with the rounded rectangle path and apply it to the form
            this.Region = new Region(path);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // check if the click was on the title bar
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. На экран выводятся случайные примеры из таблицы умножения (например,  7*3). Игрок должен ввести ответ (21).\n " +
                "2. В случае неверного ответа выводится сообщение, что ответ не верный. Следующий пример не отображается, пока не игрок не ответит правильно.", "Правила игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void изменитьЦветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cDg = new ColorDialog();
            if (cDg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.BackColor = cDg.Color;
            }
        }

        private void изменитьШрифтТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                labelPrimer.Font = fd.Font;
            }
        }

        private void изменитьЦветШрифтаТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cDg = new ColorDialog();
            if (cDg.ShowDialog() == DialogResult.OK)
            {
                labelPrimer.ForeColor = cDg.Color;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                CheckAnswer();
                e.Handled = true;
            }
        }

        private void rjTextBox__TextChanged(object sender, EventArgs e)
        {
            if (rjTextBoxAnswer.Texts.Length != 0)
            {
                rjButtonCheck.Enabled = true;
            }
            else if (rjTextBoxAnswer.Texts.Length == 0)
            {
                rjButtonCheck.Enabled = false;
            }
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            timeLeft = totaltime; 
            labelPrimer.Visible = true;
            rjTextBoxAnswer.Visible = true;
            rjButtonCheck.Visible = true;
            labelTime.Visible = true;
            rjProgressBar1.Visible = true;
            GenerateExample();
            countCorrectAswers = 0;
            labelTime.Text = $"У вас осталось: {timeLeft} сек";
            toolStripButtonStop.Enabled = true;
            toolStripButtonSave.Enabled = true;
        }

        private void GenerateExample()
        {
            Random rnd = new Random();
            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);

            answer = a * b;

            labelPrimer.Text = $"{a} * {b} = ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            rjProgressBar1.Value = totaltime - timeLeft;
            labelTime.Text = $"У вас осталось: {timeLeft} сек";

            if (timeLeft <= 0)
            {
                timer1.Stop();
                toolStripButtonStop.Enabled = false;
                rjTextBoxAnswer.Clear();
                rjTextBoxAnswer.Visible = false;
                rjButtonCheck.Visible = false;
                labelTime.Visible = false;
                labelPrimer.Visible = false;
                rjProgressBar1.Visible = false;
                labelCorrectAnswers.Visible = false;
                labelWrong.Visible = false;
                MessageBox.Show("Время вышло!", "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rjButtonCheck_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void CheckAnswer()
        {
            int userAnswer = Convert.ToInt32(rjTextBoxAnswer.Texts);

            if (userAnswer == answer)
            {
                countCorrectAswers++;
                labelCorrectAnswers.Visible = true;
                labelCorrectAnswers.Text = $"Правильных ответов: {countCorrectAswers}";
                labelWrong.Visible = false;
                rjTextBoxAnswer.Clear();
                GenerateExample();
            }
            else
            {
                rjTextBoxAnswer.Clear();
                labelWrong.Visible = true;
                labelWrong.Text = "Ошибка! Ответ неверный!";
            }
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            toolStripButtonStop.Enabled = false;
            rjTextBoxAnswer.Clear();
            rjTextBoxAnswer.Visible = false;
            rjButtonCheck.Visible = false;
            labelTime.Visible = false;
            labelPrimer.Visible = false;
            rjProgressBar1.Visible = false;
            labelCorrectAnswers.Visible = false;
            labelWrong.Visible = false;
            MessageBox.Show("Игра приостановлена!", "Игра приостановлена", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string file = @"..\..\InfoOfGamers.txt";
                using (StreamWriter writer = new StreamWriter(file, true))
                {
                    writer.WriteLine($"{DateTime.Now},{name},{countCorrectAswers}");
                }
                MessageBox.Show("Данные успешно сохранены в файле.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении в файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonDiagram_Click(object sender, EventArgs e)
        {
            try
            {
                string file = @"..\..\InfoOfGamers.txt";
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    string[] ar = new string[255];

                    while ((line = sr.ReadLine()) != null)
                    {
                        ar = line.Split(',');
                        gamer.Add(new InfoGamers()
                        {
                            DateTime = DateTime.Parse(ar[0]),
                            GamerName = ar[1],
                            CorrectAsnwer = Convert.ToInt32(ar[2]),
                        });
                    }
                    sr.Close();
                }
            }
            catch
            {
                MessageBox.Show("Cannot open a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Diagram f = new Diagram(gamer);
            f.ShowDialog();
        }
    }
}
