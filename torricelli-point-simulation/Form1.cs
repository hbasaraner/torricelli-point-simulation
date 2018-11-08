using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace torricelli_point_simulation
{
    public partial class Form1 : Form
    {
        public Graphics Graphics;

        public int[] x = new int[3];
        public int[] y = new int[3];

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            this.ResizeRedraw = true;
        }

        private void Solve(object sender, EventArgs e)
        {
            double minX, maxX, minY, maxY, eps, x_approach, y_approach;
            double distance, minDistance = double.MaxValue, minDistanceX = double.MaxValue, minDistanceY = double.MaxValue;
            try
            {
                x[0] = Convert.ToInt32(x1.Text); x[1] = Convert.ToInt32(x2.Text); x[2] = Convert.ToInt32(x3.Text);
                y[0] = Convert.ToInt32(y1.Text); y[1] = Convert.ToInt32(y2.Text); y[2] = Convert.ToInt32(y3.Text);
                eps = Convert.ToDouble(epsilon.Text);

                minX = maxX = x[0];
                minY = maxY = y[0];

                for (int i=1; i<3; i++)
                {
                    if (x[i] < minX) minX = x[i];
                    if (x[i] > maxX) maxX = x[i];
                    if (y[i] < minY) minY = y[i];
                    if (y[i] > maxY) maxY = y[i];
                }

                for (x_approach = minX; x_approach <= maxX; x_approach += eps)
                {
                    for (y_approach = minY; y_approach <= maxY; y_approach += eps)
                    {
                        distance = 0;
                        for (int i = 0; i < 3; i++)
                            distance += Math.Sqrt(Math.Pow(x_approach - x[i], 2) + Math.Pow(y_approach - y[i], 2));
                        if (distance < minDistance)
                        {
                            minDistance = distance;
                            minDistanceX = x_approach;
                            minDistanceY = y_approach;
                        }
                    }
                }

                Debug.WriteLine("D: {0} | X: {1} | Y: {2}", minDistance, minDistanceX, minDistanceY);
                MessageBox.Show("Distance: " + minDistance.ToString() + "\nX: " + minDistanceX.ToString() + "\nY: " + minDistanceY.ToString(),"Result");
            }
            catch
            {
                Debug.WriteLine(">>>  {0}: Incorrect parameter input detected.", DateTime.Now);
                MessageBox.Show("Incorrect parameter input. Check fields.");
            }
        }

        private void Simulate(object sender, EventArgs e)
        {
            Graphics g = panelDraw.CreateGraphics();
            Pen pRectangle = new Pen(Color.Blue, 5);
            Pen pCircle = new Pen(Color.Magenta, 5);
            Pen pTriangle = new Pen(Color.Orange, 2);
            Pen pLine = new Pen(Color.Black, 2);
            SolidBrush bCircle = new SolidBrush(Color.Magenta);

            // Simulation with rectangle approach
            if (isRectangle.Checked)
            {
                double x_approach = 0, y_approach = 0, maxX, minX, maxY, minY, distance = 0, minDistance = double.MaxValue, minDistanceX = double.MaxValue, minDistanceY = double.MaxValue;
                try
                {

                    Random r = new Random();

                    #region Get coordinates
                    x[0] = Convert.ToInt32(x1.Text); x[1] = Convert.ToInt32(x2.Text); x[2] = Convert.ToInt32(x3.Text);
                    y[0] = Convert.ToInt32(y1.Text); y[1] = Convert.ToInt32(y2.Text); y[2] = Convert.ToInt32(y3.Text);

                    int p_const = panelDraw.Width / 2;

                    Point[] points = { new Point(x[0] + p_const, y[0] + p_const - 2 * y[0]),
                                       new Point(x[1] + p_const, y[1] + p_const - 2 * y[1]),
                                       new Point(x[2] + p_const, y[2] + p_const - 2 * y[2]) };

                    g.DrawLine(pLine, 0, p_const, panelDraw.Width, p_const);
                    g.DrawLine(pLine, p_const, 0, p_const, panelDraw.Width);
                    g.DrawPolygon(pTriangle, points);
                    #endregion



                    #region Find max and min values
                    minX = maxX = x[0];
                    minY = maxY = y[0];

                    for (int i = 1; i < 3; i++)
                    {
                        if (x[i] < minX) minX = x[i];
                        if (x[i] > maxX) maxX = x[i];
                        if (y[i] < minY) minY = y[i];
                        if (y[i] > maxY) maxY = y[i];
                    }
                    #endregion

                    int count = Convert.ToInt32(iterationCount.Text);
                    for (int j = 1; j <= count; j++)
                    {
                        x_approach = r.Next(0, int.MaxValue) / (double)int.MaxValue * (maxX - minX) + minX;
                        y_approach = r.Next(0, int.MaxValue) / (double)int.MaxValue * (maxY - minY) + minY;


                        g.FillEllipse(bCircle, (float)x_approach + p_const, (float)y_approach + p_const - (2 * (float)y_approach), 1, 1);
                        g.DrawPolygon(pTriangle, points);

                        distance = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            distance += Math.Sqrt(Math.Pow(x_approach - x[i], 2) + (Math.Pow(y_approach - y[i], 2)));
                        }
                        if (distance < minDistance)
                        {
                            minDistance = distance;
                            minDistanceX = x_approach;
                            minDistanceY = y_approach;
                        }

                        if (j % 1000 == 0)
                        {
                            toolStripStatusLabel1.Text = "Distance: " + minDistance.ToString();
                            statusStrip1.Update();
                        }
                            
                    }
                    toolStripStatusLabel1.Text = "OK! Distance: " + minDistance.ToString() + " | Min. Distance of X: " + x_approach.ToString() + " | Min. Distance of Y: " + y_approach.ToString();
                }
                catch
                {

                }
            }

            // Simulation with circle approach
            else if (isCircle.Checked)
            {

            }
        }
    }
}
