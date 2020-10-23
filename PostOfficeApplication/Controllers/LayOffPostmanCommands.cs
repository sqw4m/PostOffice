﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PostOfficeApplication.Controllers
{
    public class LayOffPostmanCommands
    {
        // свойство - команда Сохранить
        public static RoutedCommand Save { get; set; }

        // свойство - команда Отменить
        public static RoutedCommand Cancel { get; set; }

        static LayOffPostmanCommands()
        {
            Type bindTo = typeof(MainWindow);

            // привязка команды Save
            Save = new RoutedCommand("Save", bindTo);

            // привязка команды Cancel
            Cancel = new RoutedCommand("Cancel", bindTo);
        } // LayOffPostmanCommands
    } // class LayOffPostmanCommands
}
