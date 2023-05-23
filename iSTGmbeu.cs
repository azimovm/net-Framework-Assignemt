using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
    public class MainForm : System.ComponentModel.Component
    {
        private int _depth;

        public int getDepth()
        {
            return _depth;
        }

        public MainForm()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the depth:", "Depth Input", "1", -1, -1);

            if (int.TryParse(input, out int depth))
            {
                _depth = depth;
            }
            else
            {
                MessageBox.Show("Invalid depth. Using default value of 1.");
                _depth = 1;
            }
            
            CircleForm circleForm = new CircleForm(_depth);
            SquareForm squareForm = new SquareForm(_depth);

            circleForm.Shown += (sender, e) => squareForm.Show();
            circleForm.Show();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();
            Application.Run();
        }
    }
    
    public class SquareForm : Form
    {
        private int _depth;

        public SquareForm(int depth)
        {
            _depth = depth;
            this.Paint += SquareForm_Paint;
            this.Text = "Recursive Squares";
        }

        private void SquareForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen blackPen = new Pen(Color.Black, 2);

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int size = 200;

            DrawSquares(graphics, blackPen, centerX, centerY, size, _depth);
        }

        private void DrawSquares(Graphics graphics, Pen pen, int centerX, int centerY, int size, int depth)
        {
            if (depth == 0)
            {
                return;
            }

            graphics.TranslateTransform(centerX,centerY);
            graphics.RotateTransform(45 * (depth - 1));
            graphics.TranslateTransform(-centerX, -centerY);

            graphics.DrawRectangle(pen, centerX - size / 2, centerY - size / 2, size, size);
            graphics.ResetTransform();

            int newSize = (int) (size / 1.4f);
            DrawSquares(graphics, pen, centerX, centerY, newSize, depth - 1);
        }
    }
    
    public class CircleForm : Form
    {
        private int _depth;

        public CircleForm(int depth)
        {
            _depth = depth;
            this.Paint += MainForm_Paint_For_Circle;
            this.Text = "Recursive Circles";
        }

        private void MainForm_Paint_For_Circle(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen blackPen = new Pen(Color.Purple, 2);

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int radius = 100;

            DrawCircles(graphics, blackPen, centerX, centerY, radius, _depth);
        }

        private void DrawCircles(Graphics graphics, Pen pen, int centerX, int centerY, int radius, int depth)
        {
            if (depth == 0)
            {
                return;
            }
            

            graphics.DrawEllipse(pen, centerX - radius, centerY - radius, radius * 2, radius * 2);

            int[] offsetX = { 1, -1, 0, 0 };
            int[] offsetY = { 0, 0, -1, 1 };

            for (int i = 0; i < 4; i++)
            {
                int newCenterX = centerX + offsetX[i] * (radius);
                int newCenterY = centerY + offsetY[i] * (radius);
                int newRadius = radius / 2;

                DrawCircles(graphics, pen, newCenterX, newCenterY, newRadius, depth - 1);
            }
        }
    }
}
