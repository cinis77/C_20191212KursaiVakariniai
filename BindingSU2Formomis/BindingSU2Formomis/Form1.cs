using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingSU2Formomis
{
    public partial class Form1 : Form
    {
        private DuomenuSurisimas surisimas;

        public Form1()
        {
            InitializeComponent();
            surisimas = new DuomenuSurisimas();
            Vardas.DataBindings.Add("Text", surisimas, "Vardas", false, DataSourceUpdateMode.OnPropertyChanged);
            Pavarde.DataBindings.Add("Text", surisimas, "Pavarde", false, DataSourceUpdateMode.OnPropertyChanged);
            Amzius.DataBindings.Add("Text", surisimas, "Amzius", false, DataSourceUpdateMode.OnPropertyChanged);
            DarboViete.DataBindings.Add("Text", surisimas, "DarboViete", false, DataSourceUpdateMode.OnPropertyChanged);
            Pareigos.DataBindings.Add("Text", surisimas, "Pareigos", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaTextas form = new FormaTextas(surisimas);
            form.Show();
        }
    }
}