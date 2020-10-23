using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostOffice_Model;

namespace PostOfficeApplication.Context
{
    class PostOfficeDbContext: DbContext
    {
        // dbContext имя строки соединения в app.config
        public PostOfficeDbContext() : this("dbContext") { }
        public PostOfficeDbContext(string connectionString)
            : base(connectionString) { }

        // отображение таблиц данных
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<PublicationType> PublicationTypes { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Postman> Postmen { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Plot> Plots { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // настройка Subscription
            modelBuilder.Entity<Subscription>()
                .Property(s => s.StartDate)
                .IsRequired();
            modelBuilder.Entity<Subscription>()
                .Property(s => s.Term)
                .IsRequired();

            // настройка Publication
            modelBuilder.Entity<Publication>()
                .Property(p => p.Index)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(10);
            modelBuilder.Entity<Publication>()
                .Property(p => p.PublicationName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(100);
            modelBuilder.Entity<Publication>()
                .Property(p => p.Price)
                .IsRequired();
            // связь один-ко-многим Publication-Subscription
            modelBuilder.Entity<Publication>()
                .HasMany(p => p.Subscription)
                .WithRequired(s => s.Publication);

            // настройка PublicationType
            modelBuilder.Entity<PublicationType>()
                .Property(pt => pt.TypeName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);
            // связь один-ко-многим PublicationType-Publication
            modelBuilder.Entity<PublicationType>()
                .HasMany(pt => pt.Publication)
                .WithRequired(p => p.PublicationType);

            // связь один-ко-многим Postman-Plot
            modelBuilder.Entity<Postman>()
                .HasMany(p => p.Plot)
                .WithRequired(plot => plot.Postman);

            // настройка Person
            modelBuilder.Entity<Person>()
                .Property(pers => pers.Surname)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);
            modelBuilder.Entity<Person>()
                .Property(pers => pers.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);
            modelBuilder.Entity<Person>()
                .Property(pers => pers.Patronymic)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);
            // внешние ключи
            // связь один-к-одному с подписчиками
            modelBuilder.Entity<Subscriber>()
                .HasRequired(s => s.Person)
                .WithOptional(p => p.Subscriber);
            // связь один-к-одному с почтальонами
            modelBuilder.Entity<Postman>()
                .HasRequired(postm => postm.Person)
                .WithOptional(p => p.Postman);

            // настройка Plot
            modelBuilder.Entity<Plot>()
                .Property(plot => plot.PlotNumber)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(10);
            // связь один-ко-многим Plot-Street
            modelBuilder.Entity<Plot>()
                .HasMany(plot => plot.Street)
                .WithRequired(s => s.Plot);
            // связь один-ко-многим Plot-Operation
            modelBuilder.Entity<Plot>()
                .HasMany(p => p.Operation)
                .WithRequired(o => o.Plot);

            // настройка Address
            modelBuilder.Entity<Address>()
                .Property(a => a.House)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(10);
            modelBuilder.Entity<Address>()
                .Property(a => a.Apartment)
                .IsRequired();
            // связь один-ко-многим Address-Subscriber
            modelBuilder.Entity<Address>()
                .HasMany(a => a.Subscriber)
                .WithRequired(s => s.Address);

            // настройка Subscriber
            modelBuilder.Entity<Subscriber>()
                .HasMany(sr => sr.Subscription)
                .WithRequired(sn => sn.Subscriber);

            // настройка Street
            modelBuilder.Entity<Street>()
                .Property(s => s.StreetName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(100);
            // связь один-ко-многим Street-Address
            modelBuilder.Entity<Street>()
                .HasMany(s => s.Address)
                .WithRequired(a => a.Street);

            // настройка Operation
            modelBuilder.Entity<Operation>()
                .Property(o => o.OperationDate)
                .IsRequired();

            // настройка OperationType
            modelBuilder.Entity<OperationType>()
                .Property(ot => ot.OpearionName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(100);
            // связь один-ко-многим OperationType-Operation
            modelBuilder.Entity<OperationType>()
                .HasMany(ot => ot.Operation)
                .WithRequired(o => o.OperationType);

            // унаследованная обработка
            base.OnModelCreating(modelBuilder);
        } // OnModelCreating
    } // class PostOfficeDbContext: DbContext
}
