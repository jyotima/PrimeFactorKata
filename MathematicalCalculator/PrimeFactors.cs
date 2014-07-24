// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeFactors.cs" company="Microsoft Corporation">
//   2012-2023, All rights reserved.
// </copyright>
// <summary>
//   Defines the PrimeFactors type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MathematicalCalculator
{
    using System;
    using System.Collections.Generic;

    public class PrimeFactors
    {
        public IEnumerable<int> Of(int n)
        {
            if (n == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var factors = new List<int>();

            for (int divisor = 2; n > 1; divisor++)
            {
                for (; n % divisor == 0; n /= divisor)
                {
                    factors.Add(divisor);
                }
            }

            return factors;
        }
    }
}