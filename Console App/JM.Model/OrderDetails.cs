using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Model
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int CartDetailsId { get; set; }
        public string OrderPaymentMode { get; set; }
        public int OrderTotalPrice { get; set; }
        public string OrderDeliveryStatus { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
