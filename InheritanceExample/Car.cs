using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public abstract class Car
    {
        public string MarkName { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Power { get; set; }

        public Car(string input)
        {
            
        }
        
        public void Run(string item)
        {
            Console.WriteLine($"Run {item}");
        }
    }
}
