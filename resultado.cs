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
    public partial class resultado : Form
    {
    
        public resultado (int vit1, int vit2, int emp, string nome1, string nome2)
        {
            InitializeComponent();
            if (vit1 > vit2 && vit1 > emp)
            {
                lblResultadoVencedor.Text = nome1;
            }
            else
                if (vit2 > vit1 && vit2 > emp)
            {
                lblResultadoVencedor.Text = nome2;
            }
            else
                if (emp > vit1 && emp > vit2)
            {
                lblResultadoVencedor.Text = "Empate";
            }
            else
                if (vit1 == vit2)
            {
                lblResultadoVencedor.Text = "Empate";
            }
            /*btnVoltar.Click  frmSorteioDados res = frmSorteioDados(vit1, vit2, emp, nome1, nome2)*/
            lblJog1.Text = nome1 + " com " + vit1.ToString() + " vitórias.";
            lbljog2.Text = nome2 + " com " + vit2.ToString() + " vitórias.";
            lblEmp.Text = emp.ToString() + " empates.";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
