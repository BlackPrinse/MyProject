namespace MyProject
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.creator = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sponsor = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.p_time = new System.Windows.Forms.PictureBox();
            this.p_cyber = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_cyber)).BeginInit();
            this.SuspendLayout();
            // 
            // creator
            // 
            this.creator.AutoSize = true;
            this.creator.BackColor = System.Drawing.SystemColors.Control;
            this.creator.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.creator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creator.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creator.Location = new System.Drawing.Point(3, 0);
            this.creator.Name = "creator";
            this.creator.Size = new System.Drawing.Size(101, 27);
            this.creator.TabIndex = 0;
            this.creator.Text = "creator";
            this.creator.UseWaitCursor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.p_time);
            this.splitContainer1.Panel1.UseWaitCursor = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.p_cyber);
            this.splitContainer1.Panel2.UseWaitCursor = true;
            this.splitContainer1.Size = new System.Drawing.Size(649, 340);
            this.splitContainer1.SplitterDistance = 398;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.UseWaitCursor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.sponsor);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 240);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(398, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.UseWaitCursor = true;
            // 
            // sponsor
            // 
            this.sponsor.AutoSize = true;
            this.sponsor.BackColor = System.Drawing.SystemColors.Control;
            this.sponsor.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.sponsor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sponsor.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sponsor.Location = new System.Drawing.Point(3, 0);
            this.sponsor.Name = "sponsor";
            this.sponsor.Size = new System.Drawing.Size(102, 27);
            this.sponsor.TabIndex = 1;
            this.sponsor.Text = "sponsor";
            this.sponsor.UseWaitCursor = true;
            this.sponsor.Click += new System.EventHandler(this.sponsor_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.creator);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(398, 52);
            this.flowLayoutPanel2.TabIndex = 4;
            this.flowLayoutPanel2.UseWaitCursor = true;
            // 
            // p_time
            // 
            this.p_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_time.Image = global::MyProject.Properties.Resources.beetcreatspos;
            this.p_time.Location = new System.Drawing.Point(0, 0);
            this.p_time.Name = "p_time";
            this.p_time.Size = new System.Drawing.Size(398, 340);
            this.p_time.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_time.TabIndex = 3;
            this.p_time.TabStop = false;
            this.p_time.UseWaitCursor = true;
            this.p_time.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // p_cyber
            // 
            this.p_cyber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_cyber.Image = global::MyProject.Properties.Resources.creator;
            this.p_cyber.Location = new System.Drawing.Point(0, 0);
            this.p_cyber.Name = "p_cyber";
            this.p_cyber.Size = new System.Drawing.Size(247, 340);
            this.p_cyber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_cyber.TabIndex = 1;
            this.p_cyber.TabStop = false;
            this.p_cyber.UseWaitCursor = true;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 340);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.About_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_cyber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label creator;
        private System.Windows.Forms.PictureBox p_cyber;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label sponsor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox p_time;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}