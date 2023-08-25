using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Model
{
    public class Category : Base<DateTime, DateTime>
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
