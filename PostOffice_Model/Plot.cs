using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice_Model
{
    public class Plot
    {
        public Plot()
        {
            Street = new HashSet<Street>();
            Operation = new HashSet<Operation>();
        } // Plot

        public int Id { get; set; }
        // номер(имя) участка
        public string PlotNumber { get; set; }

        public int PostmanId { get; set; }

        public virtual ICollection<Street> Street { get; set; }
        public virtual Postman Postman { get; set; }
        public virtual ICollection<Operation> Operation { get; set; }
    } // class Plot
}
