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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace MyProject
{
    public partial class Form1 : Form
    {
        private const string APP_NAME = "My Program";
        private char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
        private CalcData data = new CalcData();
        private bool isResazed = false;


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

        private void getSep()
        {
            separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];

            try
            {
                string scheck = $"-5{separator}0";
                double dcheck = Convert.ToDouble(scheck);
            }
            catch (Exception)
            {
                if (separator == '.')
                {
                    separator = ',';
                }
                else
                {
                    separator = '.';
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getSep();
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

        private void b_start_calc_Click(object sender, EventArgs e)
        {
            l_firstFuncText.Items.Clear();
            l_secFuncText.Items.Clear();

            CalcTO dataTO = new CalcTO();

            try
            {
                dataTO.Xmax = Convert.ToDouble(t_xmax.Text);
                dataTO.Xmin = Convert.ToDouble(t_xmin.Text);
                dataTO.Dx = Convert.ToDouble(t_dx.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                b_start_calc.Focus();
            }

            data.setData(dataTO);

            data.setDict(openCalcForm(dataTO));

            if (!isResazed)
            {
                Size = new System.Drawing.Size(648, 305);
                isResazed = true;
            }

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

            //var firstExpr = CalcData.FirstExpr;
            //var secExpr = CalcData.SecExpr;

            foreach (KeyValuePair<double, double> keyValue in data.FirstExpr)
            {
                l_firstFuncText.Items.Add(String.Format("x = {0:f2}, f(x) = {1:f2}", keyValue.Key, keyValue.Value));
            }

            foreach (KeyValuePair<double, double> keyValue in data.SecExpr)
            {
                l_secFuncText.Items.Add(String.Format("x = {0:f2}, f(x) = {1:f2}", keyValue.Key, keyValue.Value));
            }

        }

        private CalcDictTO openCalcForm(CalcTO inputData)
        {
            // bool isFormOpened = false;
            FormCollection fc = Application.OpenForms;
            //b_start_calc.Enabled = false;

            //await Task.Run(() =>
            //{
            //    foreach (Form frm in fc)
            //    {
            //        if (frm.Name == "calc")
            //        {
            //            isFormOpened = true;
            //        }
            //    }
            //});

            //if (!isFormOpened)
            //{
            //    calc cl = new calc();
            //    cl.ShowDialog();
            //}

            calc c1 = new calc(inputData);
            c1.ShowDialog();

            var outputData = c1.getDictTO();
            return outputData;
        }
        private SaveData convertCalcDatatoSaveData(CalcData inputdata)
        {
            SaveData sdata = new SaveData();
            sdata.Xmax = inputdata.Xmax;
            sdata.Xmin = inputdata.Xmin;
            sdata.Dx = inputdata.Dx;

            double[] arrF1 = new double[inputdata.FirstExpr.Count];
            double[] arrF2 = new double[inputdata.SecExpr.Count];

            double[] arrX1 = new double[inputdata.FirstExpr.Count];
            double[] arrX2 = new double[inputdata.SecExpr.Count];

            int i = 0;

            foreach (KeyValuePair<double, double> keyValue in data.FirstExpr)
            {
                arrF1[i] = keyValue.Value;
                arrX1[i] = keyValue.Key;
                i++;
            }
            i = 0;
            foreach (KeyValuePair<double, double> keyValue in data.SecExpr)
            {
                arrF2[i] = keyValue.Value;
                arrX2[i] = keyValue.Key;
                i++;
            }

            sdata.firstArrX = arrX1;
            sdata.secArrX = arrX2;
            sdata.firstArrFunc = arrF1;
            sdata.secArrFunc = arrF2;

            return sdata;
        }

        private CalcData convertSaveData2CalcData(SaveData inputdata)
        {
            CalcData sdata = new CalcData();

            sdata.Xmax = inputdata.Xmax;
            sdata.Xmin = inputdata.Xmin;
            sdata.Dx = inputdata.Dx;

            var t_firstExpr = new Dictionary<double, double>();
            var t_secExpr = new Dictionary<double, double>();


            for (int i = 0; i < inputdata.firstArrFunc.Length; i++)
            {
                t_firstExpr.Add(inputdata.firstArrX[i], inputdata.firstArrFunc[i]);
            }
            for (int i = 0; i < inputdata.secArrFunc.Length; i++)
            {
                t_secExpr.Add(inputdata.secArrX[i], inputdata.secArrFunc[i]);
            }
            sdata.FirstExpr = t_firstExpr;
            sdata.SecExpr = t_secExpr;

            return sdata;
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
        private CalcDictTO convertCalcData2ClcDictTO(CalcData data)
        {
            var dict = new CalcDictTO();
            dict.FirstExpr = data.FirstExpr;
            dict.SecExpr = data.SecExpr;
            return dict;
        }

        private void b_showGraph_Click(object sender, EventArgs e)
        {
            Graph graphfirst = new Graph(convertCalcData2ClcDictTO(data));
            graphfirst.Show();
        }

        private void b_showSecFuncGraph_Click(object sender, EventArgs e)
        {
            GraphSec graphsecond = new GraphSec(convertCalcData2ClcDictTO(data));
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
            BackColor = colorDialog1.Color;
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
            Size = new System.Drawing.Size(277, 293);

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

            SaveData sdat = new SaveData();
            sdat = convertCalcDatatoSaveData(data);
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(SaveData));
                serializer.Serialize(stream, sdat);

                MessageBox.Show("Saved to file!");
            }


            //MessageBox.Show($"{sdat.firstArrFunc.Length} {sdat.firstArrFunc[1]}");

            //using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            //{
            //    await JsonSerializer.SerializeAsync<SaveData>(fs, sdat);
            //}

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
            }

            data = convertSaveData2CalcData(upload);
            l_firstFuncText.Items.Clear();
            l_secFuncText.Items.Clear();


            foreach (KeyValuePair<double, double> keyValue in data.FirstExpr)
            {
                l_firstFuncText.Items.Add(String.Format("x = {0:f2}, f(x) = {1:f2}", keyValue.Key, keyValue.Value));
            }

            foreach (KeyValuePair<double, double> keyValue in data.SecExpr)
            {
                l_secFuncText.Items.Add(String.Format("x = {0:f2}, f(x) = {1:f2}", keyValue.Key, keyValue.Value));
            }

            t_dx.Text = upload.Dx.ToString();
            t_xmax.Text = upload.Xmax.ToString();
            t_xmin.Text = upload.Xmin.ToString();
            l_firstFuncText.Visible = true;
            l_secFuncText.Visible = true;
            b_showFirstFuncGraph.Visible = true;
            b_showSecFuncGraph.Visible = true;
            p_f1.Visible = true;
            p_f2.Visible = true;

            if (!isResazed)
            {
                Size = new System.Drawing.Size(648, 305);
                isResazed = true;
            }

            MessageBox.Show("Loaded from file!");


        }

        private void t_xmin_Leave(object sender, EventArgs e)
        {

        }

        private void t_xmax_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(t_xmin.Text) >= Convert.ToDouble(t_xmax.Text))
            {
                MessageBox.Show("If x max < or = x mix we cannot tabulate functions. Please enter valid data!");
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
