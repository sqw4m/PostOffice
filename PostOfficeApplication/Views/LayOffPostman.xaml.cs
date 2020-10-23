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
    /// Логика взаимодействия для LayOffPostman.xaml
    /// </summary>
    public partial class LayOffPostman : Window
    {
        public LayOffPostman()
        {
            InitializeComponent();
        } // LayOffPostman

        public LayOffPostman(List<string> lst)
        {
            InitializeComponent();

            foreach (var postman in lst)
                CbxPostman.Items.Add(postman);

            CbxPostman.SelectedIndex = 0;
        } // LayOffPostman

        private void Save_Exec(object sender, ExecutedRoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        } // Save_Exec

        private void Cancel_Exec(object sender, ExecutedRoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        } // Cancel_Exec

        public string GetPostman()
            => CbxPostman.Text;
    }
}
