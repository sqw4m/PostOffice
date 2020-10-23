using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice_Model
{
    public class Address
    {
        public Address()
        {
            Subscriber = new HashSet<Subscriber>();
        } // Address

        public int Id { get; set; }
        public string House { get; set; }
        public int Apartment { get; set; }

        public int StreetId { get; set; }
        public virtual Street Street { get; set; }
        public virtual ICollection<Subscriber> Subscriber { get; set; }
    } // class Address
}
