using PostOffice_Model;
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
    /// Логика взаимодействия для SearchPostmanBySubscribAddress.xaml
    /// </summary>
    public partial class SearchPostmanBySubscribAddress : Window
    {
        public SearchPostmanBySubscribAddress()
        {
            InitializeComponent();
        }
        public SearchPostmanBySubscribAddress(List<string> lst)
        {
            InitializeComponent();

            foreach (var street in lst)
                CbxStreet.Items.Add(street);

            CbxStreet.SelectedIndex = 0;
        }

        private void Save_Exec(object sender, ExecutedRoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxbHouse.Text) &&
                !string.IsNullOrWhiteSpace(TxbApartaments.Text))
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

        public string GetAddress()
            => CbxStreet.Text + ";" + TxbHouse.Text + ";" + TxbApartaments.Text;
    }
}
