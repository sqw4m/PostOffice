using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace PostOfficeApplication.Views
{
    /// <summary>
    /// Логика взаимодействия для AddNewSubscription.xaml
    /// </summary>
    public partial class AddNewSubscription : Window
    {
        public AddNewSubscription()
        {
            InitializeComponent();
        } // AddNewSubscription
        public AddNewSubscription(List<string> streets, List<string> publications)
        {
            InitializeComponent();

            foreach (var street in streets)
                CbxStreets.Items.Add(street);
            CbxStreets.SelectedIndex = 0;

            foreach (var publication in publications)
                CbxPublication.Items.Add(publication);
            CbxPublication.SelectedIndex = 0;

            CbxTerm.Items.Add("3");
            CbxTerm.Items.Add("6");
            CbxTerm.Items.Add("12");
            CbxTerm.Items.Add("24");
            CbxTerm.SelectedIndex = 0;
        } // AddNewSubscription

        private void Save_Exec(object sender, ExecutedRoutedEventArgs e)
        {
            if (int.TryParse(TxbHouse.Text, out _) && !string.IsNullOrWhiteSpace(TxbSurname.Text)
                && !string.IsNullOrWhiteSpace(TxbName.Text)
                && !string.IsNullOrWhiteSpace(TxbPatronymic.Text)
                && !string.IsNullOrWhiteSpace(TxbHouse.Text)
                && !string.IsNullOrWhiteSpace(TxbApartament.Text)
                && DprDate.SelectedDate != null)
            {
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Проверьте введенные вами данные.", "Ошибка!",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            } // if
        } // Save_Exec

        private void Cancel_Exec(object sender, ExecutedRoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        } // Cancel_Exec

        public string GetSubscription()
            => TxbSurname.Text + ";" + TxbName.Text + ";" + TxbPatronymic.Text + ";" +
            CbxStreets.Text + ";" + TxbHouse.Text + ";" + TxbApartament.Text + ";" +
            CbxPublication.Text + ";" + DprDate.SelectedDate + ";" + CbxTerm.Text;
    }
}
