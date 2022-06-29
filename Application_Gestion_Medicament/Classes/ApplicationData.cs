using System;
using System.Collections.Generic;
using System.Text;

namespace Application_Gestion_Medicament
{

    /// <summary>
    /// Permet de charger les données d'une BD
    /// </summary>
    public class ApplicationData
    {

        /// <summary>
        /// Déclare une liste de maladie
        /// </summary>
        public static List<Maladie> listeMaladie
        {
            get;
            set;
        }

        /// <summary>
        /// Déclare une liste de medicament
        /// </summary>
        public static List<Medicament> listeMedicament
        {
            get;
            set;
        }

        /// <summary>
        /// Déclare une liste de categorie de medicament
        /// </summary>
        public static List<CategorieMedicament> listeCategorieMedicament
        {
            get;
            set;
        }

        /// <summary>
        /// Déclare une liste d'autorisation
        /// </summary>
        public static List<Autoriser> listeAutoriser
        {
            get;
            set;
        }

        /// <summary>
        /// Méthode pour affecter aux listes définit précédement les données contenu dans la BD
        /// </summary>
        public static void loadApplicationData()
        {

            Maladie uneMaladie = new Maladie();
            listeMaladie = uneMaladie.FindAll();

            Medicament unMedicament = new Medicament();
            listeMedicament = unMedicament.FindAll();

            CategorieMedicament uneCategorieMedicament = new CategorieMedicament();
            listeCategorieMedicament = uneCategorieMedicament.FindAll();

            Autoriser uneAutorisation = new Autoriser();
            listeAutoriser = uneAutorisation.FindAll();

            
        }
    }
}
