using System;
using System.Linq;

using System.Collections.Generic;
using System.Text;

namespace avant_of_code
{
    class Day03
    {
        private int[] l_data = new int[60];
        private int[] r_data = new int[60];
        private int[] s_data = new int[60];

        public int checkTwo(string input)
        {
            Array.Clear(l_data, 0, 60);
            Array.Clear(r_data, 0, 60);

            for (int i = 0; i < input.Length / 2; ++i)
            {
                l_data[input[i] - 'A']++;
                r_data[input[i + input.Length / 2] - 'A']++;
            }

            //System.Console.WriteLine(string.Join(", ", l_data));
            //System.Console.WriteLine(string.Join(", ", r_data));

            for (int i = 0; i < 60; ++i)
            {
                if ((l_data[i] > 0) && (r_data[i] > 0))
                {
                    if (i < 27)
                    {
                        return i + 27;
                    }
                    else
                    {
                        return i - 31;
                    }
                }
            }

            return -1;
        }

        public int checkThree(string input1, string input2, string input3)
        {
            Array.Clear(l_data, 0, 60);
            Array.Clear(r_data, 0, 60);
            Array.Clear(s_data, 0, 60);

            foreach (char c in input1)
            {
                l_data[c - 'A']++;

            }

            foreach (char c in input2)
            {
                r_data[c - 'A']++;

            }

            foreach (char c in input3)
            {
                s_data[c - 'A']++;

            }



            for (int i = 0; i < 60; ++i)
            {
                if ((l_data[i] > 0) && (r_data[i] > 0) && (s_data[i] > 0))
                {
                    if (i < 27)
                    {
                        return i + 27;
                    }
                    else
                    {
                        return i - 31;
                    }
                }
            }

            return -1;
        }


        public void RucksackReorganization(string[] lines)
        {
            string one_line = lines[0];

            int[] outputs1 = new int[lines.Length];
            int[] outputs2 = new int[lines.Length];
            for (int i = 0; i < lines.Length; ++i)
            {

                outputs1[i] = checkTwo(lines[i]);

            }

            for (int i = 0; i < lines.Length/3; ++i)
            {

                outputs2[i] = checkThree(lines[3 * i], lines[3 * i + 1], lines[3 * i + 2]);

            }

            System.Console.WriteLine("answer 1 is " + outputs1.Sum());
            System.Console.WriteLine("answer 2 is " + outputs2.Sum());


        }
    }
}
