using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice_Model
{
    public class Subscriber
    {
        public Subscriber()
        {
            Subscription = new HashSet<Subscription>();
        } // Subscriber

        public int Id { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Subscription> Subscription { get; set; }
    } // class Subscriber
}
