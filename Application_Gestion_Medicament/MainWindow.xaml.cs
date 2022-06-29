using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Application_Gestion_Medicament
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Maladie> LesMaladies { get; set; }
        public ObservableCollection<Autoriser> LesAutorisations { get; set; }
        public ObservableCollection<CategorieMedicament> LesCategoriesMedicaments { get; set; }
        public ObservableCollection<Medicament> LesMedicaments { get; set; }

        //private ApplicationData applicationData;
        public MainWindow()
        {
            LesMaladies = new ObservableCollection<Maladie>();
            LesAutorisations = new ObservableCollection<Autoriser>();
            LesMedicaments = new ObservableCollection<Medicament>();
            LesCategoriesMedicaments = new ObservableCollection<CategorieMedicament>();
            InitializeComponent();
            Actualise();
        }

        
        public void Actualise()
        {
            ApplicationData.loadApplicationData();
            DataGridAutorisation.ItemsSource = ApplicationData.listeAutoriser;
        }

        /*public void Actualise2()
        {
            this.applicationData = new ApplicationData();
            this.DataContext = applicationData;
        }*/


        private void ButtonSupprimer_Click(object sender, RoutedEventArgs e)
        {

            if ((Autoriser)this.DataGridAutorisation.SelectedItem != null)
            {
                foreach (Autoriser m in this.DataGridAutorisation.SelectedItems)
                {
                    m.Delete();
                   
                }
                Actualise();
            }
            else MessageBox.Show("Veuillez Choisir un element a supprimer", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            
        }

       private void ButtonAjouter_Click(object sender, RoutedEventArgs e)
        {
            if ((Medicament)this.ListViewMedicament.SelectedItem != null && (Maladie)this.ListViewMaladie.SelectedItem != null && this.DatePickerDate.SelectedDate.Value.ToString() != null)
            {
                Medicament medicamentChoisi = (Medicament)this.ListViewMedicament.SelectedItem;
                Maladie maladieChoisi = (Maladie)this.ListViewMaladie.SelectedItem;
                String dateChoisi = this.DatePickerDate.SelectedDate.Value.ToString();
                String commentaireChoisi = (String)this.TextboxCommentaire.Text;
                Autoriser autorisation = new Autoriser(medicamentChoisi, maladieChoisi, DateTime.Parse(dateChoisi), commentaireChoisi);
                autorisation.Create();
                Actualise();
            }
            else MessageBox.Show("Veuillez bien remplir au minima le médicament, la maladie et la date", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);


        }

        private void ButtonModifier_Click(object sender, RoutedEventArgs e)
         {
            if (DataGridAutorisation.SelectedItems.Count == 1)
            {
                ((Autoriser)this.DataGridAutorisation.SelectedItem).commentaire = TextboxCommentaire.Text;
                ((Autoriser)this.DataGridAutorisation.SelectedItem).date = DatePickerDate.SelectedDate.Value;
                ((Autoriser)this.DataGridAutorisation.SelectedItem).Update();
                Actualise();
            }
            else MessageBox.Show("Veuillez Choisir un seul et unique élément", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}