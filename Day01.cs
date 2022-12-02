using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_of_code
{
    class Day01
    {
        List<int> foods = new List<int>();

        public int CalorieCounting01(string[] lines)
        {
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

            foods.Sort();
            foods.Reverse();
            return foods[0];
        }


        public int CalorieCounting02()
        {
            
            return foods[0] + foods[1] + foods[2];
        }


        public void CalorieCounting(string[] lines)
        {
            var output1 = CalorieCounting01(lines);
            var output2 = CalorieCounting02();

            System.Console.WriteLine("answer 1 is " + output1);

            System.Console.WriteLine("answer 2 is " + output2);
        }

    }
}
