using BennerMicrowave.Application.Tests.Fixtures;
using BennerMicrowave.Domain.Entities;
using System;
using Xunit;

namespace BennerMicrowave.Application.Tests.Unit
{
    public class CookParamUnitTest : IClassFixture<DependancyResolverFixture>
    {
        [Fact]
        public void MUST_BE_INVALID_COOK_PARAM_BY_WRONG_POWERS()
        {
            Assert.False(new CookParams(
                11, // MAX IS TEN
                new TimeSpan(0, 0, 9), // VALID: MAX IS 2 MINUTES
                "Test food"
            ).IsValid);

            Assert.False(new CookParams(
                0, // MAX IS TEN, MIN IS 1
                new TimeSpan(0, 0, 9),
                "Test food"
            ).IsValid);
        }

        [Fact]
        public void MUST_BE_INVALID_COOK_PARAM_BY_WRONG_TIMES()
        {
            Assert.False(new CookParams(
                9,
                new TimeSpan(0, 0, 0), // VALID: MAX IS 2 MINUTES, MIN: 1 SEC
                "Test food"
            ).IsValid);

            Assert.False(new CookParams(
                0,
                new TimeSpan(0, 2, 1), // VALID: MAX IS 2 MINUTES, MIN: 1 SEC
                "Test food"
            ).IsValid);
        }
    }
}
