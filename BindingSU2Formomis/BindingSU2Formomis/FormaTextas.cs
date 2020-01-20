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
    public partial class FormaTextas : Form
    {
        public FormaTextas(DuomenuSurisimas surisimas)
        {
            InitializeComponent();
            Vardas.DataBindings.Add("Text", surisimas, "Vardas", false, DataSourceUpdateMode.OnPropertyChanged);
            Pavarde.DataBindings.Add("Text", surisimas, "Pavarde", false, DataSourceUpdateMode.OnPropertyChanged);
            Amzius.DataBindings.Add("Text", surisimas, "Amzius", false, DataSourceUpdateMode.OnPropertyChanged);
            DarboViete.DataBindings.Add("Text", surisimas, "DarboViete", false, DataSourceUpdateMode.OnPropertyChanged);
            Pareigos.DataBindings.Add("Text", surisimas, "Pareigos", false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}