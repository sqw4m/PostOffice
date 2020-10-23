using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice_Model
{
    public class Publication
    {
        public Publication()
        {
            Subscription = new HashSet<Subscription>();
        } // Publication

        public int Id { get; set; }
        // индекс
        public string Index { get; set; }
        // название
        public string PublicationName { get; set; }
        // цена
        public double Price { get; set; }
        // внешний ключ типа печатного издания
        public int PublicationTypeId { get; set; }
        public virtual PublicationType PublicationType { get; set; }
        public virtual ICollection<Subscription> Subscription { get; set; }
    } // class Publication
}
