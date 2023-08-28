using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JM.Model.Generic;

namespace JM.Model
{
    public class CartDetails : Base<DateTime, DateTime>
    {
        public int CartDetailsId { get; set; }
        public int ProductDetailsId { get; set; }
        public int ProductQuantity { get; set; }
        public float CartTotalPrice { get; set; }
        public string CartOrderStatus { get; set; }
        public int UserDetailsId { get; set; }
    }

}