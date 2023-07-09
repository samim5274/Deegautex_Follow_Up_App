using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace MIS
{
    public partial class AnalysisForm : Form
    {
        List<double> xValue = new List<double>();
        List<double> yValue = new List<double>();

        List<double> x1Value = new List<double>();
        List<double> y1Value = new List<double>();

        //List<DateTime> xValue = new List<DateTime>();
        //List<double> yValue = new List<double>();
        public AnalysisForm()
        {
            InitializeComponent();


            //xValue.Add(new DateTime(2016, 4, 4, 13, 2, 0));
            //yValue.Add(1);

            //xValue.Add(new DateTime(2016, 4, 4, 13, 12, 0));
            //yValue.Add(3);

            //xValue.Add(new DateTime(2016, 4, 4, 13, 45, 0));
            //yValue.Add(3.5);

        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            //chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Red;
            //chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Red;
            //chart1.Series["Series1"].Color = Color.Green;
            //chart1.ChartAreas[0].AxisX.Interval = 5.0;
            //chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            //chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:MM:SS";
            //chart1.Series["Income"].Points.DataBindXY(xValue, yValue);
            //chart1.Series["Expenses"].Points.DataBindXY(x1Value, y1Value);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            //xValue.Add(13.5);
            //yValue.Add(4.5);
            //chart1.Series["Series1"].Points.DataBindXY(xValue, yValue);
            //chart1.Invalidate();

            //youtube video link for chart : =========================
            //https://www.youtube.com/watch?v=197bqTsB4wk
            //========================================================

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //xValue.Add(new DateTime(2016, 4, 4, 13, 50, 0));
            //yValue.Add(4.5);
            //chart1.Series["Series1"].Points.DataBindXY(xValue, yValue);
            //chart1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chart1.Series.Clear();
            //chart1.Series.Add("Series1");

            //int x1 = Convert.ToInt32(textBox1.Text.Trim());
            //int y1 = Convert.ToInt32(textBox2.Text.Trim());
            //int x2 = Convert.ToInt32(textBox3.Text.Trim());
            //int y2 = Convert.ToInt32(textBox4.Text.Trim());
            //int x3 = Convert.ToInt32(textBox5.Text.Trim());
            //int y3 = Convert.ToInt32(textBox6.Text.Trim());

            
            //xValue.Add(x1);
            //yValue.Add(y1);

            //xValue.Add(x2);
            //yValue.Add(y2);

            //xValue.Add(x3);
            //yValue.Add(y3);

            //chart1.Series["Series1"].Points.DataBindXY(xValue, yValue);
            //chart1.Invalidate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            //chart1.Series["Income"].Points.Clear();
            //chart1.Series["Expenses"].Points.Clear();
            chart1.Series.Add("Income");
            chart1.Series.Add("Expenses");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FillChart();
        }

        private void FillChart()
        {
            

            xValue.Add(0);
            yValue.Add(0);

            xValue.Add(1);
            yValue.Add(10);

            xValue.Add(2);
            yValue.Add(70);

            xValue.Add(3);
            yValue.Add(50);

            xValue.Add(4);
            yValue.Add(80);

            xValue.Add(5);
            yValue.Add(100);

            //=================================

            x1Value.Add(0);
            y1Value.Add(0);

            x1Value.Add(1);
            y1Value.Add(50);

            x1Value.Add(2);
            y1Value.Add(70);

            x1Value.Add(3);
            y1Value.Add(30);

            x1Value.Add(4);
            y1Value.Add(60);

            x1Value.Add(5);
            y1Value.Add(30);

            chart1.Series["Income"].Points.DataBindXY(xValue, yValue);
            chart1.Series["Expenses"].Points.DataBindXY(x1Value, y1Value);

            chart1.Series["Income"].Points.DataBindXY(xValue, yValue);
            chart1.Series["Expenses"].Points.DataBindXY(x1Value, y1Value);
            chart1.Invalidate();
        }
    }
}
