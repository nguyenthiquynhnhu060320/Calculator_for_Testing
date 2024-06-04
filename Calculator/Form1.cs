using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            int a, b, result;
            a = int.Parse(nub1.Text);
            b = int.Parse(nub2.Text);
            Calculation c = new Calculation(a, b);
            result = c.Exectute("+");
            result1.Text = result.ToString();
        }
    }
}
