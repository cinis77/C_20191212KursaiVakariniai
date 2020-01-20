using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BindingSU2Formomis
{
    public class DuomenuSurisimas : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region Property region

        private string _Vardas;

        public string Vardas
        {
            get
            {
                return _Vardas;
            }
            set
            {
                if (value != _Vardas)
                {
                    _Vardas = value;
                    NotifyChangedProperty("Vardas");
                }
            }
        }

        private string _Pavarde;

        public string Pavarde
        {
            get
            {
                return _Pavarde;
            }
            set
            {
                if (value != _Pavarde)
                {
                    _Pavarde = value;
                    NotifyChangedProperty("Vardas");
                }
            }
        }

        private string _Amzius;

        public string Amzius
        {
            get
            {
                return _Amzius;
            }
            set
            {
                if (value != _Amzius)
                {
                    _Amzius = value;
                    NotifyChangedProperty("Amzius");
                }
            }
        }

        private string _DarboViete;

        public string DarboViete
        {
            get
            {
                return _DarboViete;
            }
            set
            {
                if (value != _DarboViete)
                {
                    _DarboViete = value;
                    NotifyChangedProperty("DarboViete");
                }
            }
        }

        private string _Pareigos;

        public string Pareigos
        {
            get
            {
                return _Pareigos;
            }
            set
            {
                if (value != _Pareigos)
                {
                    _Pareigos = value;
                    NotifyChangedProperty("Pareigos");
                }
            }
        }

        #endregion Property region

        private void NotifyChangedProperty(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}