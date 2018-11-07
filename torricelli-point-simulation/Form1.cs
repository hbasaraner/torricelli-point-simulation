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

        public double[] x = new double[3];
        public double[] y = new double[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Solve(object sender, EventArgs e)
        {
            double minX, maxX, minY, maxY, eps, x_approach, y_approach;
            double distance, minDistance = double.MaxValue, minDistanceX = double.MaxValue, minDistanceY = double.MaxValue;
            try
            {
                x[0] = Convert.ToDouble(x1.Text); x[1] = Convert.ToDouble(x2.Text); x[2] = Convert.ToDouble(x3.Text);
                y[0] = Convert.ToDouble(y1.Text); y[1] = Convert.ToDouble(y2.Text); y[2] = Convert.ToDouble(y3.Text);
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

        }
    }
}
