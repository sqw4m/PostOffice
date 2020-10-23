using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice_Model
{
    public class PublicationType
    {
        public PublicationType()
        {
            Publication = new HashSet<Publication>();
        } // PublicationType

        public int Id { get; set; }
        // название типа издания
        public string TypeName { get; set; }

        public virtual ICollection<Publication> Publication { get; set; }
    } // class PublicationType
}
