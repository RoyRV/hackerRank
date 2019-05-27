using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenges
{
    public class ChanllengeOne : IChallenge
    {
        /*
        John works at a clothing store. He has a large pile of socks that he must pair by color for sale. Given an array of integers representing the color of each sock, 
        determine how many pairs of socks with matching colors there are.
        For example, there are  socks with colors . There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .
        Function Description
        Complete the sockMerchant function in the editor below. It must return an integer representing the number of matching pairs of socks that are available.
        sockMerchant has the following parameter(s):

        n: the number of socks in the pile
        ar: the colors of each sock
        
        Input Format
        The first line contains an integer , the number of socks represented in . 
        The second line contains  space-separated integers describing the colors  of the socks in the pile.

        Output Format
        Return the total number of matching pairs of socks that John can sell.

        Sample Input
        9
        10 20 20 10 10 30 50 10 20

        Sample Output
        3
        */
         

        public void ResolveChallenge()
        {
            var arreglo = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            Console.WriteLine("Input : {0}", arreglo);
            var distinct = arreglo.OfType<int>().GroupBy(x => x, (x, g) => new { id = x, count = g.Count() / 2 });
            var NumberOfPairs = distinct.Sum(x => x.count);
            Console.WriteLine("Output : {0}", NumberOfPairs);
        }
    }
}
