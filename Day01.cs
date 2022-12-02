using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_of_code
{
    class Day01
    {

        public int CalorieCounting01(string[] lines)
        {
            var foods = new List<int>();
            int one_worker = 0;
            foreach (string i in lines)
            {
                if (i.Length == 0)
                {
                    foods.Add(one_worker);
                    one_worker = 0;
                }
                else 
                {
                    one_worker += Int32.Parse(i);
                }
            }

            return foods.Max();
        }

    }
}
