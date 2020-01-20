using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingasSuForma
{
    public partial class Form1 : Form
    {
        private DataBindingClass Bind;

        public Form1()
        {
            InitializeComponent();
            Bind = new DataBindingClass();
            textoLaukas.DataBindings.Add("Text", Bind, "Tekstas", false, DataSourceUpdateMode.OnPropertyChanged);
            Labelis.DataBindings.Add("Text", Bind, "Tekstas");
        }
    }
}