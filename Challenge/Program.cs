using System;
using System.Collections;
using System.Linq;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Challenge.01 Finding the Maximum Occurence */
            /* https://www.hackerrank.com/contests/icebreak-1/challenges/finding-the-maximum-occurrence/problem */
            var obj = new FindingTheMaximumOccurrence();
            obj.ExecuteChallenge();

            /* Challenge.02 String Compression */
            /* https://www.hackerrank.com/challenges/string-compression/problem */
            var input = "jhsdjkfhhhhhhhhhhhhhhhhhhhhhhhhhkjsdhfkshhddddddddddddddeeeeeeeeeeeff";
            var compressor = new StringCompression();
            compressor.ExecuteChallenge(input);
        }
    }
}
