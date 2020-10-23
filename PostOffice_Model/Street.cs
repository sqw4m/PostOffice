using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice_Model
{
    public class Street
    {
        public Street()
        {
            Address = new HashSet<Address>();
        } // Street

        public int Id { get; set; }
        public string StreetName { get; set; }

        public virtual Plot Plot { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    } // class Street
}
