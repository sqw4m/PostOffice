
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PostOfficeApplication.Controllers
{
    public class ReceiptCommands
    {
        // свойство - команда Отменить
        public static RoutedCommand Cancel { get; set; }

        static ReceiptCommands()
        {
            Type bindTo = typeof(MainWindow);

            // привязка команды Cancel
            Cancel = new RoutedCommand("Cancel", bindTo);
        } // ReceiptCommands
    } // class ReceiptCommands
}
