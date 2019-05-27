using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenges
{
    public class ChallengeThree : IChallenge
    {
        /*
        Given a square matrix, calculate the absolute difference between the sums of its diagonals.
        For example, the square matrix arr is shown below: 
        1 2 3
        4 5 6
        9 8 9  


        The left-to-right diagonal 1 +5 +9=15 . The right to left diagonal 3+5+9 = 17 . Their absolute difference is 15-17=2.
        */
        public void ResolveChallenge()
        {

            var array = new int[][] {
                new int[] { 11, 2, 4 } ,
                new int[] { 4, 5, 6 } ,
                new int[] { 10, 8, -12 }
            };
            var result = diagonalDifference(array);

            Console.WriteLine("result : {0}", result);
        }

        private int diagonalDifference(int[][] arr)
        {
            var number = 0;
            int diagonal1 = 0, diagonal2 = 0;
            var size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                diagonal1 += arr[i][i];
                diagonal2 += arr[size - i - 1][i];
            }
            number = diagonal1 - diagonal2;
            return Math.Abs(number);
        }
    }
}
