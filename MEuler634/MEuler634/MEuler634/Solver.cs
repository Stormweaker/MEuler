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
            Solution sol = new Solution();

            sol.AddDecomposition(0, 0);

            return sol;
        }
    }

    /// <summary>
    /// Data object to store number of solutions and the decompositions
    /// </summary>
    public class Solution
    {
        public int NumberOfSolutions { get; private set; }
        public List<long> DecA;
        public List<long> DecB;

        public Solution()
        {
            DecA = new List<long>();
            DecB = new List<long>();

            NumberOfSolutions = 0;
        }

        public void AddDecomposition(long a, long b)
        {
            DecA.Add(a);
            DecB.Add(b);

            NumberOfSolutions++;
        }
    }
}
