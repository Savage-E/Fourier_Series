using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public PlotView pv = new PlotView
        {
            Location = new Point(0, 0),
            Size = new Size(550, 450),
            Model = new PlotModel { Title = "Graphs" },
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Controls.Add(pv);
        }

        private void _textBoxN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void _BtnRun_Click(object sender, EventArgs e)
        {
            FunctionSeries functionSeries1;
            FunctionSeries functionSeries2;
            int N;
            if (_radioBtnX.Checked)
            {
                functionSeries1 = new FunctionSeries();
                functionSeries2 = new FunctionSeries();
                functionSeries1.Title = "SumX";
                functionSeries2.Title = "X";
                functionSeries1.MarkerStroke = OxyColors.Red;
                functionSeries2.MarkerStroke = OxyColors.Bisque;

                pv.Model = new PlotModel { Title = "f(x)=x" };
                pv.Model.Series.Add(functionSeries1);
                pv.Model.Series.Add(functionSeries2);

                 N = int.Parse(_textBoxN.Text);

                for (double i = -4; i <= 4; i += 0.1)
                {
                    functionSeries1.Points.Add(new DataPoint(i, SumX(i, N)));
                    functionSeries2.Points.Add(new DataPoint(i, X(i)));
                }
            }
            if (_radioBtnX2.Checked)
            {
                functionSeries1 = new FunctionSeries();
                functionSeries2 = new FunctionSeries();
                functionSeries1.Title = "Sum(X^2)";
                functionSeries2.Title = "X^2";
                functionSeries1.MarkerStroke = OxyColors.Red;
                functionSeries2.MarkerStroke = OxyColors.Orange;

                pv.Model = new PlotModel { Title = "f(x)=x^2" };
                pv.Model.Series.Add(functionSeries1);
                pv.Model.Series.Add(functionSeries2);

                N = int.Parse(_textBoxN.Text);

                for (double i = -4; i <= 4; i += 0.1)
                {
                    functionSeries1.Points.Add(new DataPoint(i, SumX2(i, N)));
                    functionSeries2.Points.Add(new DataPoint(i, X2(i)));
                }
            }
            if (_radioBtnSgn.Checked)
            {
                functionSeries1 = new FunctionSeries();
                functionSeries2 = new FunctionSeries();
                functionSeries1.Title = "Sum Sign";
                functionSeries2.Title = "Sign";
                functionSeries1.MarkerStroke = OxyColors.Yellow;
                functionSeries2.MarkerStroke = OxyColors.Green;

                pv.Model = new PlotModel { Title = "Sign x" };
                pv.Model.Series.Add(functionSeries1);
                pv.Model.Series.Add(functionSeries2);

                N = int.Parse(_textBoxN.Text);

                for (double i = -4; i <= 4; i += 0.1)
                {
                    functionSeries1.Points.Add(new DataPoint(i, SumSgn(i, N)));
                    functionSeries2.Points.Add(new DataPoint(i, Sgn(i)));
                }

            }
        }

        public double X(double x)
        {
            return x;
        }

        public double SumX(double x, int N)
        {
            double sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += ((Math.Pow(-1, i + 1) * Math.Sin(i * x)) / i);
            }
            return 2 * sum;
        }

        public double X2(double x)
        {
            return x *x;
        }

        public double SumX2(double x, int N)
        {
            double sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += (Math.Pow(-1, i) * Math.Cos(i * x)) / (i * i);
            }

            return ((Math.PI * Math.PI) / 2) + 4 * sum;
        }


        public double Sgn(double x)
        {
            return Math.Sign(x);
        }

        public double SumSgn(double x, int N)
        {
            double sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += (Math.Sin((2*i-1)*x)) / (2*i -1);
            }

            return (4 / Math.PI) * sum;
        }
    }
}