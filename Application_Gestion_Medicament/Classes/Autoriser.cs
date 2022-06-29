using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Application_Gestion_Medicament
{

    /// <summary>
    /// Permet de créer et de stocker une autorisation avec comme information son medicament, sa maladie, une date et un commentaire 
    /// </summary>
    public class Autoriser : ICRUD<Autoriser>
    {

        /// <summary>
        /// Propriété du medicament
        /// </summary>
        public Medicament unMedicament
        {
            get;set;
        }

        /// <summary>
        /// Propriété d'une maladie
        /// </summary>
        public Maladie uneMaladie
        {
            get;set;
        }

        /// <summary>
        /// Propriété de la date
        /// </summary>
        public DateTime date
        {
            get; set;
        }

        /// <summary>
        /// Propriété du commentaire
        /// </summary>
        public string commentaire
        {
            get; set;
        }

        public Autoriser()
        {
            this.uneMaladie = new Maladie();
            this.unMedicament = new Medicament();
        }

        /// <summary>
        /// Constructeur de autoriser avec tous les paramètres
        /// </summary>
        /// <param name="unMedicament"></param>
        /// <param name="uneMaladie"></param>
        /// <param name="date"></param>
        /// <param name="commentaire"></param>

        public Autoriser(Medicament unMedicament, Maladie uneMaladie, DateTime date, string commentaire)
        {
            this.unMedicament = unMedicament;
            this.uneMaladie = uneMaladie;
            this.date = date;
            this.commentaire = commentaire;
        }

        /// <summary>
        /// Méthode pour ajouter une autorisation
        /// </summary>
        public void Create()
        {
            
            DataAccess access = new DataAccess();
            access.setData($"INSERT INTO AUTORISER(idmedicament, idmaladie, date, commentaire) VALUES({this.unMedicament.IdMedicament}, {this.uneMaladie.IdMaladie}, '{this.date}', '{this.commentaire}')");
        }
        /// <summary>
        /// Méthode pour lire une autorisation
        /// </summary>
        public void Read()
        {

            DataAccess access = new DataAccess();
            SqlDataReader reader;
            if (access.openConnection())
            {
                reader = access.getData("select me.LIBELLEMEDICAMENT,ma.LIBELLEMALADIE, a.DATE,a.COMMENTAIRE, a.IDMALADIE, a.IDMEDICAMENT from autoriser a join maladie ma on ma.idmaladie = a.idmaladie join medicament me on me.idmedicament = a.idmedicament;");
            }   
            access.closeConnection();
        }

        /// <summary>
        /// Méthode pour modifier une autorisation
        /// </summary>
        public void Update()
        {
            List<Autoriser> listeAutoriser = new List<Autoriser>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;

            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("Update AUTORISER " + "set DATE = '" + this.date+ "', COMMENTAIRE = '" + this.commentaire + "'" + "WHERE IDMALADIE = " + this.uneMaladie.IdMaladie + " AND IDMEDICAMENT =" + this.unMedicament.IdMedicament + ";");
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
        /// Méthode pour supprimer une autorisation
        /// </summary>
        public void Delete()
        {
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.openConnection())
                {
                    
                     reader = access.getData("DELETE FROM AUTORISER WHERE DATE ='" + this.date + "';");
                    //access.setData($"DELETE FROM AUTORISER WHERE IDMEDICAMENT ={this.unMedicament.IdMedicament} AND IDMALADIE={this.uneMaladie.IdMaladie} AND DATE='{this.date}'");
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
        /// Méthode pour lire une autorisation
        /// </summary>
        public List<Autoriser> FindAll()
        {
            List<Autoriser> listeGroupes = new List<Autoriser>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("select me.LIBELLEMEDICAMENT,ma.LIBELLEMALADIE, a.DATE,a.COMMENTAIRE, a.IDMALADIE, a.IDMEDICAMENT from autoriser a join maladie ma on ma.idmaladie = a.idmaladie join medicament me on me.idmedicament = a.idmedicament;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Autoriser uneAutorisation = new Autoriser();
                            uneAutorisation.unMedicament.LibelleMedicament = reader.GetString(0);
                            uneAutorisation.uneMaladie.LibelleMaladie = reader.GetString(1);
                            uneAutorisation.date = reader.GetDateTime(2);
                            uneAutorisation.commentaire = reader.GetString(3);
                            uneAutorisation.unMedicament.IdMedicament = reader.GetInt32(4);
                            uneAutorisation.uneMaladie.IdMaladie = reader.GetInt32(5);
                            listeGroupes.Add(uneAutorisation);
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show(" List<Autoriser> Findall No rows found.", "Important Message");
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
        /// Méthode pour extraire les autorisations d'une BD en appliquant un filtre
        /// </summary>
        /// <param name="criteres"></param>
        /// <returns></returns>
        public List<Autoriser> FindBySelection(string criteres)
        {

            throw new NotImplementedException();
        }
    }
}

