using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03AndreRandom72B
{
    public partial class Timer : Form
    {
        private Random sort = new Random();
        public Timer()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int val = sort.Next(1,200);
            lblResult.Text = val.ToString();
        }

        private void btnVai_Click(object sender, EventArgs e)
        {
           
                timer1.Enabled = true;
            
        }
    }
}
