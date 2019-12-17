using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace Rezervation.UnitTest
{
    [TestClass]
    public class RezervationUnitTest
    {
        [TestMethod]
        public void AtsauktiRezervacija_UserIsAdmin_ReturnTrue()
        {
            ///Apsirasom reikalingus testavimo elementus
            User user = new User(isAdmin: true);

            Reservation reservation = new Reservation(new User(false));
            ///Gaunam rezultata
            var rezultatas = reservation.AtsauktiRezervacija(user);

            /// Tikrinam rezultata
            ///
            Assert.IsTrue(rezultatas);
        }

        [TestMethod]
        public void AtsauktiRezervacija_AtsaukiaUzsakytojas_ReturnTrue()
        {
            User user = new User(isAdmin: false);

            Reservation rezervacija = new Reservation(user);
            var rezultatas = rezervacija.AtsauktiRezervacija(user);

            Assert.IsTrue(rezultatas);
        }

        [TestMethod]
        public void AtsauktiRezervacija_AtsaukiaKitasUseris_ReturnFalse()
        {
            Reservation reservation = new Reservation(new User(false));

            var rezultatas = reservation.AtsauktiRezervacija(new User(false));

            Assert.IsFalse(rezultatas);
        }
    }
}