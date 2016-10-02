using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USDtoBGN
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var currencyRate = 1.955m;
            var value = this.numericUpDownConvert.Value;
            this.labelResult.Text = result;
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void numeric(object sender, EventArgs e)
        {

        }
    }
}
