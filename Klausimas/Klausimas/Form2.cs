using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klausimas
{
    public partial class Form2 : Form
    {
        private Form Tevas;

        public Form2(Form tevas)
        {
            InitializeComponent();
            Tevas = tevas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Tevas.WindowState = FormWindowState.Maximized;
        }
    }
}