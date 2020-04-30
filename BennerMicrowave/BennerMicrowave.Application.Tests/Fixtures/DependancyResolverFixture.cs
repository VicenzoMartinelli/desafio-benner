using BennerMicroWave.IoC;
using System;

namespace BennerMicrowave.Application.Tests.Fixtures
{
    public class DependancyResolverFixture : IDisposable
    {
        public DependancyResolverFixture()
        {
            Bootstrapper.Initialize();
        }

        public void Dispose()
        {

        }
    }
}
