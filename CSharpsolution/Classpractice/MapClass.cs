using System;
using System.Collections.Generic;
using System.Text;

namespace Classpractice
{
    public class MapClass : Imap
    {
        public string Location { get; set; }
        public int HouseNumber { get; set; }

        public void Address()
        {
            Console.WriteLine($"Location {Location} House Number {HouseNumber}");
            Base.StaticMethod();
        }
        public void map()
        {
            
            Console.WriteLine("moon");
        }
    }
}
