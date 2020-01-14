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
using System.Data.Linq.SqlClient;

namespace DuomenuBazesFiltravimas
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Action> Alrgorithm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Alrgorithm = new Dictionary<int, Action>()
            {
                { 1, CodeSearchAlgorithm },
                {2, DateTimePikerSearchAlgorithm },
                {3, AllSearcAlgorithm }
            };

            // ViewOfDataBase.DataSource = db.GetTable<Uzsakymai>();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Alrgorithm[state]();
        }

        private void CodeSearchAlgorithm()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C_20191212KursaiVakariniai\DuomenuBazesFiltravimas\DuomenuBazesFiltravimas\RobotDataBase.mdf;Integrated Security=True";
            DataContext db = new DataContext(connectionString);

            ViewOfDataBase.DataSource = db.GetTable<DrawingInDB>().Where(x => x.Sheet.Uzsakymai.State == "Done" &&
             x.Code.Contains(CodeFiltras.Text))
             .Select(x => new { x.Code, x.Sheet.Uzsakymai.DeliveryDate, x.Sheet.DoneAmount, x.TrueName })
             .OrderByDescending(x => x.DoneAmount);
        }

        private void DateTimePikerSearchAlgorithm()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C_20191212KursaiVakariniai\DuomenuBazesFiltravimas\DuomenuBazesFiltravimas\RobotDataBase.mdf;Integrated Security=True";
            DataContext db = new DataContext(connectionString);

            ViewOfDataBase.DataSource = db.GetTable<DrawingInDB>().Where(x => x.Sheet.Uzsakymai.State == "Done" &&
            x.Sheet.Uzsakymai.DeliveryDate >= dateTimePicker1.Value && x.Sheet.Uzsakymai.DeliveryDate <= dateTimePicker2.Value)
             .Select(x => new { x.Code, x.Sheet.Uzsakymai.DeliveryDate, x.Sheet.DoneAmount, x.TrueName })
             .OrderByDescending(x => x.DoneAmount);
        }

        private void AllSearcAlgorithm()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C_20191212KursaiVakariniai\DuomenuBazesFiltravimas\DuomenuBazesFiltravimas\RobotDataBase.mdf;Integrated Security=True";
            DataContext db = new DataContext(connectionString);

            ViewOfDataBase.DataSource = db.GetTable<DrawingInDB>().Where(x => x.Sheet.Uzsakymai.State == "Done" &&
            x.Sheet.Uzsakymai.DeliveryDate >= dateTimePicker1.Value &&
            x.Sheet.Uzsakymai.DeliveryDate <= dateTimePicker2.Value &&
             x.Code.Contains(CodeFiltras.Text))
             .Select(x => new { x.Code, x.Sheet.Uzsakymai.DeliveryDate, x.Sheet.DoneAmount, x.TrueName })
             .OrderByDescending(x => x.DoneAmount);
        }

        private void Method()
        {
        }

        private void MethodA(int A)
        {
        }

        private void ActionToPLace()
        {
            Action act = Method;
            Action<int> actr = MethodA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pavyzdys pavyzdys = new Pavyzdys();
        }

        private bool CodeFilterTrue = false;
        private bool DateFilter = false;

        private void CodeFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (CodeFilter.Checked)
            {
                CodeFilterTrue = true;
            }
            else
            {
                CodeFilterTrue = false;
            }
            DetermenState();
        }

        private void DateTimeFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (DateTimeFilter.Checked)
            {
                DateFilter = true;
            }
            else
            {
                DateFilter = false;
            }
            DetermenState();
        }

        private int state;

        private void DetermenState()
        {
            if (DateFilter)
            {
                state = 2;
            }

            if (CodeFilterTrue)
            {
                state = 1;
            }

            if (DateFilter && CodeFilterTrue)
            {
                state = 3;
            }
        }
    }
}