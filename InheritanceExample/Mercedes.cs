using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Mercedes : Car
    {
        public string Owner { get; set; }
        public Mercedes() : base("In First Type Initialize Parent ctor Mercedes")
        {

        }
    }
}
