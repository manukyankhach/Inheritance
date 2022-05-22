using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class BMW : Car
    {
        public string Owner { get; set; }
        public BMW() : base("In First Type Initialize Parent ctor BMW")
        {
                
        }
    }
}
