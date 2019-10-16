﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetier.Tests
{
    [TestClass()]
    public class DossierTests
    {
        private Dossier InitialiseDossier()
        {
            Dossier unDossier = new Dossier("Robert", "Jean", new DateTime(1980, 12, 3));
            unDossier.AjoutePrestation("Libelle P3", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            unDossier.AjoutePrestation("Libelle P1", new DateTime(2015, 9, 1, 12, 0, 0), new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202"));
            unDossier.AjoutePrestation("Libelle P2", new DateTime(2015, 9, 8, 12, 0, 0), new IntervenantExterne("Sainz", "olivier", "Radiologue", "Toulon", "0303030303"));
            unDossier.AjoutePrestation("Libelle P4", new DateTime(2015, 9, 20, 12, 0, 0), new Intervenant("Maurin", "Joëlle"));
            unDossier.AjoutePrestation("Libelle P6", new DateTime(2015, 9, 8, 9, 0, 0), new Intervenant("Blanchard", "Michel"));
            unDossier.AjoutePrestation("Libelle P5", new DateTime(2015, 9, 10, 6, 0, 0), new Intervenant("Tournier", "Hélène"));

            return unDossier;
        }

        [TestMethod()]
        public void GetNbPrestationsExternesTest()
        {
            Dossier unDossier = InitialiseDossier();
            Assert.AreEqual(2, unDossier.GetNbPrestationsExternes(), "Le nombre de prestations externes doit être égal à 2");
        }

        [TestMethod()]
        public void GetNbJoursSoinsTest()
        {
            Dossier unDossier = InitialiseDossier();
            Assert.AreEqual(4, unDossier.GetNbJoursSoins(), "Le nombre de jours de soins doit être égal à 4" );
        }
    }
}