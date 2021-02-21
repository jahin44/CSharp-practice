using System;
using System.Collections.Generic;
using System.Text;

namespace Classpractice
{
     public interface Imap
    {
        public string Location { get; set;}
        public int HouseNumber { get; set; }
        public void Address();
        public void map()
        {
            Console.WriteLine("puspita ");
            

        }

    }
}
