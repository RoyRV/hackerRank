using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenges
{
    public class ChallengeSix : IChallenge
    {
        public void ResolveChallenge()
        {
            var arr = new Int64[] { 1, 3, 5 ,7,9};
            Int64 minSum = arr.ToList().OrderBy(x => x).Take(4).Sum();
            Int64 maxSum = arr.ToList().OrderByDescending(x => x).Take(4).Sum();
            Console.WriteLine("{0} {1}", minSum, maxSum);
        }
    }
}
