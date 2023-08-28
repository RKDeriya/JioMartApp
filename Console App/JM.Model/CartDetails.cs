using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Model
{
    public class CartDetails
    {
        public int CartDetailsId { get; set; }
        public int ProductDetailsId { get; set; }
        public int ProductQuantity { get; set; }
        public float CartTotalPrice { get; set; }
        public string CartOrderStatus { get; set; }
        public int UserDetailsId { get; set; }
    }

}