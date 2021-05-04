using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace デジタル時計
{
    public partial class デジタル時計 : Form
    {
        public デジタル時計()
        {
            InitializeComponent();
        }

        private void デジタル時計_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToLongTimeString();
        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToLongTimeString();
        }
    }
}
