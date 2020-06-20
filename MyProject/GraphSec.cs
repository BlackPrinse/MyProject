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
    public partial class GraphSec : Form
    {
        public GraphSec()
        {
            InitializeComponent();
        }

        private void GraphSec_Load(object sender, EventArgs e)
        {
            Text = "Second function";
            chart1.Series[0].Points.Clear();
            var secExpr = CalcData.SecExpr; 

            if (secExpr.Count >= 10)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }


            foreach (KeyValuePair<double, double> keyValue in secExpr)
            {
                this.chart1.Series[0].Points.AddXY(keyValue.Key, keyValue.Value);

            }
        }
    }
}
