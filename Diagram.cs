using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_10
{
    public partial class Diagram : Form
    {
        private List<InfoGamers> gamers;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public Diagram(List<InfoGamers> p)
        {
            InitializeComponent();
            gamers = p;
            DrawChart();
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

        private void DrawChart()
        {
            chart1.ChartAreas[0].AxisY.Title = "Кол-во правильных ответов";
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Comic Sans MS", 12);

            foreach (var gamer in gamers)
            {
                chart1.Series["Series1"].Points.AddXY(gamer.GamerName, gamer.CorrectAsnwer);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
