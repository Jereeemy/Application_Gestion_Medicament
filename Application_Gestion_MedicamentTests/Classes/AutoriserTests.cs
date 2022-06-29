using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application_Gestion_Medicament;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application_Gestion_Medicament.Tests
{
    [TestClass()]
    public class AutoriserTests
    {
       
        [TestMethod()]
        public void AutoriserTest()
        {
            Autoriser uneAutorisationVide = new Autoriser();
            Assert.AreEqual(uneAutorisationVide, (new Maladie(), new Medicament()));
            Autoriser uneAutorisationSansCommentaire = new Autoriser(new Medicament(), new Maladie(), new DateTime(2022, 06, 19), null);
            Autoriser uneAutorisationAvecCommentaire = new Autoriser(new Medicament(), new Maladie(), new DateTime(2022, 06, 19), "par voie oral");
            Assert.AreNotEqual(uneAutorisationSansCommentaire,uneAutorisationAvecCommentaire);

        }

        [TestMethod()]
        public void CreateTest()
        {
            Autoriser uneAutorisationSansCommentaire = new Autoriser(new Medicament(), new Maladie(), new DateTime(2022, 06, 19), null);
            uneAutorisationSansCommentaire.Create();
            Autoriser uneAutorisationAvecCommentaire = new Autoriser(new Medicament(), new Maladie(), new DateTime(2022, 06, 19), "par voie oral");
            uneAutorisationAvecCommentaire.Create();
        }

        [TestMethod()]
        public void ReadTest()
        {
            Autoriser uneAutorisationSansCommentaire = new Autoriser(new Medicament(), new Maladie(), new DateTime(2022, 06, 19), null);
            uneAutorisationSansCommentaire.Read();
            Autoriser uneAutorisationAvecCommentaire = new Autoriser(new Medicament(), new Maladie(), new DateTime(2022, 06, 19), "par voie oral");
            uneAutorisationAvecCommentaire.Read();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Autoriser uneAutorisationModifier = new Autoriser(new Medicament(), new Maladie(), new DateTime(2022, 06, 19), null);
            uneAutorisationModifier.date = new DateTime(2023, 07, 20);
            uneAutorisationModifier.commentaire = "par voie nasal";
            uneAutorisationModifier.Update();
            Assert.AreEqual(uneAutorisationModifier, new Autoriser(new Medicament(), new Maladie(), new DateTime(2023, 0, 20), "par voie nasal"));
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Autoriser uneAutorisationSupprimer = new Autoriser(new Medicament(), new Maladie(), new DateTime(2022, 06, 19), null);
            uneAutorisationSupprimer.Delete();
        }

        [TestMethod()]
        public void NombreAutorisationFindAllTest()
        {
            //Arrange
            //il doit y avoir 8 autorisations dans la base
            Autoriser uneAutorisation = new Autoriser();
            //Act
            ApplicationData.listeAutoriser = uneAutorisation.FindAll();
            //Assert
            int nombreAutorisation = ApplicationData.listeAutoriser.Count;
            Assert.AreEqual(nombreAutorisation, 8);
        }
    }
}