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
    public partial class About : Form
    {
        private const string FORM_NAME = "About";

        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            this.Text = FORM_NAME;

            this.creator.Text = "Created by --Reverse";
            this.sponsor.Text = "Sponsored by Cyberpunk 3049";

        }

        private void sponsor_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
