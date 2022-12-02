using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avant_of_code
{
    class Day02
    {




        public int Play(char L_w, char R_w)
        {

            int L = L_w - 'A';
            int R = R_w - 'X';


            if (L == R)
            {
                return 3;
            }
            else if (-1 == (L - R))
            {
                return 6;
            }
            else if (2 == (L - R))
            {
                return 6;
            }

            return 0;
        }

                    
        public int RockPaperScissors01(string[] lines)
        {
            int sum = 0;
            foreach (string i in lines)
            {
                sum += Play(i[0], i[2]);

                sum += i[2] - 'X' + 1;


            }

            return sum;
        }

        public int RockPaperScissors02(string[] lines)
        {
            int sum = 0;
            foreach (string i in lines)
            {
                if ('Y' == i[2]) 
                {
                    sum += 3;
                    if ('A' == i[0]) { sum += 1; }
                    if ('B' == i[0]) { sum += 2; }
                    if ('C' == i[0]) { sum += 3; }
                }

                if ('X' == i[2])
                {
                    sum += 0;
                    if ('A' == i[0]) { sum += 3; }
                    if ('B' == i[0]) { sum += 1; }
                    if ('C' == i[0]) { sum += 2; }
                }

                if ('Z' == i[2])
                {
                    sum += 6;
                    if ('A' == i[0]) { sum += 2; }
                    if ('B' == i[0]) { sum += 3; }
                    if ('C' == i[0]) { sum += 1; }
                }


            }

            return sum;
        }


        public void RockPaperScissors(string[] lines)
        {
            var output1 = RockPaperScissors01(lines);
            var output2 = RockPaperScissors02(lines);


            System.Console.WriteLine("answer 1 is " + output1);

            System.Console.WriteLine("answer 2 is " + output2);
        }

    }
}
