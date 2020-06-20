namespace MyProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_savetofile = new System.Windows.Forms.ToolStripMenuItem();
            this.m_loadfromfile = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l_xmin = new System.Windows.Forms.Label();
            this.l_xmax = new System.Windows.Forms.Label();
            this.l_dx = new System.Windows.Forms.Label();
            this.t_xmin = new System.Windows.Forms.TextBox();
            this.t_xmax = new System.Windows.Forms.TextBox();
            this.t_dx = new System.Windows.Forms.TextBox();
            this.b_start_calc = new System.Windows.Forms.Button();
            this.l_firstFuncText = new System.Windows.Forms.ListBox();
            this.l_secFuncText = new System.Windows.Forms.ListBox();
            this.b_showFirstFuncGraph = new System.Windows.Forms.Button();
            this.b_showSecFuncGraph = new System.Windows.Forms.Button();
            this.p_f2 = new System.Windows.Forms.PictureBox();
            this.p_f1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_f2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_f1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_savetofile,
            this.m_loadfromfile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // m_savetofile
            // 
            this.m_savetofile.Name = "m_savetofile";
            this.m_savetofile.Size = new System.Drawing.Size(180, 22);
            this.m_savetofile.Text = "Download";
            this.m_savetofile.Click += new System.EventHandler(this.m_savetofile_Click);
            // 
            // m_loadfromfile
            // 
            this.m_loadfromfile.Name = "m_loadfromfile";
            this.m_loadfromfile.Size = new System.Drawing.Size(180, 22);
            this.m_loadfromfile.Text = "Upload";
            this.m_loadfromfile.Click += new System.EventHandler(this.m_loadfromfile_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.backgroundToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem,
            this.objectsToolStripMenuItem,
            this.buttonsToolStripMenuItem});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backgroundToolStripMenuItem.Text = "Background color";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.formToolStripMenuItem.Text = "Form";
            this.formToolStripMenuItem.Click += new System.EventHandler(this.formToolStripMenuItem_Click);
            // 
            // objectsToolStripMenuItem
            // 
            this.objectsToolStripMenuItem.Name = "objectsToolStripMenuItem";
            this.objectsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.objectsToolStripMenuItem.Text = "Fields";
            this.objectsToolStripMenuItem.Click += new System.EventHandler(this.objectsToolStripMenuItem_Click);
            // 
            // buttonsToolStripMenuItem
            // 
            this.buttonsToolStripMenuItem.Name = "buttonsToolStripMenuItem";
            this.buttonsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.buttonsToolStripMenuItem.Text = "Buttons";
            this.buttonsToolStripMenuItem.Click += new System.EventHandler(this.buttonsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // l_xmin
            // 
            this.l_xmin.AutoSize = true;
            this.l_xmin.Location = new System.Drawing.Point(3, 46);
            this.l_xmin.Name = "l_xmin";
            this.l_xmin.Size = new System.Drawing.Size(35, 13);
            this.l_xmin.TabIndex = 1;
            this.l_xmin.Text = "label1";
            // 
            // l_xmax
            // 
            this.l_xmax.AutoSize = true;
            this.l_xmax.Location = new System.Drawing.Point(3, 82);
            this.l_xmax.Name = "l_xmax";
            this.l_xmax.Size = new System.Drawing.Size(35, 13);
            this.l_xmax.TabIndex = 2;
            this.l_xmax.Text = "label2";
            // 
            // l_dx
            // 
            this.l_dx.AutoSize = true;
            this.l_dx.Location = new System.Drawing.Point(3, 116);
            this.l_dx.Name = "l_dx";
            this.l_dx.Size = new System.Drawing.Size(35, 13);
            this.l_dx.TabIndex = 3;
            this.l_dx.Text = "label3";
            // 
            // t_xmin
            // 
            this.t_xmin.AllowDrop = true;
            this.t_xmin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.t_xmin.Location = new System.Drawing.Point(76, 46);
            this.t_xmin.Name = "t_xmin";
            this.t_xmin.Size = new System.Drawing.Size(131, 20);
            this.t_xmin.TabIndex = 4;
            this.t_xmin.Text = "1,0";
            this.t_xmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_xmin.TextChanged += new System.EventHandler(this.t_xmin_TextChanged);
            this.t_xmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_xmin_KeyDown);
            this.t_xmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_xmin_KeyPress);
            // 
            // t_xmax
            // 
            this.t_xmax.Location = new System.Drawing.Point(76, 82);
            this.t_xmax.Name = "t_xmax";
            this.t_xmax.Size = new System.Drawing.Size(131, 20);
            this.t_xmax.TabIndex = 5;
            this.t_xmax.Text = "2,0";
            this.t_xmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_xmax.TextChanged += new System.EventHandler(this.t_xmax_TextChanged);
            this.t_xmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_xmax_KeyPress);
            // 
            // t_dx
            // 
            this.t_dx.Location = new System.Drawing.Point(76, 116);
            this.t_dx.Name = "t_dx";
            this.t_dx.Size = new System.Drawing.Size(131, 20);
            this.t_dx.TabIndex = 6;
            this.t_dx.Text = "0,1";
            this.t_dx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_dx.TextChanged += new System.EventHandler(this.t_dx_TextChanged);
            this.t_dx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_dx_KeyPress);
            // 
            // b_start_calc
            // 
            this.b_start_calc.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.b_start_calc.Location = new System.Drawing.Point(132, 155);
            this.b_start_calc.Name = "b_start_calc";
            this.b_start_calc.Size = new System.Drawing.Size(100, 32);
            this.b_start_calc.TabIndex = 7;
            this.b_start_calc.Text = "Start calculating";
            this.b_start_calc.UseVisualStyleBackColor = false;
            this.b_start_calc.Click += new System.EventHandler(this.button1_Click);
            this.b_start_calc.MouseLeave += new System.EventHandler(this.b_start_calc_MouseLeave);
            this.b_start_calc.MouseHover += new System.EventHandler(this.b_start_calc_MouseHover);
            this.b_start_calc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_start_calc_MouseMove);
            // 
            // l_firstFuncText
            // 
            this.l_firstFuncText.FormattingEnabled = true;
            this.l_firstFuncText.HorizontalScrollbar = true;
            this.l_firstFuncText.Location = new System.Drawing.Point(238, 84);
            this.l_firstFuncText.Name = "l_firstFuncText";
            this.l_firstFuncText.Size = new System.Drawing.Size(188, 147);
            this.l_firstFuncText.TabIndex = 8;
            this.l_firstFuncText.Visible = false;
            this.l_firstFuncText.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // l_secFuncText
            // 
            this.l_secFuncText.FormattingEnabled = true;
            this.l_secFuncText.HorizontalScrollbar = true;
            this.l_secFuncText.Location = new System.Drawing.Point(432, 84);
            this.l_secFuncText.Name = "l_secFuncText";
            this.l_secFuncText.Size = new System.Drawing.Size(188, 147);
            this.l_secFuncText.TabIndex = 9;
            this.l_secFuncText.Visible = false;
            // 
            // b_showFirstFuncGraph
            // 
            this.b_showFirstFuncGraph.Location = new System.Drawing.Point(238, 237);
            this.b_showFirstFuncGraph.Name = "b_showFirstFuncGraph";
            this.b_showFirstFuncGraph.Size = new System.Drawing.Size(188, 23);
            this.b_showFirstFuncGraph.TabIndex = 12;
            this.b_showFirstFuncGraph.Text = "button1";
            this.b_showFirstFuncGraph.UseVisualStyleBackColor = true;
            this.b_showFirstFuncGraph.Visible = false;
            this.b_showFirstFuncGraph.Click += new System.EventHandler(this.b_showGraph_Click);
            // 
            // b_showSecFuncGraph
            // 
            this.b_showSecFuncGraph.Location = new System.Drawing.Point(432, 237);
            this.b_showSecFuncGraph.Name = "b_showSecFuncGraph";
            this.b_showSecFuncGraph.Size = new System.Drawing.Size(188, 23);
            this.b_showSecFuncGraph.TabIndex = 13;
            this.b_showSecFuncGraph.Text = "button1";
            this.b_showSecFuncGraph.UseVisualStyleBackColor = true;
            this.b_showSecFuncGraph.Visible = false;
            this.b_showSecFuncGraph.Click += new System.EventHandler(this.b_showSecFuncGraph_Click);
            // 
            // p_f2
            // 
            this.p_f2.Image = global::MyProject.Properties.Resources.secfunc;
            this.p_f2.Location = new System.Drawing.Point(461, 37);
            this.p_f2.Name = "p_f2";
            this.p_f2.Size = new System.Drawing.Size(140, 41);
            this.p_f2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_f2.TabIndex = 15;
            this.p_f2.TabStop = false;
            this.p_f2.Visible = false;
            // 
            // p_f1
            // 
            this.p_f1.Image = global::MyProject.Properties.Resources.firstfunc;
            this.p_f1.Location = new System.Drawing.Point(268, 37);
            this.p_f1.Name = "p_f1";
            this.p_f1.Size = new System.Drawing.Size(131, 41);
            this.p_f1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_f1.TabIndex = 14;
            this.p_f1.TabStop = false;
            this.p_f1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyProject.Properties.Resources.drako;
            this.pictureBox1.Location = new System.Drawing.Point(6, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.b_start_calc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(632, 267);
            this.Controls.Add(this.p_f2);
            this.Controls.Add(this.p_f1);
            this.Controls.Add(this.b_showSecFuncGraph);
            this.Controls.Add(this.b_showFirstFuncGraph);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.l_secFuncText);
            this.Controls.Add(this.l_firstFuncText);
            this.Controls.Add(this.b_start_calc);
            this.Controls.Add(this.t_dx);
            this.Controls.Add(this.t_xmax);
            this.Controls.Add(this.t_xmin);
            this.Controls.Add(this.l_dx);
            this.Controls.Add(this.l_xmax);
            this.Controls.Add(this.l_xmin);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_f2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_f1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_savetofile;
        private System.Windows.Forms.ToolStripMenuItem m_loadfromfile;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label l_xmin;
        private System.Windows.Forms.Label l_xmax;
        private System.Windows.Forms.Label l_dx;
        private System.Windows.Forms.TextBox t_xmax;
        private System.Windows.Forms.TextBox t_dx;
        private System.Windows.Forms.Button b_start_calc;
        private System.Windows.Forms.TextBox t_xmin;
        public System.Windows.Forms.ListBox l_firstFuncText;
        public System.Windows.Forms.ListBox l_secFuncText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_showFirstFuncGraph;
        private System.Windows.Forms.Button b_showSecFuncGraph;
        private System.Windows.Forms.PictureBox p_f1;
        private System.Windows.Forms.PictureBox p_f2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

