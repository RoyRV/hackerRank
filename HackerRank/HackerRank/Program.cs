using HackerRank.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var line = Console.ReadLine().Trim();
            int.TryParse(line, out int challengeNumber);

            if (challengeNumber == 1)
            {
                ChanllengeOne challenge = new ChanllengeOne();
                challenge.ResolveChallenge();
            }
            else if (challengeNumber == 2)
            {
                ChallengeTwo challenge = new ChallengeTwo();
                challenge.ResolveChallenge();
            }
            else if (challengeNumber == 3)
            {
                ChallengeThree challenge = new ChallengeThree();
                challenge.ResolveChallenge();
            }
            else if (challengeNumber == 4)
            {
                ChallengeFour challenge = new ChallengeFour();
                challenge.ResolveChallenge();
            }
            else if (challengeNumber == 5)
            {
                ChallengeFive challenge = new ChallengeFive();
                challenge.ResolveChallenge();
            }
            else {
                Console.WriteLine("Challenge not found");
            }
            Console.ReadKey();
        }
    }
}
