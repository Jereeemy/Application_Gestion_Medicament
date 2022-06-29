using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Application_Gestion_Medicament
{

    /// <summary>
    /// Permet de stocker une categorie de medicament avec comme information son numero de medicament et le libelle du medicament
    /// </summary>
    public class CategorieMedicament : ICRUD<CategorieMedicament>
    {

        /// <summary>
        /// Propriété du numero concernant la categorie du medicament
        /// </summary>

        public int NumeroCategorieMedicament
        {
            get; set;
        }

        /// <summary>
        /// Propriété du libelle concernant la categorie du medicament
        /// </summary>

        public string LibelleCategorieMedicament
        {
            get; set;
        }

        /// <summary>
        /// Constructeur vide de categoriemedicament
        /// </summary>
        public CategorieMedicament()
        {

        }

        /// <summary>
        /// Méthode pour ajouter une categorie de medicament
        /// </summary>
        public void Create()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Méthode pour lire une categorie de medicament
        /// </summary>
        public void Read()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Méthode pour modifier une categorie de medicament
        /// </summary>
        public void Update()
        {
            
        throw new NotImplementedException();
        }

        /// <summary>
        /// Méthode pour supprimer une categorie de medicament
        /// </summary>
        public void Delete()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Méthode pour lire une categorie de medicament
        /// </summary>
        public List<CategorieMedicament> FindAll()
        {
            List<CategorieMedicament> listeGroupes = new List<CategorieMedicament>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("select * from dbo.CATEGORIEMEDICAMENT;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CategorieMedicament uneCategorieMedicament = new CategorieMedicament();
                            uneCategorieMedicament.NumeroCategorieMedicament = reader.GetInt32(0);
                            uneCategorieMedicament.LibelleCategorieMedicament = reader.GetString(1);
                            listeGroupes.Add(uneCategorieMedicament);
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No rows found.", "Important Message");
                    }
                    reader.Close();
                    access.closeConnection();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Important Message");
            }
            return listeGroupes;
        }

        /// <summary>
        /// Méthode pour extraire les categorie d'un medicament d'une BD en appliquant un filtre
        /// </summary>
        /// <param name="criteres"></param>
        /// <returns></returns>
        public List<CategorieMedicament> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }

        List<CategorieMedicament> ICRUD<CategorieMedicament>.FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}
