using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenges
{
    public class ChallengeTwo : IChallenge
    {
        public void ResolveChallenge()
        {
            var array1 = new int[] { 17 ,28 ,30 };
            var array2 = new int[] { 99 ,16, 8 };

            var points1 = 0;
            var points2 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > array2[i])
                    points1++;
                else if (array1[i] < array2[i])
                    points2++;
            }

            var result = new int[] { points1,points2 };
            Console.WriteLine("Output {0}", result);
        }
    }
}
