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
    /// Логика взаимодействия для Receipt.xaml
    /// </summary>
    public partial class Receipt : Window
    {
        public Receipt()
        {
            InitializeComponent();
        } // Receipt
        public Receipt(string subscriber, string publication, 
            string term, string price)
        {
            InitializeComponent();
            TxbSubscriber.Text += " " + subscriber;
            TxbPublication.Text += " " + publication;
            TxbTerm.Text += " " + term + " мес.";
            TxbPrice.Text += " " + price + " руб.";
        } // Receipt

        private void Cancel_Exec(object sender, ExecutedRoutedEventArgs e)
            => Close();
    }
}
