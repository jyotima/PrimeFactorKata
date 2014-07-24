// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="Microsoft Corporation">
//   2012-2023, All rights reserved.
// </copyright>
// <summary>
//   Defines the PrimeFactorsTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MathematicalCalculator.UnitTests
{
    using System;
    using System.Collections.Generic;

    using FluentAssertions;

    using Xunit;
    using Xunit.Extensions;

    public class PrimeFactorsTests
    {
        private readonly PrimeFactors primeFactors = new PrimeFactors();

        public static IEnumerable<object> PrimeNumbersInput
        {
            get
            {
                return new[]
                           {
                               new object[] { 2, new[] { 2 } }, 
                               new object[] { 3, new[] { 3 } },
                               new object[] { 4, new[] { 2, 2 } },
                               new object[] { 5, new[] { 5 } },
                               new object[] { 6, new[] { 2, 3 } },
                               new object[] { 7, new[] { 7 } },
                               new object[] { 8, new[] { 2, 2, 2 } },
                               new object[] { 9, new[] { 3, 3 } },
                               new object[] { 21, new[] { 3, 7 } },
                               new object[] { 2 * 3 * 11 * 5 * 2 * 3, new[] { 2, 3, 11, 5, 2, 3 } }
                           };
            }
        }

            [Fact]
        public void ShouldBeAbleToCalculatePrimeFactorsOfOne()
        {
            var factors = this.primeFactors.Of(1);

            factors.Should().BeEmpty();
        }

        [Theory]
        [PropertyData("PrimeNumbersInput")]
        public void ShouldBeAbleToCalculatePrimeFactors(int n, IEnumerable<int> expectedFactors)
        {
            var factors = primeFactors.Of(n);

            factors.ShouldBeEquivalentTo(expectedFactors);
        }

        [Fact]
        public void ShouldThrowForZero()
        {
            Action action = () => primeFactors.Of(0);

            action.ShouldThrow<ArgumentOutOfRangeException>();
        }
    }
}