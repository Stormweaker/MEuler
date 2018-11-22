using System;
using System.Collections.Generic;
using System.Text;

namespace MEuler634
{
    public static class Solver
    {
        /// <summary>
        /// Brute force solution to the problem
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Solution of the problem</returns>
        public static Solution BruteForce(long n)
        {

            return null;
        }
    }

    /// <summary>
    /// Data object to store number of solutions and the decompositions
    /// </summary>
    public class Solution
    {
        public int NumberOfSolutions { get; private set; }
        public List<long> a;
        public List<long> b;

        public Solution()
        {
            a = new List<long>();
            b = new List<long>();

            NumberOfSolutions = 0;
        }
    }
}
