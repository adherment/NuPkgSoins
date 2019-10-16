using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetier.Tests
{
    [TestClass()]
    public class PrestationTests
    {
        [TestMethod()]
        public void CompareToTest()
        {
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 15, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation unePrestation2 = new Prestation("XX", new DateTime(2015, 9, 10, 17, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(0, unePrestation.CompareTo(unePrestation2),"Les dates doivent être égales");
        }

        [TestMethod()]
        public void CompareToTestV2()
        {
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 15, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation unePrestation2 = new Prestation("XX", new DateTime(2014, 9, 10, 17, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(1, unePrestation.CompareTo(unePrestation2), "La date de la 1ere presta doit être postérieure à la date de la 2eme presta");
        }

        [TestMethod()]
        public void CompareToTestV3()
        {
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 15, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation unePrestation2 = new Prestation("XX", new DateTime(2016, 9, 10, 17, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(-1, unePrestation.CompareTo(unePrestation2), "La date de la 1ere presta doit être antérieure à la date de la 2eme presta");
        }

        [TestMethod()]
        public void SommePourRienTest()
        {
            int a = 3;
            int b = 5;
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(8, unePrestation.SommePourRien(a, b), "la somme doit être égale à 8");
        }
    }
}