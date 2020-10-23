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
    /// Логика взаимодействия для AddNewPostman.xaml
    /// </summary>
    public partial class AddNewPostman : Window
    {
        public AddNewPostman()
        {
            InitializeComponent();
        }

        private void Save_Exec(object sender, ExecutedRoutedEventArgs e)
        {
            bool isPlots = false;

            foreach (CheckBox checkBox in SplPlots1.Children)
                if (checkBox.IsChecked ?? true)
                    isPlots = true;

            foreach (CheckBox checkBox in SplPlots2.Children)
                if (checkBox.IsChecked ?? true)
                    isPlots = true;

            if (isPlots && !string.IsNullOrWhiteSpace(TxbSurname.Text)
                && !string.IsNullOrWhiteSpace(TxbName.Text)
                && !string.IsNullOrWhiteSpace(TxbPatronymic.Text))
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

        public string GetPostman()
        {
            string plots = string.Empty;

            foreach (CheckBox checkBox in SplPlots1.Children)
                if (checkBox.IsChecked ?? true)
                    plots += checkBox.Content.ToString() + '/';

            foreach (CheckBox checkBox in SplPlots2.Children)
                if (checkBox.IsChecked ?? true)
                    plots += checkBox.Content.ToString() + '/';

            return TxbSurname.Text + ';' + TxbName.Text + ';' + TxbPatronymic.Text + ';' + plots;
        } // GetPostman
    }
}
