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
    public partial class FormRandom : System.Windows.Forms.Form
    {
        public FormRandom()
        {
            InitializeComponent();
        }

        private void btnSorteioJogos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSorteioJogos f1 = new FrmSorteioJogos();
            f1.ShowDialog();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSorteioDados f2 = new frmSorteioDados();
            f2.ShowDialog();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timer f5 = new Timer();
            f5.ShowDialog();
        }
    }
}
