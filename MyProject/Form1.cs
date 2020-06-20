using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Serialization;
using System.IO;

namespace MyProject
{
    public partial class Form1 : Form
    {
        private const string APP_NAME = "My Program";
        private readonly char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];

        public Form1()
        {
            InitializeComponent();

            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // расширенное окно для выбора цвета
            // добавляем возможность выбора цвета шрифта
            fontDialog1.ShowColor = true;

            formToolStripMenuItem.Click += formToolStripMenuItem_Click;
            // расширенное окно для выбора цвета
            colorDialog1.FullOpen = true;
            // установка начального цвета для colorDialog
            colorDialog1.Color = this.BackColor;

            m_savetofile.Click += m_savetofile_Click;
            m_loadfromfile.Click += m_loadfromfile_Click;

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = APP_NAME;
            b_start_calc.Text = "Start calculating";
            t_xmin.Text = $"-5{separator}0";
            t_xmax.Text = $"0{separator}0";
            t_dx.Text = $"0{separator}2";
            l_xmin.Text = "Enter x min";
            l_xmax.Text = "Enter x max";
            l_dx.Text = "Enter dx";
            b_showFirstFuncGraph.Text = "Show first function graph";
            b_showSecFuncGraph.Text = "Show second function graph";


            l_firstFuncText.Items.Clear();
            l_secFuncText.Items.Clear();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            l_firstFuncText.Items.Clear();
            l_secFuncText.Items.Clear();

            try
            {
                CalcData.Xmax = Convert.ToDouble(t_xmax.Text);
                CalcData.Xmin = Convert.ToDouble(t_xmin.Text);
                CalcData.Dx = Convert.ToDouble(t_dx.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                b_start_calc.Focus();
            }

            await openCalcForm();

            l_firstFuncText.Visible = true;
            l_secFuncText.Visible = true;
            b_showFirstFuncGraph.Visible = true;
            b_showSecFuncGraph.Visible = true;
            p_f1.Visible = true;
            p_f2.Visible = true;

            //for (int countf = 0, counts = 0; countf < CalcData.FirstExprArr.Length & counts < CalcData.SecExprArr.Length; countf++)
            //{
            //    if (!Double.IsNaN(CalcData.FirstExprArr[j]) || !Double.IsInfinity(CalcData.FirstExprArr[j]))
            //    {
            //        l_firstFuncText.Items.Add($"f(x) = {CalcData.FirstExprArr[countf]}");
            //    }
            //    else
            //    {
            //        l_firstFuncText.Items.Add($"f(x) can't be calculated");
            //    }

            //}

            //for (int counts = 0; counts < CalcData.SecExprArr.Length; counts++)
            //{
            //    if (!Double.IsNaN(CalcData.FirstExprArr[counts]) || !Double.IsInfinity(CalcData.FirstExprArr[counts]))
            //    {
            //        l_firstFuncText.Items.Add($"f(x) = {CalcData.FirstExprArr[counts]}");
            //    }
            //    else
            //    {
            //        l_firstFuncText.Items.Add($"f(x) can't be calculated");
            //    }
            //}

            var firstExpr = CalcData.FirstExpr;
            var secExpr = CalcData.SecExpr;

            foreach (KeyValuePair<double, double> keyValue in firstExpr)
            {
                l_firstFuncText.Items.Add(String.Format("x = {0:f2}, f(x) = {1:f2}", keyValue.Key, keyValue.Value));
            }

            foreach (KeyValuePair<double, double> keyValue in secExpr)
            {
                l_secFuncText.Items.Add(String.Format("x = {0:f2}, f(x) = {1:f2}", keyValue.Key, keyValue.Value));
            }

        }

        private static async Task openCalcForm()
        {
            bool isFormOpened = false;
            FormCollection fc = Application.OpenForms;
            //b_start_calc.Enabled = false;

            await Task.Run(() =>
            {
                foreach (Form frm in fc)
                {
                    if (frm.Name == "calc")
                    {
                        isFormOpened = true;
                    }
                }
            });

            if (!isFormOpened)
            {
                calc cl = new calc();
                cl.ShowDialog();
            }
        }


        private void t_xmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkInputData(e, t_xmin, t_xmax);
        }

        private void t_xmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkInputData(e, t_xmax, t_dx);
        }

        private void t_dx_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkInputData(e, t_dx, b_start_calc);
        }

        private void checkInputData(KeyPressEventArgs e, TextBox t2check, TextBox t2focus)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar == '-')
            {
                return;
            }

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = separator;
            }

            if (e.KeyChar == separator)
            {
                if (t2check.Text.IndexOf(separator) != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    t2focus.Focus();
                }
                return;
            }
            e.Handled = true;
        }
        private void checkInputData(KeyPressEventArgs e, TextBox t2check, Button bt)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar == '-')
            {
                return;
            }

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = separator;
            }

            if (e.KeyChar == separator)
            {
                if (t2check.Text.IndexOf(separator) != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    bt.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void t_xmin_TextChanged(object sender, EventArgs e)
        {
            IsEmpty(t_xmin);
        }

        private void t_xmax_TextChanged(object sender, EventArgs e)
        {
            IsEmpty(t_xmax);
        }

        private void t_dx_TextChanged(object sender, EventArgs e)
        {
            IsEmpty(t_dx);
        }

        private void IsEmpty(TextBox tx)
        {
            if (tx.Text.Length == 0)
            {
                b_start_calc.Enabled = false;
            }
            else
            {
                b_start_calc.Enabled = true;
            }
        }

        private void b_start_calc_MouseLeave(object sender, EventArgs e)
        {

        }

        private void b_start_calc_MouseHover(object sender, EventArgs e)
        {
            if (b_start_calc.Enabled == false)
            {
                MessageBox.Show("Fill in all fields please!");
            }
        }

        private void b_start_calc_MouseMove(object sender, MouseEventArgs e)
        {
            if (b_start_calc.Enabled == false)
            {
                MessageBox.Show("Fill in all fields please!");
            }
        }

        private void t_xmin_KeyDown(object sender, KeyEventArgs e)
        {
            //    if (e.KeyCode == Keys.Back)
            //    {
            //        var selectionStart = t_xmin.SelectionStart;
            //        if (t_xmin.SelectionLength > 0)
            //        {
            //            t_xmin.Text = t_xmin.Text.Substring(0, selectionStart) + t_xmin.Text.Substring(selectionStart + t_xmin.SelectionLength);
            //            t_xmin.SelectionStart = selectionStart;
            //        }
            //        else if (selectionStart > 0)
            //        {
            //            t_xmin.Text = t_xmin.Text.Substring(0, selectionStart - 1) + t_xmin.Text.Substring(selectionStart);
            //            t_xmin.SelectionStart = selectionStart - 1;
            //        }

            //        e.Handled = true;
            //    }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_showGraph_Click(object sender, EventArgs e)
        {
            Graph graphfirst = new Graph();
            graphfirst.Show();
        }

        private void b_showSecFuncGraph_Click(object sender, EventArgs e)
        {
            GraphSec graphsecond = new GraphSec();
            graphsecond.Show();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка шрифта
            Font = t_xmax.Font = t_xmin.Font = t_dx.Font = l_firstFuncText.Font = l_secFuncText.Font = fontDialog1.Font;

            // установка цвета шрифта
            ForeColor = t_xmax.ForeColor = t_xmin.ForeColor = t_dx.ForeColor = l_firstFuncText.ForeColor = l_secFuncText.ForeColor = fontDialog1.Color;
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            this.BackColor = colorDialog1.Color;
        }

        private void objectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            t_xmax.BackColor = t_xmin.BackColor = t_dx.BackColor = l_firstFuncText.BackColor = l_secFuncText.BackColor = colorDialog1.Color;
        }

        private void buttonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            b_start_calc.BackColor = b_showFirstFuncGraph.BackColor = b_showSecFuncGraph.BackColor = colorDialog1.Color;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            l_firstFuncText.Visible = false;
            l_secFuncText.Visible = false;
            b_showFirstFuncGraph.Visible = false;
            b_showSecFuncGraph.Visible = false;
            p_f1.Visible = false;
            p_f2.Visible = false;
            t_xmin.Text = $"-5{separator}0";
            t_xmax.Text = $"0{separator}0";
            t_dx.Text = $"0{separator}2";
        }

        private void m_savetofile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;
            MessageBox.Show(filename);

            var save = new SaveData();
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(SaveData));
                serializer.Serialize(stream, save);

                MessageBox.Show("Saved to file!");
            }
        }

        private void m_loadfromfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку

            var upload = new SaveData();
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(SaveData));
                upload = serializer.Deserialize(stream) as SaveData;

                MessageBox.Show("Loaded from file!");
            }

            CalcData.Dx = upload.Dx;
            CalcData.Xmax = upload.Xmax;
            CalcData.Xmin = upload.Xmin;
            CalcData.FirstExprArr = upload.FirstExprArr;
            CalcData.SecExprArr = upload.SecExprArr;
            CalcData.QValueArr = upload.QValueArr;

            var firstExpr = new Dictionary<double, double>();
            var secExpr = new Dictionary<double, double>();

            int countSExpr = 0, countFExpr = 0, countq = 0;
            for (double xmin = upload.Xmin; upload.Xmin < upload.Xmax; upload.Xmin += upload.Dx)
            {

                if (upload.QValueArr[countq] <= 0.25)
                {
                    if (!Double.IsNaN(upload.FirstExprArr[countFExpr]) && !Double.IsInfinity(upload.FirstExprArr[countFExpr]))
                    {
                        firstExpr.Add(xmin, upload.FirstExprArr[countFExpr]);
                    }
                    countFExpr++;

                }
                else
                {
                    if (!Double.IsNaN(upload.SecExprArr[countSExpr]) && !Double.IsInfinity(upload.SecExprArr[countSExpr]))
                    {
                        secExpr.Add(xmin, upload.SecExprArr[countSExpr]);
                    }
                    countSExpr++;
                }
                countq++;
            }

            foreach (KeyValuePair<double, double> keyValue in firstExpr)
            {
                l_firstFuncText.Items.Add(String.Format("x = {0:f2}, f(x) = {1:f2}", keyValue.Key, keyValue.Value));
            }

            foreach (KeyValuePair<double, double> keyValue in secExpr)
            {
                l_secFuncText.Items.Add(String.Format("x = {0:f2}, f(x) = {1:f2}", keyValue.Key, keyValue.Value));
            }

            l_firstFuncText.Visible = true;
            l_secFuncText.Visible = true;
            b_showFirstFuncGraph.Visible = true;
            b_showSecFuncGraph.Visible = true;
            p_f1.Visible = true;
            p_f2.Visible = true;

        }
    }
}
