using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice_Model
{
    public class Operation
    {
        public int Id { get; set; }
        public DateTime OperationDate { get; set; }
        public virtual OperationType OperationType { get; set; }
        public virtual Plot Plot { get; set; }
    } // class Order
}
