using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleloto
{
    public partial class Form1 : Form
    {
        private Random rng;
        private List<TextBox> visiTextBoxai;

        public Form1()
        {
            InitializeComponent();
            rng = new Random();
            visiTextBoxai = new List<TextBox>();
            foreach (Control item in BilietasGroup.Controls)
            {
                if (item is TextBox)
                {
                    visiTextBoxai.Add((TextBox)item);
                    // int sk = 3 ; (double)sk/2
                }
            }
        }

        private void Generuoti_Click(object sender, EventArgs e)
        {
            TextBox[] melyni = { M1, M2, M3, M4, M5 };
            TextBox[] juodi = { J1, J2, J3, J4, J5 };
            TextBox[] raudoni = { R1, R2, R3, R4, R5 };
            TextBox[] geltoni = { G1, G2, G3, G4, G5 };
            TextBox[] zali = { Z1, Z2, Z3, Z4, Z5 };
            PildymasTextBox(melyni, 1, 16);
            PildymasTextBox(juodi, 16, 31);
            PildymasTextBox(raudoni, 31, 46);
            PildymasTextBox(geltoni, 46, 61);
            PildymasTextBox(zali, 61, 76);
        }

        private void PildymasTextBox(TextBox[] spalva, int a, int b)
        {
            int i = 0;
            while (i < 5)
            {
                int kamuoliukas = rng.Next(a, b);
                bool JauYra = false;
                foreach (var item in spalva)
                {
                    if (item.Text == kamuoliukas.ToString())
                    {
                        JauYra = true;
                        break;
                    }
                }
                if (!JauYra)
                {
                    spalva[i].Text = kamuoliukas.ToString();
                    i++;
                }
            }
        }

        private void ZaistiButon_Click(object sender, EventArgs e)
        {
            IšridentiKamuoliukai.Text = string.Empty;
            int i = 0;
            List<int> isridenti = new List<int>();
            while (i < 45)
            {
                int isridentasKamuoliukas = rng.Next(1, 76);
                bool JauYra = false;
                foreach (var item in isridenti)
                {
                    if (item == isridentasKamuoliukas)
                    {
                        JauYra = true;
                        break;
                    }
                }
                if (!JauYra)
                {
                    isridenti.Add(isridentasKamuoliukas);
                    IšridentiKamuoliukai.Text += isridentasKamuoliukas + " ";
                    RadimasSkaiciaus(isridentasKamuoliukas);
                    i++;
                }
            }
        }

        private void RadimasSkaiciaus(int sk)
        {
            foreach (var item in visiTextBoxai)
            {
                if (item.Text == sk.ToString())
                {
                    item.BackColor = Color.Green;
                }
            }
        }
    }
}