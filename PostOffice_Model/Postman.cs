using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice_Model
{
    public class Postman
    {
        public Postman()
        {
            Plot = new HashSet<Plot>();
        } // Postman

        public int Id { get; set; }

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        // связные свойства для связи один-ко-многим с сущностью Plot
        public virtual ICollection<Plot> Plot { get; set; }
    } // class Postman
}
