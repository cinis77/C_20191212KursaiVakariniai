using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSuException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserName.Text != "DR")
                {
                    throw new Exception("Blogas vartotojo vardas");
                }
                if (Password.Text != "123456")
                {
                    throw new Exception("Blogas slaptažodis");
                }

                MessageBox.Show("Prisijungti pavyko");
            }
            catch (ArgumentNullException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '1';
            }
        }
    }
}