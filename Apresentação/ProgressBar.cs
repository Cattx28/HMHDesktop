using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SeuNamespace
{
    public class BlueGradientProgressBar : ProgressBar
    {
        public BlueGradientProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;
            Graphics g = e.Graphics;

            // 1. Desenhar o fundo
            using (var bgBrush = new SolidBrush(this.BackColor))
            {
                g.FillRectangle(bgBrush, rect);
            }

            // 2. Calcular a área de progresso
            int fillWidth = (int)(rect.Width * ((double)this.Value / this.Maximum));
            if (fillWidth <= 0)
                return;

            Rectangle fillRect = new Rectangle(rect.X, rect.Y, fillWidth, rect.Height);

            // 3. Desenhar o gradiente azul
            using (var brush = new LinearGradientBrush(
                fillRect,
                Color.FromArgb(99, 129, 156),  // Azul mais claro (topo)
                Color.FromArgb(38, 68, 102),     // Azul mais escuro (base)
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, fillRect);
            }
        }
    }
}