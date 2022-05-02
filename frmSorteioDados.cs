using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _03AndreRandom72B
{
    public partial class frmSorteioDados : Form
    {
        private Random sort = new Random();
        public frmSorteioDados()
        {
            InitializeComponent();
        }

        public void DadinhosMuchoLocoImg(ref PictureBox picBoxQuadradro1, ref PictureBox picBoxQuadradro2)
        {
            int lado = sort.Next(1,7);

            picBoxQuadradro1.Image = Image.FromFile("")
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }
   
    }
}
