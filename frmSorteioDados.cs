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
        int vit1 = 0;
        int vit2 = 0;
        int emp = 0;
        public frmSorteioDados()
        {
            InitializeComponent();
        }

        private int DadinhosMuchoLocoImg(ref PictureBox picBoxQuadradro1, ref PictureBox picBoxQuadradro2)
        {
            int lado1 = sort.Next(1,7);
            int lado2 = sort.Next(1,7);


           
            picBoxQuadradro1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dado" + lado1.ToString() + ".jpg");
            picBoxQuadradro2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dado" + lado2.ToString() + ".jpg");
        
            if(lado1 > lado2)
            {
                return 1;
            }
            else
                if(lado1 < lado2)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            

            int resultado = DadinhosMuchoLocoImg(ref picBoxQuadradro1, ref picBoxQuadradro2);
            if(resultado == 1)
            {
                vit1++;
            }
            else
                if(resultado == 2)
            {
                vit2++;
            }
            else
                if(resultado == 3)
            {
                emp++;
            }
            lblPlacarJog1.Text = vit1.ToString();
            lblPlacarJog2.Text = vit2.ToString();
            lblEmpates.Text = emp.ToString();
        }
   
    }
}
