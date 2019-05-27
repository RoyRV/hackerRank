using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenges
{
    public class ChallengeFive : IChallenge
    {
        /*
         Consider a staircase of size : n=4
           #
          ##
         ###
        ####
             */
        public void ResolveChallenge()
        {
            var number = 6;
            for (int i = 1; i <= number; i++)
            {
                var text = "".PadLeft(i, '#');
                var spaceText = "".PadLeft(number - i, ' ');
                text = spaceText + text;
                Console.WriteLine(text);
            }
        }
    }
}
