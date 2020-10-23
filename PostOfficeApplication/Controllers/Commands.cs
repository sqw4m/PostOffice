using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PostOfficeApplication.Controllers
{
    public class Commands
    {
        // команда Exit
        public static RoutedCommand Exit { get; set; }

        // команда About
        public static RoutedCommand About { get; set; }

        // вывести все подписки
        public static RoutedCommand ShowSubscriptions { get; set; }

        // вывести все переодические печатные издания
        public static RoutedCommand ShowPublications { get; set; }

        // вывести всех подписчиков
        public static RoutedCommand ShowSubscribers { get; set; }

        // вывести всех почтальонов
        public static RoutedCommand ShowPostmen { get; set; }

        // вывести все районы и обслуживающие их почтальоны
        public static RoutedCommand ShowPlots { get; set; }

        // оформить подписку
        public static RoutedCommand Subscribe { get; set; }

        // добавить новое подписное издание
        public static RoutedCommand AddNewPublication { get; set; }

        // определить почтальона обслуживающего подписчика по адресу
        public static RoutedCommand IdentifyPostman { get; set; }

        // определить газеты которые выписывает гражданин
        // с указанной фамилией, именем, отчеством
        public static RoutedCommand IdentifyPublications { get; set; }

        // средний срок подписки по каждому изданию
        public static RoutedCommand AverageSubscriptionTerm { get; set; }

        // принять почтальона на работу
        public static RoutedCommand AddNewPostman { get; set; }

        // уволить почтальона
        public static RoutedCommand LayOffPostman { get; set; }

        static Commands()
        {
            Type bindTo = typeof(MainWindow);

            // привязка команды Exit
            Exit = new RoutedCommand("Exit", bindTo);

            // привязка команды About
            About = new RoutedCommand("About", bindTo);

            // привязка команды ShowSubscriptions
            ShowSubscriptions = new RoutedCommand("ShowSubscriptions", bindTo);

            // привязка команды ShowPublications
            ShowPublications = new RoutedCommand("ShowPublications", bindTo);

            // привязка команды ShowSubscribers
            ShowSubscribers = new RoutedCommand("ShowSubscribers", bindTo);

            // привязка команды ShowPostmen
            ShowPostmen = new RoutedCommand("ShowPostmen", bindTo);

            // привязка команды ShowPlots
            ShowPlots = new RoutedCommand("ShowPlots", bindTo);

            // привязка команды Subscribe
            Subscribe = new RoutedCommand("Subscribe", bindTo);

            // привязка команды AddNewPublication
            AddNewPublication = new RoutedCommand("AddNewPublication", bindTo);

            // привязка команды IdentifyPostman
            IdentifyPostman = new RoutedCommand("IdentifyPostman", bindTo);

            // привязка команды IdentifyPublications
            IdentifyPublications = new RoutedCommand("IdentifyPublications", bindTo);

            // привязка команды AverageSubscriptionTerm
            AverageSubscriptionTerm = new RoutedCommand("AverageSubscriptionTerm", bindTo);

            // привязка команды AddNewPostman
            AddNewPostman = new RoutedCommand("AddNewPostman", bindTo);

            // привязка команды LayOffPostman
            LayOffPostman = new RoutedCommand("LayOffPostman", bindTo);
        } // Commands
    } // class Commands
}
