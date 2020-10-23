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
    /// Логика взаимодействия для SearchPublicationsBySubscriber.xaml
    /// </summary>
    public partial class SearchPublicationsBySubscriber : Window
    {
        public SearchPublicationsBySubscriber()
        {
            InitializeComponent();
        }

        private void Save_Exec(object sender, ExecutedRoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        } // Save_Exec

        private void Cancel_Exec(object sender, ExecutedRoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxbSurname.Text) &&
                !string.IsNullOrWhiteSpace(TxbName.Text) &&
                !string.IsNullOrWhiteSpace(TxbPatronymic.Text))
            {
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Проверьте введенные вами данные.", "Ошибка!",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            } // if
        } // Cancel_Exec

        public string GetFIO()
            => TxbSurname.Text + ";" + TxbName.Text + ";" + TxbPatronymic.Text;
    }
}
