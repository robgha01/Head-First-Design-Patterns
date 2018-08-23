using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = new StreamReader(new LowerCaseInputStream()))
            {
                var data = stream.ReadToEnd();
                Console.Write(data);
            }
        }
    }
}
