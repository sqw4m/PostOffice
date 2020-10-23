using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice_Model
{
    public class Subscription
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        // срок подписки
        public int Term { get; set; }

        public int PublicationId { get; set; }
        public int SubscriberId { get; set; }

        public virtual Publication Publication { get; set; }
        public virtual Subscriber Subscriber { get; set; }
    } // class Subscription
}
