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
        public List<double> ListA;
        public List<double> ListB;
        public List<double> ListX;

        public Solution()
        {
            ListA = new List<double>();
            ListB = new List<double>();
            ListX = new List<double>();

            NumberOfSolutions = 0;
        }

        public void AddDecomposition(double a, double b)
        {
            if (!ListX.Contains(Math.Pow(a, 2) * Math.Pow(b, 3)))
            {
                ListA.Add(a);
                ListB.Add(b);
                ListX.Add(Math.Pow(a, 2) * Math.Pow(b, 3));

                NumberOfSolutions++;

            }
        }
    }
}
