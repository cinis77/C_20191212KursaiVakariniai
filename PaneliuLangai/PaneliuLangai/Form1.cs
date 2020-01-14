using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace PaneliuLangai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var table = GenericGetData<Uzsakymai>.GetDataFromDB(x => x.State != "Done");
            Panel last = null;
            foreach (var item in table)
            {
                Panel panel = new Panel();
                panel.Size = new Size(500, 250);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.BackColor = Color.White;
                panel.Location = CalculatePanelPosition(last);
                panel.DoubleClick += PanelDoubleClick;
                panel.Name = item.Id.ToString();
                CreateLabel(item.OrderNumber, panel);
                foreach (Control contr in panel.Controls)
                {
                    contr.DoubleClick += PanelDoubleClick;
                    contr.Name = item.Id.ToString();
                }
                last = panel;
                MainWindowPanel.Controls.Add(panel);
            }
        }

        private void CreateLabel(string text, Panel toAdd)
        {
            Label lab = new Label();
            lab.Text = text;
            lab.TextAlign = ContentAlignment.MiddleCenter;
            lab.Location = new Point(20, toAdd.Size.Height / 2);
            toAdd.Controls.Add(lab);
        }

        private void PanelDoubleClick(object sender, EventArgs eventArgs)
        {
            Control control = (Control)sender;
            int senderId = int.Parse(control.Name);
            MainWindowPanel.Controls.Clear();

            var table = GenericGetData<Sheet>.GetDataFromDB(x => x.UzsakymoID == senderId);
            Panel last = null;
            foreach (var item in table)
            {
                Panel panel = new Panel();
                panel.Size = new Size(500, 250);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.BackColor = Color.White;
                panel.Location = CalculatePanelPosition(last);

                panel.Name = item.Id.ToString();

                last = panel;
                MainWindowPanel.Controls.Add(panel);
            }
        }

        private Point CalculatePanelPosition(Panel lastPanel)
        {
            if (lastPanel == null)
            {
                return new Point(20, 20);
            }

            if (lastPanel.Location.X + 20 + 20 + lastPanel.Size.Width + lastPanel.Size.Width
                <= MainWindowPanel.Size.Width)
            {
                return new Point(lastPanel.Location.X + 20 + lastPanel.Size.Width, lastPanel.Location.Y);
            }

            return new Point(20, lastPanel.Location.Y + lastPanel.Size.Height + 20);
        }
    }

    internal class GenericGetData<T> where T : class
    {
        private static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C_20191212KursaiVakariniai\PaneliuLangai\PaneliuLangai\RobotDataBase.mdf;Integrated Security=True";

        private GenericGetData()
        {
        }

        public static IEnumerable<T> GetDataFromDB(Func<T, bool> filter)
        {
            DataContext db = new DataContext(ConnectionString);
            return db.GetTable<T>().Where(filter);
        }

        public static IEnumerable<T> GetDataFromDB()
        {
            DataContext db = new DataContext(ConnectionString);
            return db.GetTable<T>();
        }
    }
}