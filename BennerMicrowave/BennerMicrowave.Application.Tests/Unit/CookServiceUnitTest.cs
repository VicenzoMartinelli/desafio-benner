using BennerMicrowave.Application.Tests.Fixtures;
using BennerMicrowave.Domain.Entities;
using BennerMicrowave.Domain.Interfaces;
using BennerMicroWave.IoC;
using System.Threading;
using Xunit;

namespace BennerMicrowave.Application.Tests.Unit
{
    public class CookServiceUnitTest : IClassFixture<DependancyResolverFixture>
    {
        [Fact]
        public void MUST_RETURN_RIGHT_OUTPUT_ON_COOKING_BY_POWER_AND_TIME()
        {
            var cookService = ServiceContainer.Get<ICookService>();
            var feedback = "Frango";

            cookService.CookFractionTimeElapsedEventHandler += (sender, e) =>
            {
                feedback = e.Feedback;
            };
            cookService.CookFinishedEventHandler += (sender, e) =>
            {
                feedback += e.Feedback;
            };
            cookService.Start(new CookParams(3, new System.TimeSpan(0, 0, 3), "Frango", 'x'));

            while (cookService.Running)
            {
                Thread.Sleep(10);
            }

            Assert.Equal("Frangoxxxxxxxxxaquecida", feedback);
        }
    }
}
