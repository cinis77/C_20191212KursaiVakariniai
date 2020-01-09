using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuomenuBazes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void receptaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receptaiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.duomenysDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duomenysDataSet.Receptai' table. You can move, or remove it, as needed.
            this.receptaiTableAdapter.Fill(this.duomenysDataSet.Receptai);
        }
    }
}