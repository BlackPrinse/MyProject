using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Graph : Form
    {
        private Dictionary<double, double> firstExpr;

        public Graph()
        {
            InitializeComponent();
        }
        public Graph(CalcDictTO data)
        {
            InitializeComponent();
            firstExpr = data.FirstExpr;
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            Text = "First function";
            chart1.Series[0].Points.Clear();

            if (firstExpr.Count >= 10)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }


            foreach (KeyValuePair<double, double> keyValue in firstExpr)
            {
                this.chart1.Series[0].Points.AddXY(keyValue.Key, keyValue.Value);

            }

        }
    }
}
