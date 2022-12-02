using System;
using System.Linq;

using System.Collections;
using System.Collections.Generic; //Needed for Lists

using System.Xml; //Needed for XML functionality
using System.Xml.Serialization; //Needed for XML Functionality

using System.IO;
using System.Xml.Linq; //Needed for XDocument

namespace advent_of_code
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] lines = File.ReadAllLines("../../../Day01.txt");

            var solution = new Day01();
            
            var output = solution.CalorieCounting01(lines);

            int x = 3;

        }
    }
}
