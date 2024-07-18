using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 20;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius = CornerRadius * 2;
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }
    }
}
