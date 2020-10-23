using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PostOfficeApplication.Context;
using PostOfficeApplication.Context.Configuration;
using PostOffice_Model;
using System.Runtime.InteropServices.ComTypes;
using System.Windows;
using PostOfficeApplication.Views;

namespace PostOfficeApplication.Controllers
{
    public class PostOfficeController
    {
        MainWindow _mw;
        public PostOfficeController(MainWindow mw)
        {
            Database.SetInitializer(new InitPostOfficeContent());
            _mw = mw;
        } // PostOfficeController

        // вывод всех подписок
        public async Task ShowSubscriptions()
        {
            using (var ctx = new PostOfficeDbContext())
            {
                IList list = await Task.Run(() => ctx.Subscriptions
                    .Select(s => new
                    {
                        Subscriber = s.Subscriber.Person.Surname + " " 
                        + s.Subscriber.Person.Name + " " 
                        + s.Subscriber.Person.Patronymic,
                        PublicationType = s.Publication.PublicationType.TypeName,
                        s.Publication.PublicationName,
                        Date = s.StartDate.Day + "/" + s.StartDate.Month + "/" + s.StartDate.Year,
                        Term = s.Term
                    }).ToListAsync());

                _mw.FillDataGrid(list);
            }
        } // ShowSubscriptions

        // вывод всех печатных изданий
        public async Task ShowPublications()
        {
            using (var ctx = new PostOfficeDbContext())
            {
                IList list = await Task.Run(() => ctx.Publications
                    .Select(p => new
                    {
                        p.Index,
                        PublicationType = p.PublicationType.TypeName,
                        p.PublicationName,
                        p.Price
                    }).ToListAsync());

                _mw.FillDataGrid(list);
            }
        } // ShowPublications

        // вывод всех подписчиков
        public async Task ShowSubscribers()
        {
            using (var ctx = new PostOfficeDbContext())
            {
                IList list = await Task.Run(() => ctx.Subscribers
                    .Select(s => new
                    {
                        s.Person.Surname,
                        s.Person.Name,
                        s.Person.Patronymic,
                        Address = "ул." + s.Address.Street.StreetName + 
                        ", д." + s.Address.House + 
                        ", кв." + s.Address.Apartment
                    }).ToListAsync());

                _mw.FillDataGrid(list);
            }
        } // ShowSubscribers

        // вывод всех подписчиков
        public async Task ShowPostmen()
        {
            using (var ctx = new PostOfficeDbContext())
            {
                IList list = await Task.Run(() => ctx.Postmen
                    .Select(p => new
                    {
                        p.Person.Surname,
                        p.Person.Name,
                        p.Person.Patronymic
                    }).ToListAsync());

                _mw.FillDataGrid(list);
            }
        } // ShowPostmen

        // вывод всех участков
        public async Task ShowPlots()
        {
            using (var ctx = new PostOfficeDbContext())
            {
                IList list = await Task.Run(() => ctx.Plots
                    .Select(p => new
                    {
                        p.PlotNumber,
                        p.Postman.Person.Surname,
                        p.Postman.Person.Name,
                        p.Postman.Person.Patronymic
                    }).ToListAsync());

                _mw.FillDataGrid(list);
            }
        } // ShowPlots

        // Определить наименование и количество экземпляров всех изданий,
        // получаемых отделением связи
        public async Task ShowQuantOfTypesPublications()
        {
            string str = string.Empty;
            using (var ctx = new PostOfficeDbContext())
            {
                IList list = await Task.Run(() => ctx.Publications
                    .GroupBy(p => p.PublicationType.TypeName)
                    .Select(p => new
                    {
                        publicationType = p.Key,
                        Quantity = p.Count()
                    }).ToListAsync());

                foreach (var item in list)
                {
                    if (item.ToString().Contains("газета"))
                    {
                        str += "Газет: " + item
                        .ToString()
                        .Split(',')[1]
                        .Split('=')[1]
                        .Replace('}', ' ')
                        .TrimEnd() + " шт.";
                    }
                    if (item.ToString().Contains("журнал"))
                    {
                        str += " | Журналов: " + item
                        .ToString()
                        .Split(',')[1]
                        .Split('=')[1]
                        .Replace('}', ' ')
                        .TrimEnd() + " шт.";
                    }
                    if (item.ToString().Contains("альманах"))
                    {
                        str += " | Альманахов: " + item
                        .ToString()
                        .Split(',')[1]
                        .Split('=')[1]
                        .Replace('}', ' ')
                        .TrimEnd() + " шт.";
                    }
                    if (item.ToString().Contains("бюллетень"))
                    {
                        str += " | Бюллетеней: " + item
                        .ToString()
                        .Split(',')[1]
                        .Split('=')[1]
                        .Replace('}', ' ')
                        .TrimEnd() + " шт.";
                    } // if
                } // foreach

                _mw.FillLblQuantOfTypesPublications(str);
                _mw.Show();
            } // using
        } // ShowQuantOfTypesPublications

        // По заданному адресу определить фамилию почтальона,
        // обслуживающего подписчика
        public async Task ShowPostmanBySubscriberAddress(string street, string house, int apartament)
        {
            using (var ctx = new PostOfficeDbContext())
            {
                IList list = await Task.Run(() => ctx.Subscriptions
                    .Where(s => s.Subscriber.Address.Street.StreetName == street &&
                                s.Subscriber.Address.House == house &&
                                s.Subscriber.Address.Apartment == apartament)
                    .Select(s => new
                    {
                        Plot = s.Subscriber.Address.Street.Plot.PlotNumber,
                        Postman = s.Subscriber.Address.Street.Plot.Postman.Person.Surname + " "
                        + s.Subscriber.Address.Street.Plot.Postman.Person.Name + " " 
                        + s.Subscriber.Address.Street.Plot.Postman.Person.Patronymic
                    }).Distinct().ToListAsync());

                _mw.FillDataGrid(list);
            } // using
        } // ShowPostmanBySubscriberAddress

        // Какие газеты выписывает гражданин с указанной фамилией, именем, отчеством
        public async Task ShowPublicationsByFIOSubscriber(string surname, string name, string patronymic)
        {
            using (var ctx = new PostOfficeDbContext())
            {
                IList list = await Task.Run(() => ctx.Subscriptions
                    .Where(s => s.Subscriber.Person.Surname == surname &&
                                s.Subscriber.Person.Name == name &&
                                s.Subscriber.Person.Patronymic == patronymic)
                    .Select(s => new
                    {
                        s.Publication.Index,
                        PublicationType = s.Publication.PublicationType.TypeName,
                        s.Publication.PublicationName,
                        s.Publication.Price
                    }).ToList());

                _mw.FillDataGrid(list);
            } // using
        }
        // Сколько почтальонов работает в почтовом отделении
        public async Task ShowAllPostmen()
        {
            using (var ctx = new PostOfficeDbContext())
            {
                IList list = await Task.Run(() => ctx.Postmen
                .Select(p => new
                {
                    p.Person.Surname,
                    p.Person.Name,
                    p.Person.Patronymic
                }).ToListAsync());

                _mw.FillLblAllPostmen("Всего почтальонов: " + list.Count.ToString());
            } // using
        } // ShowAllPostmen

        // На каком участке количество экземпляров подписных изданий максимально
        public async Task ShowPlotMaxSubscription()
        {
            using (var ctx = new PostOfficeDbContext())
            {
                int max = await Task.Run(() => ctx.Subscriptions
                .GroupBy(s => s.Subscriber.Address.Street.Plot.PlotNumber)
                .Select(p => new
                {
                    Plot = p.Key,
                    Quantity = p.Count()
                }).Max(x => x.Quantity));

                IList lst = await Task.Run(() => ctx.Subscriptions
                .GroupBy(s => s.Subscriber.Address.Street.Plot.PlotNumber)
                .Select(p => new
                {
                    Plot = p.Key,
                    Quantity = p.Count()
                }).Where(x => x.Quantity == max).ToListAsync());
                 
                _mw.FillLblPlotMaxSubscription("Уч. с макс. кол-вом подписок:" + 
                    lst[0].ToString().Split('=')[1].Split(',')[0]);
            } // using
        } // ShowPlotMaxPublications

        // Каков средний срок подписки по каждому изданию
        public async Task AverageSubscriptionTerm()
        {
            using (var ctx = new PostOfficeDbContext())
            {
                IList list = await Task.Run(() => ctx.Subscriptions
                .GroupBy(s => s.Publication.Index)
                .Select(p => new
                {
                    Index = p.Key,
                    Term = p.Average(t => t.Term)
                })
                .ToListAsync());

                _mw.FillDataGrid(list);
            } // using
        } // AverageSubscriptionTerm

        // добавить печатное издание
        public async Task AddNewPublication(string index, string publicationName, 
                                            double price, string typeName)
        {
            using (var ctx = new PostOfficeDbContext())
            {
                await Task.Run(() => ctx.Publications.Add(new Publication { 
                     Index = index,
                     PublicationName = publicationName,
                     Price = price,
                     PublicationTypeId = ctx.PublicationTypes.First(x => x.TypeName == typeName).Id
                }));

                ctx.SaveChanges();
            } // using

            ShowQuantOfTypesPublications();
        } // AddNewPublication

        // оформить подписку
        public async Task AddNewSubscription(string surname, string name, string patronymic,
                                             string street, string house, int apartament,
                                             string index, string date, int term, string publName)
        {
            double totalPrice = 0;

            using (var ctx = new PostOfficeDbContext())
            {
                await Task.Run(() => ctx.Subscriptions.Where(s => s.Publication.Index == index).ForEachAsync(s => totalPrice = s.Publication.Price * s.Term));

                Person person = new Person
                {
                    Surname = surname,
                    Name = name,
                    Patronymic = patronymic
                };
                await Task.Run(() => ctx.People.Add(person));

                Address address = new Address
                {
                    StreetId = ctx.Streets.First(s => s.StreetName == street).Id,
                    House = house,
                    Apartment = apartament
                };
                await Task.Run(() => ctx.Addresses.Add(address));

                Subscriber subscriber = new Subscriber
                {
                    PersonId = person.Id,
                    AddressId = address.Id
                };
                await Task.Run(() => ctx.Subscribers.Add(subscriber));

                await Task.Run(() => ctx.Subscriptions.Add(new Subscription
                {
                    SubscriberId = subscriber.Id,
                    PublicationId = ctx.Publications.First(p => p.Index == index).Id,
                    StartDate = Convert.ToDateTime(date),
                    Term = term
                }));

                ctx.SaveChanges();

            } // using

            Receipt receipt = new Receipt(surname + " " + name.First() + ". " + patronymic.First() + ".",
                                        publName, term.ToString(), totalPrice.ToString());
            receipt.ShowDialog();

            ListPublications();
            ShowPlotMaxSubscription();
        } // AddNewSubscription

        // добавить почтальона
        public async Task AddNewPostman(string surname, string name, string patronymic, string[] plots)
        {
            using (var ctx = new PostOfficeDbContext())
            {
                Person person = new Person
                {
                    Surname = surname,
                    Name = name,
                    Patronymic = patronymic
                };
                await Task.Run(() => ctx.People.Add(person));
                Postman postman = new Postman
                {
                    PersonId = person.Id
                };

                await Task.Run(() => ctx.Postmen.Add(postman));

                foreach (var plot in plots)
                    await Task.Run(() => ctx.Plots
                                            .Where(p => p.PlotNumber == plot)
                                            .ForEachAsync(p => p.PostmanId = postman.Id));

                ctx.SaveChanges();
            } // using

            ShowAllPostmen();
        } // AddNewPostman

        // увольнение почтальона
        public async Task LayOffPostman(string surname, string name, string patronymic)
        {
            using (var ctx = new PostOfficeDbContext())
            {
                Postman postman = ctx.Postmen
                                     .First(p => p.Person.Surname == surname &&
                                                 p.Person.Name == name &&
                                                 p.Person.Patronymic == patronymic);
                List<Postman> postmen = ctx.Postmen
                                           .Where(p => p.Id != postman.Id)
                                           .ToList();
                await Task.Run(() => ctx.Plots
                                        .Where(p => p.PostmanId == postman.Id)
                                        .ForEachAsync(p => p.PostmanId = postmen[Utils.GetRand(0, postmen.Count - 1)].Id));

                await Task.Run(() => ctx.Postmen
                                        .Remove(postman));
                Person person = ctx.People.First(p => p.Surname == surname &&
                                                       p.Name == name &&
                                                       p.Patronymic == patronymic);
                await Task.Run(() => ctx.People.Remove(person));

                ctx.SaveChanges();
            } // using

            ListPostmen();
            ShowAllPostmen();
        } // LayOffPostman

        #region вспомогательные методы
        // список всех типов публикаций
        public async Task ListPublicationTypes()
        {
            List<string> types = new List<string>();

            using(var ctx = new PostOfficeDbContext())
            {
                await Task.Run(() => ctx.PublicationTypes
                                .ForEachAsync(pt => types.Add(pt.TypeName)));
            } // using

            _mw.FillPublicationTypeList(types);
        } // ListPublicationTypes

        // список всех подписчиков
        public async Task ListSubscribers()
        {
            List<string> subscribers = new List<string>();

            using (var ctx = new PostOfficeDbContext())
            {
                await Task.Run(() => ctx.Subscribers
                                .ForEachAsync(s => subscribers.Add(s.Person.Surname + " " +
                                                                   s.Person.Name + " " +
                                                                   s.Person.Patronymic)));
            } // using

            _mw.FillSubscribersList(subscribers);
        } // ListSubscribers

        // список всех печатных изданий
        public async Task ListPublications()
        {
            List<string> publications = new List<string>();

            using (var ctx = new PostOfficeDbContext())
            {
                await Task.Run(() => ctx.Publications
                                .ForEachAsync(p => publications.Add(p.Index + "/" + p.PublicationName)));
            } // using

            _mw.FillPublicationsList(publications);
        } // ListPublications

        // список всех почтальонов
        public async Task ListPostmen()
        {
            List<string> postmen = new List<string>();

            using (var ctx = new PostOfficeDbContext())
            {
                await Task.Run(() => ctx.Postmen
                                .ForEachAsync(p => postmen.Add(p.Person.Surname + " " +
                                                               p.Person.Name + " " + 
                                                               p.Person.Patronymic)));
            } // using

            _mw.FillPostmenList(postmen);
        } // ListPostmen

        // список всех улиц
        public async Task ListStreets()
        {
            List<string> streets = new List<string>();

            using (var ctx = new PostOfficeDbContext())
            {
                await Task.Run(() => ctx.Streets
                                .ForEachAsync(s => streets.Add(s.StreetName)));
            } // using

            _mw.FillStreetsList(streets);
        } // ListStreets

        // список всех людей
        public async Task ListPeople()
        {
            List<string> people = new List<string>();

            using (var ctx = new PostOfficeDbContext())
            {
                await Task.Run(() => ctx.People
                                .ForEachAsync(p => people.Add(p.Surname + " " +
                                                               p.Name + " " +
                                                               p.Patronymic)));
            } // using

            _mw.FillPeopleList(people);
        } // ListPeople

        // рассчет стоимости подписки за указаный срок
        public async Task TotalPrice(string index)
        {
            double totalPrice = 24;

            using (var ctx = new PostOfficeDbContext())
            {
                await Task.Run(() => ctx.Subscriptions.Where(s => s.Publication.Index == index).ForEachAsync(s => totalPrice = s.Publication.Price * s.Term));
            } // using

            _mw.FillTotalPrice(/*totalPrice.ToString()*/"ТЕСТ");
        } // TotalPrice
        #endregion

    } // class PostOfficeController
}
