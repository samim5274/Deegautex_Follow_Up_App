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
        //List<double> xValue = new List<double>();
        //List<double> yValue = new List<double>();

        List<DateTime> xValue = new List<DateTime>();
        List<double> yValue = new List<double>();
        public AnalysisForm()
        {
            InitializeComponent();
            //xValue.Add(0);
            //yValue.Add(1);

            //xValue.Add(1);
            //yValue.Add(3);

            //xValue.Add(10);
            //yValue.Add(3.5);  

            xValue.Add(new DateTime(2016, 4, 4, 13, 2, 0));
            yValue.Add(1);

            xValue.Add(new DateTime(2016, 4, 4, 13, 12, 0));
            yValue.Add(3);

            xValue.Add(new DateTime(2016, 4, 4, 13, 45, 0));
            yValue.Add(3.5);

        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Red;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Red;
            chart1.Series["Series1"].Color = Color.Green;
            chart1.ChartAreas[0].AxisX.Interval = 5.0;
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:MM:SS";

            chart1.Series["Series1"].Points.DataBindXY(xValue, yValue);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //xValue.Add(13.5);
            //yValue.Add(4.5);
            //chart1.Series["Series1"].Points.DataBindXY(xValue, yValue);
            //chart1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xValue.Add(new DateTime(2016, 4, 4, 13, 50, 0));
            yValue.Add(4.5);
            chart1.Series["Series1"].Points.DataBindXY(xValue, yValue);
            chart1.Invalidate();
        }
    }
}
