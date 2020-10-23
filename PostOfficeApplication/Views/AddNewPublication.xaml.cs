using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Windows.Shapes;

namespace PostOfficeApplication.Views
{
    /// <summary>
    /// Логика взаимодействия для AddNewPublication.xaml
    /// </summary>
    public partial class AddNewPublication : Window
    {
        public AddNewPublication()
        {
            InitializeComponent();
        } // AddNewPublication

        public AddNewPublication(List<string> lst)
        {
            InitializeComponent();

            foreach (var type in lst)
                CbxType.Items.Add(type);

            CbxType.SelectedIndex = 0;
        } // AddNewPublication

        private void Save_Exec(object sender, ExecutedRoutedEventArgs e)
        {
            double price = 0;
            bool success = double.TryParse(TxbPrice.Text, out price);
            if (success && !string.IsNullOrWhiteSpace(TxbIndex.Text) 
                && !string.IsNullOrWhiteSpace(TxbName.Text))
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

        public string GetPublication()
            => TxbIndex.Text + ";" + TxbName.Text + ";" + 
            TxbPrice.Text + ";" + CbxType.SelectedItem.ToString();
    }
}
