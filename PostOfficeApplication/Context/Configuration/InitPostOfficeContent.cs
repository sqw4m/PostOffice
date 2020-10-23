using PostOffice_Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PostOffice_Model.Utils;

namespace PostOfficeApplication.Context.Configuration
{
    class InitPostOfficeContent : DropCreateDatabaseAlways/*DropCreateDatabaseIfModelChanges*//*CreateDatabaseIfNotExists*/<PostOfficeDbContext>
    {
        protected override void Seed(PostOfficeDbContext context)
        {
            base.Seed(context);

            #region коллекция персон
            Person[] persons =
            {
                new Person { Surname = "Ушакова", Name = "Шаризат", Patronymic = "Вячеславовна" },
                new Person { Surname = "Радионов", Name = "Джонмахмад", Patronymic = "Русланович" },
                new Person { Surname = "Волощук", Name = "Аварие", Patronymic = "Артемович" },
                new Person { Surname = "Байко", Name = "Сейшас", Patronymic = "Тимурович" },
                new Person { Surname = "Маслов", Name = "Альт", Patronymic = "Вячеславович" },
                new Person { Surname = "Редкая", Name = "Зионида", Patronymic = "Филипповна" },
                new Person { Surname = "Богданова", Name = "Кашондра", Patronymic = "Аркадьевна" },
                new Person { Surname = "Аркадьев", Name = "Таурус", Patronymic = "Макарович" },
                new Person { Surname = "Лапина", Name = "Синара", Patronymic = "Леонидовна" },
                new Person { Surname = "Мозговых", Name = "Абуд", Patronymic = "Алексеевич" },
                new Person { Surname = "Куликовский", Name = "Айтпуар", Patronymic = "Евгеньевич" },
                new Person { Surname = "Быкова", Name = "Кристина", Patronymic = "Геннадиевна" },
                new Person { Surname = "Толмачев", Name = "Анатолий", Patronymic = "Леонидович" },
                new Person { Surname = "Покровский", Name = "Богдан", Patronymic = "Ильич" },
                new Person { Surname = "Махов", Name = "Прентайс", Patronymic = "Николаевич" },
                new Person { Surname = "Вихирев", Name = "Анатолий", Patronymic = "Валентинович" },
                new Person { Surname = "Ивлева", Name = "Мартолина", Patronymic = "Ярославовна" },
                new Person { Surname = "Качалов", Name = "Медимн", Patronymic = "Тимурович" },
                new Person { Surname = "Абрамович", Name = "Артиния", Patronymic = "Кирилловна" },
                new Person { Surname = "Востриков", Name = "Тухфат", Patronymic = "Тимурович" },
                new Person { Surname = "Андронова", Name = "Хранислава", Patronymic = "Валерьевна" },
                new Person { Surname = "Соболев", Name = "Агамырат", Patronymic = "Борисович" },
                new Person { Surname = "Меркулова", Name = "Анастасия", Patronymic = "Аркадьевна" },
                new Person { Surname = "Волкова", Name = "Гаега", Patronymic = "Виталиевна" },
                new Person { Surname = "Филлипов", Name = "Раниль", Patronymic = "Миронович" },
                new Person { Surname = "Шпагина", Name = "Карнетия", Patronymic = "Филипповна" },
                new Person { Surname = "Шанский", Name = "Шайдар", Patronymic = "Вадимович" },
                new Person { Surname = "Лаврентьева", Name = "Камура", Patronymic = "Валентиновна" },
                new Person { Surname = "Иванов", Name = "Добрыня", Patronymic = "Вениаминович" },
                new Person { Surname = "Булгакова", Name = "Хинонна", Patronymic = "Владиславовна" },
                new Person { Surname = "Симонова", Name = "Ясира", Patronymic = "Даниловна" },
                new Person { Surname = "Леонтьева", Name = "Сальмаханум", Patronymic = "Иосифовна" },
                new Person { Surname = "Анисимов", Name = "Тристан", Patronymic = "Валерьевич" },
                new Person { Surname = "Тимофеева", Name = "Эджегул", Patronymic = "Васильевна" },
                new Person { Surname = "Тайская", Name = "Калистра", Patronymic = "Андреевна" },
                new Person { Surname = "Карпова", Name = "Паллас", Patronymic = "Робертовна" },
                new Person { Surname = "Князева", Name = "Беннинг", Patronymic = "Олеговна" },
                new Person { Surname = "Владимиров", Name = "Людвиг", Patronymic = "Тимофеевич" },
                new Person { Surname = "Миллер", Name = "Амига", Patronymic = "Дмитриевна" },
                new Person { Surname = "Лаврентьев", Name = "Боделер", Patronymic = "Ярославович" },
                new Person { Surname = "Химченко", Name = "Исмоил", Patronymic = "Тарасович" },
                new Person { Surname = "Сорокина", Name = "Зоралла", Patronymic = "Тарасовна" },
                new Person { Surname = "Сахарова", Name = "Мэрле", Patronymic = "Олеговна" },
                new Person { Surname = "Комарова", Name = "Адоля", Patronymic = "Юрьевна" },
                new Person { Surname = "Махова", Name = "Епистима", Patronymic = "Львовна" },
                new Person { Surname = "Матвиенко", Name = "Эсав", Patronymic = "Александрович" },
                new Person { Surname = "Гусева", Name = "Ильвера", Patronymic = "Тарасовна" },
                new Person { Surname = "Чаурин", Name = "Абдуманноб", Patronymic = "Александрович" },
                new Person { Surname = "Крымский", Name = "Хамде", Patronymic = "Данилович" },
                new Person { Surname = "Тюрин", Name = "Элладий", Patronymic = "Георгиевич" },
                new Person { Surname = "Солнцев", Name = "Кристобал", Patronymic = "Борисович" },
                new Person { Surname = "Нуцубидзе", Name = "Греталия", Patronymic = "Станиславовна" },
                new Person { Surname = "Орлова", Name = "Джамилят", Patronymic = "Георгиевна" },
                new Person { Surname = "Кудрявцев", Name = "Атто", Patronymic = "Юрьевич" },
                new Person { Surname = "Баранова", Name = "Мардония", Patronymic = "Сергеевна" },
                new Person { Surname = "Стацевич", Name = "Степана", Patronymic = "Семеновна" },
                new Person { Surname = "Тимофеев", Name = "Вилот", Patronymic = "Михайлович" },
                new Person { Surname = "Доржинов", Name = "Тыныч", Patronymic = "Васильевич" },
                new Person { Surname = "Демидова", Name = "Ронислава", Patronymic = "Олеговна" },
                new Person { Surname = "Гилуть", Name = "Альгемантас", Patronymic = "Юрьевич" },
                new Person { Surname = "Щербаков", Name = "Геннадий", Patronymic = "Анатольевич" },
                new Person { Surname = "Белокрылова", Name = "Кэйла", Patronymic = "Матвеевна" },
                new Person { Surname = "Алтырева", Name = "Эсни", Patronymic = "Ильинична" },
                new Person { Surname = "Владова", Name = "Эльзана", Patronymic = "Романовна" },
                new Person { Surname = "Травников", Name = "Шубул", Patronymic = "Эльдарович" },
                new Person { Surname = "Железный", Name = "Пейман", Patronymic = "Викторович" },
                new Person { Surname = "Яковенко", Name = "Влася", Patronymic = "Филипповна" },
                new Person { Surname = "Артимович", Name = "Ангелита", Patronymic = "Федоровна" },
                new Person { Surname = "Зеленов", Name = "Осгуд", Patronymic = "Артемович" },
                new Person { Surname = "Александрова", Name = "Феократа", Patronymic = "Владиславовна" },
                new Person { Surname = "Кольцов", Name = "Альдонгар", Patronymic = "Павлович" },
                new Person { Surname = "Чехова", Name = "Идав", Patronymic = "Андреевна" },
                new Person { Surname = "Конягина", Name = "Саджида", Patronymic = "Ивановна" },
                new Person { Surname = "Гусев", Name = "Плутон", Patronymic = "Миронович" },
                new Person { Surname = "Поднебесный", Name = "Всечест", Patronymic = "Ермакович" },
                new Person { Surname = "Радионов", Name = "Вовун", Patronymic = "Викторович" },
                new Person { Surname = "Шалдыбина", Name = "Ванута", Patronymic = "Семеновна" },
                new Person { Surname = "Кочетков", Name = "Даррил", Patronymic = "Ермакович" },
                new Person { Surname = "Фомин", Name = "Вильгельм", Patronymic = "Святославович" },
                new Person { Surname = "Берестов", Name = "Кощей", Patronymic = "Валентинович" },
                new Person { Surname = "Пименова", Name = "Аина", Patronymic = "Тарасовна" },
                new Person { Surname = "Шарыпов", Name = "Гажип", Patronymic = "Васильевич" },
                new Person { Surname = "Леонтьева", Name = "Тагзия", Patronymic = "Олеговна" },
                new Person { Surname = "Железный", Name = "Лерен", Patronymic = "Константинович" },
                new Person { Surname = "Маврин", Name = "Бедис", Patronymic = "Тимурович" },
                new Person { Surname = "Холодкова", Name = "Парвана", Patronymic = "Григорьевна" },
                new Person { Surname = "Шпагин", Name = "Искандар", Patronymic = "Валерьевич" },
                new Person { Surname = "Чистякова", Name = "Христослава", Patronymic = "Максимовна" },
                new Person { Surname = "Изофатова", Name = "Котча", Patronymic = "Антоновна" },
                new Person { Surname = "Миронова", Name = "Златомира", Patronymic = "Виталиевна" },
                new Person { Surname = "Рустамов", Name = "Ипполинарий", Patronymic = "Давидович" },
                new Person { Surname = "Марков", Name = "Фабиянт", Patronymic = "Романович" },
                new Person { Surname = "Белякова", Name = "Сора", Patronymic = "Борисовна" },
                new Person { Surname = "Куколевская", Name = "Алифтень", Patronymic = "Вячеславовна" },
                new Person { Surname = "Маркова", Name = "Ренея", Patronymic = "Алексеевна" },
                new Person { Surname = "Шашков", Name = "Аграфий", Patronymic = "Андреевич" },
                new Person { Surname = "Веселкова", Name = "Гинесса", Patronymic = "Богдановна" },
                new Person { Surname = "Астахов", Name = "Гмерти", Patronymic = "Альбертович" },
                new Person { Surname = "Коновалов", Name = "Абильамит", Patronymic = "Анатольевич" },
                new Person { Surname = "Ахметзянов", Name = "Твердолик", Patronymic = "Валентинович" },
                new Person { Surname = "Дружинина", Name = "Амада", Patronymic = "Алексеевна" },
                new Person { Surname = "Валинин", Name = "Шемяка", Patronymic = "Максимович" },
                new Person { Surname = "Русов", Name = "Альпер", Patronymic = "Филиппович" },
                new Person { Surname = "Толмачев", Name = "Гедеон", Patronymic = "Аркадьевич" },
                new Person { Surname = "Бабенко", Name = "Аллла", Patronymic = "Геннадиевна" },
                new Person { Surname = "Амбарцумян", Name = "Доррен", Patronymic = "Юрьевна" },
                new Person { Surname = "Львов", Name = "Абильнасыр", Patronymic = "Давидович" },
                new Person { Surname = "Шевченко", Name = "Темирлан", Patronymic = "Матвеевич" },
                new Person { Surname = "Добронравова", Name = "Домильцеля", Patronymic = "Ермаковна" },
                new Person { Surname = "Русина", Name = "Эльдгибета", Patronymic = "Ильинична" },
                new Person { Surname = "Волочков", Name = "Ганислав", Patronymic = "Матвеевич" },
                new Person { Surname = "Леонтьева", Name = "Дантина", Patronymic = "Семеновна" },
                new Person { Surname = "Русин", Name = "Абдулкасир", Patronymic = "Анатольевич" },
                new Person { Surname = "Сульженко", Name = "Зуфнун", Patronymic = "Максимович" },
                new Person { Surname = "Морозова", Name = "Дона", Patronymic = "Леонидовна" },
                new Person { Surname = "Москаленко", Name = "Анушка", Patronymic = "Михайловна" },
                new Person { Surname = "Милованов", Name = "Герви", Patronymic = "Валентинович" },
                new Person { Surname = "Новиков", Name = "Арджасп", Patronymic = "Григорьевич" },
                new Person { Surname = "Ларин", Name = "Некулай", Patronymic = "Константинович" },
                new Person { Surname = "Кочетков", Name = "Стэнфилд", Patronymic = "Викторович" },
                new Person { Surname = "Кожин ", Name = "Абдель", Patronymic = "Станиславович" },
                new Person { Surname = "Галицына", Name = "Исмизар", Patronymic = "Евгеньевна" },
                new Person { Surname = "Артимович", Name = "Чакмак", Patronymic = "Ермакович" },
                new Person { Surname = "Минаева", Name = "Мерару", Patronymic = "Алексеевна" },
                new Person { Surname = "Владимиров", Name = "Гюльназар", Patronymic = "Валентинович" },
                new Person { Surname = "Сидорова", Name = "Хасият", Patronymic = "Юрьевна" },
                new Person { Surname = "Охота", Name = "Мухиддин", Patronymic = "Иванович" },
                new Person { Surname = "Романова", Name = "Ждана", Patronymic = "Платоновна" },
                new Person { Surname = "Гуров", Name = "Армен", Patronymic = "Тимурович" },
                new Person { Surname = "Берестова", Name = "Наги", Patronymic = "Ермаковна" },
                new Person { Surname = "Новак", Name = "Ахтари", Patronymic = "Антонович" },
                new Person { Surname = "Миллер", Name = "Иоана", Patronymic = "Семеновна" },
                new Person { Surname = "Румянцева", Name = "Эсма", Patronymic = "Леонидовна" },
                new Person { Surname = "Суворова", Name = "Шукр", Patronymic = "Владимировна" },
                new Person { Surname = "Даров", Name = "Астхин", Patronymic = "Андреевич" },
                new Person { Surname = "Захаров", Name = "Анушован", Patronymic = "Тимурович" },
                new Person { Surname = "Охота", Name = "Юзджан", Patronymic = "Анатольевич" },
                new Person { Surname = "Емельянов", Name = "Егизбай", Patronymic = "Геннадьевич" },
                new Person { Surname = "Власов", Name = "Изадор", Patronymic = "Вячеславович" },
                new Person { Surname = "Ивлев", Name = "Максимиан", Patronymic = "Станиславович" },
                new Person { Surname = "Бартель", Name = "Сукайнат", Patronymic = "Федоровна" },
                new Person { Surname = "Уланов", Name = "Вираб", Patronymic = "Николаевич" },
                new Person { Surname = "Берестова", Name = "Диомида", Patronymic = "Ефимовна" },
                new Person { Surname = "Королева", Name = "Альмита", Patronymic = "Аркадьевна" },
                new Person { Surname = "Воробьёва", Name = "Яидия", Patronymic = "Львовна" },
                new Person { Surname = "Толмачева", Name = "Олиянна", Patronymic = "Артемовна" },
                new Person { Surname = "Ленина", Name = "Дилкар", Patronymic = "Сергеевна" },
                new Person { Surname = "Сульженко", Name = "Сэй", Patronymic = "Святославович" },
                new Person { Surname = "Лапина", Name = "Маридила", Patronymic = "Борисовна" },
                new Person { Surname = "Островский", Name = "Фадие", Patronymic = "Тимурович" }
            };

            foreach (var person in persons)
                context.People.Add(person);
            #endregion

            #region коллекция почтальонов
            Postman[] postmen =
            {
                new Postman {Person = persons[0]},
                new Postman {Person = persons[1]},
                new Postman {Person = persons[2]},
                new Postman {Person = persons[3]},
                new Postman {Person = persons[4]},
                new Postman {Person = persons[5]},
                new Postman {Person = persons[6]},
                new Postman {Person = persons[7]}
            };
            #endregion

            #region коллекция участков
            Plot[] plots = {
                new Plot
                {
                    PlotNumber = "01",
                    Postman = postmen[GetRand(0, 7)]
                },
                new Plot
                {
                    PlotNumber = "02",
                    Postman = postmen[GetRand(0, 7)]
                },
                new Plot
                {
                    PlotNumber = "03",
                    Postman = postmen[GetRand(0, 7)]
                },

                new Plot
                {
                    PlotNumber = "04",
                    Postman = postmen[GetRand(0, 7)]
                },

                new Plot
                {
                    PlotNumber = "05",
                    Postman = postmen[GetRand(0, 7)]
                },

                new Plot
                {
                    PlotNumber = "06",
                    Postman = postmen[GetRand(0, 7)]
                },

                new Plot
                {
                    PlotNumber = "07",
                    Postman = postmen[GetRand(0, 7)]
                }
            };

            foreach (var plot in plots)
            {
                context.Plots.Add(plot);
            }
            #endregion

            #region коллекция улиц
            Street[] streets =
            {
                new Street { StreetName = "Шахтостроителей", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Шевченко", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Бизе", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Ботева", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Дзержинского", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Ильича", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "50-й Гвардейской дивизии", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Автотранспортников", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Андреева", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Антипова", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Барнаульская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Бурденко", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Владычанского", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Гатчинская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Герцена", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Гипрошахтная", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Дрогобычская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Интернациональная", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Кадиевская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Калашникова", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Калужская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Капитана Ратникова", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Карпинского", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Каштановая", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Краснодонская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Краснофлотская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Лабутенко", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Лазо", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Левобережная", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Литвинова", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Марии Ульяновой", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Моцарта", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Мушкетовская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Нижнеудинская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Овнатаняна", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Пархоменко", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Проходчиков", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Разенкова", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Сигова", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Старобельская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Творческая", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Харитонова", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Хлюпина", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Ходаковского", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Цусимская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Черкасова", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Черниговская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "8-го Марта", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Абхазская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Аджарская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Архимеда", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Ахтырская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Барвенковская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Белинского", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Березовая", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Берестовская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Ботаническая", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Бутлерова", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Водная", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Володарского", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Волочаевская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Восточная", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Всеволода Вишневского", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Вузовская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Высотная", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Гагарина", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Гладкова", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Гомелевская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Горбачевского", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Горячкина", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Гусева", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Гутченко", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Декоративная", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Демократическая", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Доватора", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Дружбы народов", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Дружковская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Евгения Орлова", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Ефремова", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Жемчужная", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Жигулевская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Залмаева", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Заславского", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Имени Ю. А. Гуляева", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Кабардинская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Казахстанская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Калиновская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Карпатская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Комарова", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Комиссаржевской", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Комсомольской Правды", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Коммунарская", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Котовского", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Коцюбинского", Plot = plots[GetRand(0, plots.Length - 1)] },
                new Street { StreetName = "Красина", Plot = plots[GetRand(0, plots.Length - 1)] }
            };

            foreach (var street in streets)
                context.Streets.Add(street);
            #endregion

            #region коллекция адресов
            Address[] addresses = {
                new Address
                {
                    House = "7а",
                    Apartment = 54,
                    Street = streets[0]
                },
                new Address
                {
                    House = "24",
                    Apartment = 2,
                    Street = streets[1]
                },
                new Address
                {
                    House = "51",
                    Apartment = 19,
                    Street = streets[2]
                },
                new Address
                {
                    House = "33",
                    Apartment = 15,
                    Street = streets[3]
                },
                new Address
                {
                    House = "102",
                    Apartment = 1,
                    Street = streets[4]
                },
                new Address
                {
                    House = "14",
                    Apartment = 72,
                    Street = streets[5]
                },
                new Address
                {
                    House = "23",
                    Apartment = 4,
                    Street = streets[6]
                },
                new Address
                {
                    House = "71",
                    Apartment = 34,
                    Street = streets[7]
                },
                new Address
                {
                    House = "47",
                    Apartment = 85,
                    Street = streets[8]
                },
                new Address
                {
                    House = "21",
                    Apartment = 13,
                    Street = streets[9]
                },
                new Address
                {
                    House = "56",
                    Apartment = 7,
                    Street = streets[10]
                },
                new Address
                {
                    House = "88",
                    Apartment = 9,
                    Street = streets[11]
                },
                new Address
                {
                    House = "29",
                    Apartment = 64,
                    Street = streets[12]
                }
        };
            #endregion

            #region коллекция подписчиков
            Subscriber[] subscribers =
            {
                new Subscriber
                {
                    Address = addresses[0],
                    Person = persons[8]
                },
                new Subscriber
                {
                    Address = addresses[1],
                    Person = persons[9]
                },
                new Subscriber
                {
                    Address = addresses[2],
                    Person = persons[10]
                },
                new Subscriber
                {
                    Address = addresses[3],
                    Person = persons[11]
                },
                new Subscriber
                {
                    Address = addresses[4],
                    Person = persons[12]
                },
                new Subscriber
                {
                    Address = addresses[5],
                    Person = persons[13]
                },
                new Subscriber
                {
                    Address = addresses[6],
                    Person = persons[14]
                },
                new Subscriber
                {
                    Address = addresses[7],
                    Person = persons[15]
                },
                new Subscriber
                {
                    Address = addresses[8],
                    Person = persons[16]
                },
                new Subscriber
                {
                    Address = addresses[9],
                    Person = persons[17]
                },
                new Subscriber
                {
                    Address = addresses[10],
                    Person = persons[18],
                },
                new Subscriber
                {
                    Address = addresses[11],
                    Person = persons[19]
                },
                new Subscriber
                {
                    Address = addresses[12],
                    Person = persons[20]
                }
            };
            #endregion

            #region коллекция типов печатных изданий
            PublicationType[] publicationTypes =
            {
            new PublicationType { TypeName = "газета"},
            new PublicationType { TypeName = "журнал"},
            new PublicationType { TypeName = "альманах"},
            new PublicationType { TypeName = "бюллетень"}
            };

            foreach (var publicationType in publicationTypes)
            {
                context.PublicationTypes.Add(publicationType);
            }
            #endregion

            #region коллекция печатных изданий
            Publication[] publications =
            {
                new Publication
                {
                    Index = "П1126",
                    PublicationName = "Коммерсантъ",
                    Price = 616.68,
                    PublicationType = publicationTypes[0]
                },
                new Publication
                {
                    Index = "П1462",
                    PublicationName = "Esquire",
                    Price = 255.95,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "П6238",
                    PublicationName = "Эксперт",
                    Price = 465.13,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "П3842",
                    PublicationName = "Вокруг света",
                    Price = 212.04,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "П2965",
                    PublicationName = "ДИЛЕТАНТ",
                    Price = 176.67,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "П1265",
                    PublicationName = "Неделя",
                    Price = 85.54,
                    PublicationType = publicationTypes[0]
                },
                new Publication
                {
                    Index = "П1467",
                    PublicationName = "Наука и жизнь",
                    Price = 347.58,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "ПР150",
                    PublicationName = "FORBES",
                    Price = 322.42,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "П2105",
                    PublicationName = "Непоседа",
                    Price = 80.62,
                    PublicationType = publicationTypes[0]
                },
                new Publication
                {
                    Index = "П4536",
                    PublicationName = "Юный эрудит",
                    Price = 85.52,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "П1963",
                    PublicationName = "Весёлые картинки",
                    Price = 182.19,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "П1464",
                    PublicationName = "BAZAR",
                    Price = 380.72,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "П1206",
                    PublicationName = "Психология и Я",
                    Price = 39.84,
                    PublicationType = publicationTypes[0]
                },
                new Publication
                {
                    Index = "П1266",
                    PublicationName = "Родина",
                    Price = 137.95,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "П7357",
                    PublicationName = "Дача и дачники",
                    Price = 87.03,
                    PublicationType = publicationTypes[0]
                },
                new Publication
                {
                    Index = "П7000",
                    PublicationName = "Моя семья",
                    Price = 157.49,
                    PublicationType = publicationTypes[0]
                },
                new Publication
                {
                    Index = "П1970",
                    PublicationName = "1000 секретов",
                    Price = 59.46,
                    PublicationType = publicationTypes[0]
                },
                new Publication
                {
                    Index = "П1271",
                    PublicationName = "Ухтышка",
                    Price = 35.21,
                    PublicationType = publicationTypes[0]
                },
                new Publication
                {
                    Index = "П4529",
                    PublicationName = "Смешарики",
                    Price = 91.13,
                    PublicationType = publicationTypes[0]
                },
                new Publication
                {
                    Index = "П1140",
                    PublicationName = "Огонёк",
                    Price = 137.62,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "П6658",
                    PublicationName = "Фармация",
                    Price = 1636.29,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "ПИ240",
                    PublicationName = "Педсовет",
                    Price = 61.24,
                    PublicationType = publicationTypes[0]
                },
                new Publication
                {
                    Index = "П7268",
                    PublicationName = "Кадровик",
                    Price = 2942.36,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "П2564",
                    PublicationName = "Обереги",
                    Price = 140.71,
                    PublicationType = publicationTypes[0]
                },
                new Publication
                {
                    Index = "П7152",
                    PublicationName = "Хирург",
                    Price = 2008.29,
                    PublicationType = publicationTypes[1]
                },
                new Publication
                {
                    Index = "ПО385",
                    PublicationName = "Аврора",
                    Price = 276.60,
                    PublicationType = publicationTypes[1]
                }
            };

            foreach (var publication in publications)
            {
                context.Publications.Add(publication);
            }
            #endregion

            #region коллекция подписок
            context.Subscriptions.Add(new Subscription
            {
                StartDate = new DateTime(2020, 09, 06),
                Term = 12,
                Publication = publications[0],
                Subscriber = subscribers[0]
            });

            context.Subscriptions.Add(new Subscription
            {
                StartDate = new DateTime(2020, 04, 22),
                Term = 3,
                Publication = publications[6],
                Subscriber = subscribers[7]
            });

            context.Subscriptions.Add(new Subscription
            {
                StartDate = new DateTime(2020, 06, 19),
                Term = 6,
                Publication = publications[3],
                Subscriber = subscribers[3]
            });

            context.Subscriptions.Add(new Subscription
            {
                StartDate = new DateTime(2020, 08, 10),
                Term = 12,
                Publication = publications[10],
                Subscriber = subscribers[3]
            });

            context.Subscriptions.Add(new Subscription
            {
                StartDate = new DateTime(2020, 09, 05),
                Term = 6,
                Publication = publications[20],
                Subscriber = subscribers[1]
            });

            context.Subscriptions.Add(new Subscription
            {
                StartDate = new DateTime(2020, 07, 22),
                Term = 3,
                Publication = publications[5],
                Subscriber = subscribers[12]
            });

            context.Subscriptions.Add(new Subscription
            {
                StartDate = new DateTime(2020, 01, 09),
                Term = 24,
                Publication = publications[8],
                Subscriber = subscribers[9]
            });

            context.Subscriptions.Add(new Subscription
            {
                StartDate = new DateTime(2020, 05, 25),
                Term = 6,
                Publication = publications[14],
                Subscriber = subscribers[2]
            });

            context.Subscriptions.Add(new Subscription
            {
                StartDate = new DateTime(2020, 09, 01),
                Term = 6,
                Publication = publications[6],
                Subscriber = subscribers[11]
            });

            context.Subscriptions.Add(new Subscription
            {
                StartDate = new DateTime(2020, 08, 21),
                Term = 12,
                Publication = publications[19],
                Subscriber = subscribers[10]
            });

            context.Subscriptions.Add(new Subscription
            {
                StartDate = new DateTime(2020, 04, 16),
                Term = 24,
                Publication = publications[13],
                Subscriber = subscribers[8]
            });

            context.Subscriptions.Add(new Subscription
            {
                StartDate = new DateTime(2020, 07, 04),
                Term = 12,
                Publication = publications[15],
                Subscriber = subscribers[5]
            });

            context.Subscriptions.Add(new Subscription
            {
                StartDate = new DateTime(2020, 08, 09),
                Term = 3,
                Publication = publications[24],
                Subscriber = subscribers[6]
            });
            #endregion

            context.SaveChanges();
        } // Seed                   
    } // class InitPostOfficeContent   
}



















