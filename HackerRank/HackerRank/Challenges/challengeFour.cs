using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenges
{
    public class ChallengeFour : IChallenge
    {
        public void ResolveChallenge()
        {
            var array = new int[] { -4, 3, -9, 0, 4, 1 };
            var size = array.Count();
            var greatherThanZeroCount = array.Count(x => x > 0) * 1.0 / size ;
            var zeroCount = array.Count(x => x == 0) * 1.0 / size ;
            var lowerThanZeroCount = array.Count(x => x < 0)  * 1.0 / size ;

            Console.WriteLine(greatherThanZeroCount);
            Console.WriteLine(lowerThanZeroCount);
            Console.WriteLine(zeroCount);
        }
    }
}
