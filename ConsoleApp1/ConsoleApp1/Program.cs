using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public bool IsAdmin { get; }

        public User(bool isAdmin)
        {
            IsAdmin = isAdmin;
        }
    }

    public class Reservation
    {
        public User Uzsakytojas { get; }

        public Reservation(User uzsakytojas)
        {
            Uzsakytojas = uzsakytojas;
        }

        public bool AtsauktiRezervacija(User atsaukejas)
        {
            if (Uzsakytojas == atsaukejas)
            {
                return true;
            }

            if (atsaukejas.IsAdmin)
            {
                return true;
            }

            return false;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}