using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Model.Generic
{
    public class Base<T, I>
    {
        public T CreatedOn { get; set; }
        public I UpdatedOn { get; set; }
    }
}
