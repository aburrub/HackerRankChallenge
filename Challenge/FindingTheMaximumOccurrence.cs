using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Challenge
{
    public class FindingTheMaximumOccurrence
    {

        public void ExecuteChallenge()
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            int moves = int.Parse(line1.Split(' ')[1]);
            int[] array = Array.ConvertAll<string, int>(line2.Split(' '), Convert.ToInt32);


            Array.Sort<int>(array);
            Array.Reverse(array);

            int r1 = int.MinValue, r2 = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                int[] array2 = (int[])array.Clone();
                int moves2 = moves;
                for (int j = 0; j < array.Length; j++)
                {
                    while (moves2 > 0 && array2[i] > array2[j])
                    {
                        array2[j]++;
                        moves2--;
                        if (moves2 == 0)
                            break;
                    }
                    if (moves2 == 0)
                        break;
                }

                // find the max
                Hashtable table = new Hashtable();
                int max = int.MinValue, maxKey = int.MinValue;
                foreach (int num in array2)
                {
                    if (table[num] == null)
                        table.Add(num, 1);
                    else
                        table[num] = (int)table[num] + 1;
                }
                foreach (int key in table.Keys)
                {
                    if (max < (int)table[key])
                    {
                        maxKey = key;
                        max = (int)table[key];
                    }
                }

                if (r2 < max)
                {
                    r1 = maxKey;
                    r2 = max;
                }

            }

            Console.WriteLine($"{r2} {r1}");
        }
    }
}
