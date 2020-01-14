using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuomenuBazesFiltravimas
{
    internal class Pavyzdys
    {
        private void MethodAAAA()
        {
            System.Windows.Forms.MessageBox.Show("Metodas iskviestas");
        }

        public Pavyzdys()
        {
            ISkv isk = new ISkv(MethodAAAA);
            isk.Iskviesti();
        }
    }

    internal class ISkv
    {
        private Action action;

        public ISkv(Action a)
        {
            action = a + a;
        }

        public void Iskviesti()
        {
            action();
        }
    }
}