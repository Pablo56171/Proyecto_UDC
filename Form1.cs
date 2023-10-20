using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_UDC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gENERADORQRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 forma = new Form2();
            forma.TopLevel = false;
            forma.Dock = DockStyle.Fill;
            panel1.Controls.Add(forma);
            panel1.Tag = forma;
            forma.FormBorderStyle = FormBorderStyle.None;
            forma.BringToFront();
            forma.Show();
        }

        private void rEGISTROALUMNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 forma = new Form3();
            forma.TopLevel = false;
            forma.Dock = DockStyle.Fill;
            panel1.Controls.Add(forma);
            panel1.Tag = forma;
            forma.FormBorderStyle = FormBorderStyle.None;
            forma.BringToFront();
            forma.Show();
        }

        private void rEGISTROMAESTROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 forma = new Form4();
            forma.TopLevel = false;
            forma.Dock = DockStyle.Fill;
            panel1.Controls.Add(forma);
            panel1.Tag = forma;
            forma.FormBorderStyle = FormBorderStyle.None;
            forma.BringToFront();
            forma.Show();
        }
    }
}
