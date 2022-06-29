using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Application_Gestion_Medicament
{

    /// <summary>
    /// Permet de stocker une maladie avec son id, son libelle
    /// </summary>
    public class Maladie : ICRUD<Maladie>
    {

        /// <summary>
        /// Propriété de l'id maladie
        /// </summary>

        public int IdMaladie
        {
            get; set;
        }

        /// <summary>
        /// Propriété du libelle maladie
        /// </summary>
        public string LibelleMaladie
        {
            get; set;
        }

        /// <summary>
        /// Constructeur vide de maladie
        /// </summary>

        public Maladie()
        { 
        }
        /// <summary>
        /// Constructeur de medicament avec son id, son libellé
        /// </summary>
        public Maladie(int idMaladie, string libelleMaladie)
        {
            IdMaladie = idMaladie;
            LibelleMaladie = libelleMaladie;
        }

        /// <summary>
        /// Méthode pour ajouter une maladie
        /// </summary>
        public void Create()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Méthode pour lire une maladie
        /// </summary>
        public void Read()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Méthode pour modifier une maladie
        /// </summary>
        public void Update()
        {
            List<Maladie> listeMaladie = new List<Maladie>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;

            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("Update MALADIE set LIBELLEMALADIE = '" + LibelleMaladie + "' where IDMALADIE =" + this.IdMaladie);
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
                    reader = access.getData("DELETE FROM MALADIE WHERE IDMALADIE ='" + this.IdMaladie + "';");
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

        // <summary>
        /// Méthode pour lire une maladie
        /// </summary>
        public List<Maladie> FindAll()
        {
            List<Maladie> listeGroupes = new List<Maladie>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("select * from dbo.MALADIE;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Maladie uneMaladie = new Maladie();
                            uneMaladie.IdMaladie = reader.GetInt32(0);
                            uneMaladie.LibelleMaladie = reader.GetString(1);
                            listeGroupes.Add(uneMaladie);
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show(" List<Maladie> Findall- No rows found.", "Important Message");
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
        /// Méthode pour extraire les maladies d'une BD en appliquant un filtre
        /// </summary>
        /// <param name="criteres"></param>
        /// <returns></returns>
        public List<Maladie> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }



     
    }
}
