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
using System.Windows.Threading;

namespace PostOfficeApplication.Views
{
    /// <summary>
    /// Логика взаимодействия для SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        private DispatcherTimer _closeTimer;
        public SplashScreen(MainWindow mw)
        {
            _closeTimer = new DispatcherTimer();
            _closeTimer.Tick += new EventHandler(((object sender, EventArgs e) => { Close(); }));
            _closeTimer.Interval = new TimeSpan(0, 0, 5);
            InitializeComponent();
            _closeTimer.Start();
        }
    }
}
