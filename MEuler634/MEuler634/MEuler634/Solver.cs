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
        public static Solution BruteForce(double n)
        {
            Solution sol = new Solution();

            double a = 2;
            double b = 2;

            for (; Math.Pow(a, 2) * Math.Pow(b, 3) <= n; a++)
            {
                for(; Math.Pow(a, 2) * Math.Pow(b, 3) <= n; b++)
                {
                    sol.AddDecomposition(a, b);
                }

                b = 2;
            }
            
            return sol;
        }
    }

    /// <summary>
    /// Data object to store number of solutions and the decompositions
    /// </summary>
    public class Solution
    {
        public int NumberOfSolutions { get; private set; }
        public List<double> DecA;
        public List<double> DecB;

        public Solution()
        {
            DecA = new List<double>();
            DecB = new List<double>();

            NumberOfSolutions = 0;
        }

        public void AddDecomposition(double a, double b)
        {
            DecA.Add(a);
            DecB.Add(b);

            NumberOfSolutions++;
        }
    }
}
