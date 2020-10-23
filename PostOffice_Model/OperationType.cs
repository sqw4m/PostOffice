using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice_Model
{
    public class OperationType
    {
        public OperationType()
        {
            Operation = new HashSet<Operation>();
        } // OperationType

        public int Id { get; set; }
        // название произведенной пользователем операции 
        public string OpearionName { get; set; }

        public virtual ICollection<Operation> Operation { get; set; }
    } // class OperationType
}
