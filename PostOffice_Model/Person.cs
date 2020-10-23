using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice_Model
{
    public class Person
    {
        public int Id { get; set; }

        // Фамилия
        public string Surname { get; set; }
        // Имя 
        public string Name { get; set; }
        // Отчество 
        public string Patronymic { get; set; }

        // связные свойства для связи один-ко-одному с сущностями Postman и Subscriber
        public virtual Postman Postman { get; set; }
        public virtual Subscriber Subscriber { get; set; }
    } // class Person
}
