using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Model
{
    public class UserDetails : Base<DateTime, DateTime>
    {
        public int UserDetailsId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserAddress { get; set; }
        public string UserMobileNo { get; set; }
        public float UserWalletBalance { get; set; }
    }
}
