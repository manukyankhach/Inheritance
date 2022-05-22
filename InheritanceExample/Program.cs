using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW bMW = new BMW();
            bMW.MarkName = "E46";
            bMW.Color = "Silver";
            bMW.Power = 170;
            bMW.Type = "Sedan";
            bMW.Owner = "Xcho";
            bMW.Run("BMW");
            Console.WriteLine("==============");
            Mercedes mercedes = new Mercedes();
            mercedes.MarkName = "C250";
            mercedes.Owner = "Mher";
            mercedes.Power = 250;
            mercedes.Type = "Sedan";
            mercedes.Color = "Blue";
            mercedes.Run("Mercedes");
            Console.ReadLine();
        }
    }
}
