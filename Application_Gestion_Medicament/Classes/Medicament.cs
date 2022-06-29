using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Application_Gestion_Medicament
{

    /// <summary>
    /// Permet de stocker un medicament avec comme information son id, son  numero et son libelle
    /// </summary>
    public class Medicament : ICRUD<Medicament>
    {

        /// <summary>
        /// Propriété de l'id medicament
        /// </summary>
        public int IdMedicament
        {
            get; set;
        }

        /// <summary>
        /// Propriété du numero concernant la categorie du medicament
        /// </summary>
        public int NumeroCategorieMedicament
        {
            get; set;
        }

        /// <summary>
        /// Propriété du libelle medicament
        /// </summary>
        public string LibelleMedicament
        {
            get; set;
        }

        /// <summary>
        /// Constructeur vide de medicament
        /// </summary>
        public Medicament()
        {

        }

        /// <summary>
        /// Constructeur de medicament avec son id, son libellé et son numéro catégorie médicament
        /// </summary>
        public Medicament(int idMedicament, int numeroCategorieMedicament, string libelleMedicament)
        {
            IdMedicament = idMedicament;
            NumeroCategorieMedicament = numeroCategorieMedicament;
            LibelleMedicament = libelleMedicament;
        }

        /// <summary>
        /// Méthode pour ajouter un medicament
        /// </summary>
        public void Create()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Méthode pour lire un medicament
        /// </summary>
        public void Read()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Méthode pour modifier un medicament
        /// </summary>

        public void Update()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Méthode pour supprimer une maladie
        /// </summary>
        public void Delete()
        {
             DataAccess access = new DataAccess();
             SqlDataReader reader;
             try
             {
                 if (access.openConnection())
                 {
                     reader = access.getData("DELETE FROM MEDICAMENT WHERE IDMEDICAMENT ='" + this.IdMedicament + "';");
                     reader.Read();
                     reader.Close();
                     access.closeConnection();
                 }
             }
             catch (Exception ex)
             {
                 System.Windows.MessageBox.Show(ex.Message, "Important Message");
             }
            
        }
        public List<Medicament> FindAll()
        {
            List<Medicament> listeGroupes = new List<Medicament>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("select * from dbo.MEDICAMENT;");

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Medicament unMedicament = new Medicament();
                            unMedicament.IdMedicament = reader.GetInt32(0);
                            unMedicament.NumeroCategorieMedicament = reader.GetInt32(1);
                            unMedicament.LibelleMedicament = reader.GetString(2);
                            listeGroupes.Add(unMedicament);
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show(" List<Medicaments > FindallNo rows found.", "Important Message");
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
        /// Méthode pour extraire les medicaments d'une BD en appliquant un filtre
        /// </summary>
        /// <param name="criteres"></param>
        /// <returns></returns>

        List<Medicament> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }

        List<Medicament> ICRUD<Medicament>.FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}
