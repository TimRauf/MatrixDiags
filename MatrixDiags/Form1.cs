using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixDiags
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnCreateMx.Text = "Генерация матрицы";
            tbTBoxMx.Text = String.Empty;
        }

        private void btnCreateMx_Click(object sender, EventArgs e)
        {
            //int mainMatrix[][];

            for (int i = 0; i<10; i++)
			{
              for (int j = 0; j<10; j++)
			  {
                 tbTBoxMx.Text = tbTBoxMx.Text + (i + 1)*j + " ";
                 if (j == 9) { tbTBoxMx.Text = tbTBoxMx.Text + "\n"; }
    		  }
                tbTBoxMx.Text = tbTBoxMx.Text + i + " ";
                if (i == 9) { tbTBoxMx.Text = tbTBoxMx.Text + "\n"; }

			}
        }
    }
}
