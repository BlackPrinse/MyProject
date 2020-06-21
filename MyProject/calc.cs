using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class calc : Form
    {
        private Random _random = new Random();
        private readonly string IMAGE_FILE = $"{Environment.CurrentDirectory}\\image\\";
        private string FORM_NAME = "Calculating";
        private double xmin;
        private double xmax;
        private double dx;
        private Dictionary<double, double> firstExpr = new Dictionary<double, double>();
        private Dictionary<double, double> secExpr = new Dictionary<double, double>();

        private bool isActiveCalc;

        public bool IsActiveCalc
        {
            get
            {
                return isActiveCalc;
            }
            private set
            {
                isActiveCalc = value;
            }
        }

        private bool check_Canseled = false;

        public calc()
        {
            InitializeComponent();
        }

        public calc(CalcTO inputData)
        {
            InitializeComponent();

            xmin = inputData.Xmin;
            xmax = inputData.Xmax;
            dx = inputData.Dx;
        }
        public CalcDictTO getDictTO()
        {
            var dict = new CalcDictTO();
            dict.FirstExpr = firstExpr;
            dict.SecExpr = secExpr;
            return dict;
        }
        public calc(SaveData sata)
        {
            InitializeComponent();

            MessageBox.Show(sata.Xmin.ToString() + sata.Xmax.ToString());

        }

        private async void calc_Load(object sender, EventArgs e)
        {
            Text = FORM_NAME;
            MaximizeBox = false;

            b_close.Text = "Close window";
            b_cansel.Text = "Cansel operation";
            l_calcText.Text = "Calculating";

            b_close.Enabled = false;


            //double xmin = CalcData.Xmin;
            //double xmax = CalcData.Xmax;
            //double dx = CalcData.Dx;

            double qvalue = _random.NextDouble();
            double res = (xmax - xmin) / dx;

            var qArr = new double[(int)res + 2];

            int countFirstExprUse = 0;
            int countSecExprUse = 0;


            for (int i = 0; i < qArr.Length; i++)
            {
                qArr[i] = _random.NextDouble();
                if (qArr[i] == 0)
                {
                    qArr[i] = 0.01;
                }
                if (qArr[i] <= 0.25)
                {
                    countFirstExprUse++;
                }
            }
            countSecExprUse = (int)res - countFirstExprUse + 2;


            var firstExprVal = new double[countFirstExprUse];
            var secExprVal = new double[countSecExprUse];


            int count = Convert.ToInt32(res);
            int countbar = 0;
            //           t_calc.Items.Add($"First");
            await Task.Run(() =>
            {
                IsActiveCalc = true;
                int countFExpr = 0;
                int countSExpr = 0;
                int countq = 0;
                //               t_calc.Items.Add($"{countFirstExprUse} {countSecExprUse} {(int)res} ");

                if (count <= 100)
                {
                    countbar = 100 / count;


                    for (int i = 0; xmin <= xmax; i += countbar, xmin += dx)
                    {
                        //                        t_calc.Items.Add($"\nThird {countFExpr} {countSExpr} {countq}");
                        if (l_calcText.Text.EndsWith("..."))
                        {
                            l_calcText.Text = "Calculating ";
                        }
                        else
                        {
                            l_calcText.Text += '.';
                            Thread.Sleep(100);
                        }

                        if (!check_Canseled)
                        {
                            Invoke(new Action(() =>
                            {
                                if (qArr[countq] <= 0.25)
                                {
                                    firstExprVal[countFExpr] = Expressions.calcFirstExpr(xmin, qArr[countq]);
                                    string output;

                                    if (!Double.IsNaN(firstExprVal[countFExpr]) && !Double.IsInfinity(firstExprVal[countFExpr]))
                                    {
                                        output = String.Format("q = {0:f2}; x = {1:f2}, use 1 expr f(x) = {2:f2}", qArr[countq], xmin, firstExprVal[countFExpr]);
                                        firstExpr.Add(xmin, firstExprVal[countFExpr]);
                                    }
                                    else
                                    {
                                        output = String.Format("q = {0:f2}; if x = {0:f2}, f(x) can't be calculater", qArr[countq], xmin);
                                    }

                                    t_calc.Items.Add(output);
                                    countFExpr++;
                                }
                                else
                                {
                                    secExprVal[countSExpr] = Expressions.calcSecExpr(xmin, qArr[countq]);

                                    string output;

                                    if (!Double.IsNaN(secExprVal[countSExpr]) && !Double.IsInfinity(secExprVal[countSExpr]))
                                    {
                                        output = String.Format("q = {0:f2}; x = {1:f2}, use 2 expr f(x) = {2:f2}", qArr[countq], xmin, secExprVal[countSExpr]);
                                        secExpr.Add(xmin, secExprVal[countSExpr]);

                                    }
                                    else
                                    {
                                        output = String.Format("q = {0:f2}; if x = {0:f2}, f(x) can't be calculater", qArr[countq], xmin);
                                    }
                                    t_calc.Items.Add(output);

                                    countSExpr++;
                                }
                                countq++;

                                if (xmin + dx > xmax)
                                {
                                    i = 100;
                                }
                                UpdataProgreeBar(i);
                                Text = $"{FORM_NAME} {i}%";
                            }));

                        }
                        else
                        {
                            break;
                        }


                    }

                }
                else
                {
                    countbar = count / 100;

                    for (int i = 1, k = 0; xmin <= xmax; xmin += dx)
                    {
                        if (l_calcText.Text.EndsWith("..."))
                        {
                            l_calcText.Text = "Calculating ";
                        }
                        else
                        {
                            l_calcText.Text += '.';
                            Thread.Sleep(100);

                        }

                        if (!check_Canseled)
                        {
                            if (qArr[countq] <= 0.25)
                            {
                                firstExprVal[countFExpr] = Expressions.calcFirstExpr(xmin, qArr[countq]);
                                string output;

                                if (!Double.IsNaN(firstExprVal[countFExpr]) && !Double.IsInfinity(firstExprVal[countFExpr]))
                                {
                                    output = String.Format("q = {0:f2}; x = {1:f2}, use 1 expr f(x) = {2:f2}", qArr[countq], xmin, firstExprVal[countFExpr]);
                                    firstExpr.Add(xmin, firstExprVal[countFExpr]);
                                }
                                else
                                {
                                    output = String.Format("q = {0:f2}; if x = {1:f2}, f(x) can't be calculater", qArr[countq], xmin);
                                }

                                t_calc.Items.Add(output);
                                countFExpr++;

                            }
                            else
                            {
                                secExprVal[countSExpr] = Expressions.calcSecExpr(xmin, qArr[countq]);

                                string output;

                                if (!Double.IsNaN(secExprVal[countSExpr]) && !Double.IsInfinity(secExprVal[countSExpr]))
                                {
                                    output = String.Format("q = {0:f2}; x = {1:f2}, use 2 expr f(x) = {2:f2}", qArr[countq], xmin, secExprVal[countSExpr]);
                                    secExpr.Add(xmin, secExprVal[countSExpr]);
                                }
                                else
                                {
                                    output = String.Format("q = {0:f2}; if x = {1:f2}, f(x) can't be calculater", qArr[countq], xmin);
                                }

                                t_calc.Items.Add(output);
                                countSExpr++;
                            }
                            countq++;

                            if (i == countbar)
                            {
                                Invoke(new Action(() =>
                                {
                                    if (xmin + dx > xmax || k >= 100)
                                    {
                                        k = 100;

                                    }
                                    UpdataProgreeBar(k);
                                    Text = $"{FORM_NAME} {k}%";
                                }));

                                Thread.Sleep(50);

                                k++;

                                i = 1;
                            }
                            else
                            {
                                i++;
                            }

                        }
                        else
                        {
                            break;
                        }
                    }
                    //                  t_calc.Items.Add($"Fourth");

                }

                IsActiveCalc = false;

                b_cansel.Enabled = false;
            });

            b_close.Enabled = true;

            Text = "Calculation finished successfully!";
            l_calcText.Text = "Successfull!";

            if (check_Canseled)
            {
                Text = $"Operation canceled successfully!";
                l_calcText.Text = "Canceled!";
            }

            MessageBox.Show(l_calcText.Text);
        }  

        private void UpdataProgreeBar(int i)
        {
            if (i == progressBar1.Maximum)
            {
                progressBar1.Maximum = i + 1;
                progressBar1.Value = i + 1;
                progressBar1.Maximum = i;
            }
            else
            {
                progressBar1.Value = i + 1;
            }

            progressBar1.Value = i;
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_cansel_Click(object sender, EventArgs e)
        {
            if (check_Canseled == true)
            {
                MessageBox.Show("Operation has already been canceled, please stop!");
            }
            else
            {
                check_Canseled = true;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (IsActiveCalc)
            {
                e.Cancel = true;
                MessageBox.Show("Please wait until the calculation is completed");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void t_calc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
