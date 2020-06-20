namespace MyProject
{
    partial class calc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calc));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.l_calcText = new System.Windows.Forms.Label();
            this.t_calc = new System.Windows.Forms.ListBox();
            this.p_calc = new System.Windows.Forms.PictureBox();
            this.b_cansel = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_calc)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.b_cansel);
            this.splitContainer1.Panel2.Controls.Add(this.b_close);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Size = new System.Drawing.Size(479, 225);
            this.splitContainer1.SplitterDistance = 142;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Panel1.Controls.Add(this.t_calc);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.p_calc);
            this.splitContainer2.Size = new System.Drawing.Size(479, 142);
            this.splitContainer2.SplitterDistance = 291;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.l_calcText);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(100, 142);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // l_calcText
            // 
            this.l_calcText.AutoSize = true;
            this.l_calcText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_calcText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_calcText.Location = new System.Drawing.Point(3, 0);
            this.l_calcText.Name = "l_calcText";
            this.l_calcText.Size = new System.Drawing.Size(45, 19);
            this.l_calcText.TabIndex = 1;
            this.l_calcText.Text = "label1";
            // 
            // t_calc
            // 
            this.t_calc.Dock = System.Windows.Forms.DockStyle.Right;
            this.t_calc.FormattingEnabled = true;
            this.t_calc.HorizontalScrollbar = true;
            this.t_calc.Location = new System.Drawing.Point(100, 0);
            this.t_calc.Name = "t_calc";
            this.t_calc.Size = new System.Drawing.Size(191, 142);
            this.t_calc.TabIndex = 0;
            this.t_calc.SelectedIndexChanged += new System.EventHandler(this.t_calc_SelectedIndexChanged);
            // 
            // p_calc
            // 
            this.p_calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p_calc.Cursor = System.Windows.Forms.Cursors.No;
            this.p_calc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_calc.Image = global::MyProject.Properties.Resources.calc;
            this.p_calc.Location = new System.Drawing.Point(0, 0);
            this.p_calc.Name = "p_calc";
            this.p_calc.Size = new System.Drawing.Size(184, 142);
            this.p_calc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_calc.TabIndex = 1;
            this.p_calc.TabStop = false;
            // 
            // b_cansel
            // 
            this.b_cansel.Location = new System.Drawing.Point(310, 33);
            this.b_cansel.Name = "b_cansel";
            this.b_cansel.Size = new System.Drawing.Size(155, 29);
            this.b_cansel.TabIndex = 2;
            this.b_cansel.Text = "button2";
            this.b_cansel.UseVisualStyleBackColor = true;
            this.b_cansel.Click += new System.EventHandler(this.b_cansel_Click);
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(12, 33);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(155, 29);
            this.b_close.TabIndex = 1;
            this.b_close.Text = "button1";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(479, 26);
            this.progressBar1.TabIndex = 0;
            // 
            // calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 225);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "calc";
            this.Load += new System.EventHandler(this.calc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_calc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button b_cansel;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox p_calc;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox t_calc;
        private System.Windows.Forms.Label l_calcText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}