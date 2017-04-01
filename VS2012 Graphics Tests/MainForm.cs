using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS2012_Graphics_Tests
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateBackdrop(e);
        }

        private void DrawSin(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Green, 2);

            PointF[] points = new PointF[renderBackdrop.Right];

            float xOffset = 0.0F, yOffset = renderBackdrop.Bottom / 2, xScale = 1.0F, yScale = renderBackdrop.Bottom;

            float freq = 0.01F, phase = 0.0F, amplitude = 0.25F;

            /*
             * For a real application, it would be best to calculate the sine wave somewhere else and then take the resulting array and map it to the paint surface.
             * Probably would need to calculate at least twice as many points for pixels in display (like nyquist sampling theory).
             */
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new PointF(
                    (i + xOffset),
                    ((yScale * amplitude * (float)Math.Sin(i * freq * Math.PI + phase)) + yOffset)
                    );
            }

            g.DrawLines(pen, points);
        }

        private void DrawCenterLine(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Yellow, 1);

            g.DrawLine(pen, 0.0F, renderBackdrop.Bottom / 2, renderBackdrop.Right, renderBackdrop.Bottom / 2);
        }

        private void UpdateBackdrop(EventArgs e)
        {
            renderBackdrop.Height = Convert.ToInt32(0.8F * ClientRectangle.Height);
            renderBackdrop.Width = Convert.ToInt32(0.8F * ClientRectangle.Width);
        }

        private void renderBackdrop_Paint(object sender, PaintEventArgs e)
        {
            DrawCenterLine(e);

            DrawSin(e);

            System.Diagnostics.Debug.WriteLine("renderBackdrop Paint Event Triggered!");
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            UpdateBackdrop(e);

            renderBackdrop.Invalidate();
        }
    }
}
