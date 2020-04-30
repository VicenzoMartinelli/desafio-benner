using BennerMicrowave.Application.Services;
using BennerMicrowave.Data.Repositories;
using BennerMicrowave.Domain.Interfaces;
using BennerMicrowave.Domain.Services;

namespace BennerMicroWave.IoC
{
    public static class Bootstrapper
    {
        public static void Initialize()
        {
            ServiceContainer.AddService<ICookService, CookService>(
                createFunction: () => new CookService()
            );

            ServiceContainer.AddService<ICookProgramRepository, CookProgramRepository>(
                createFunction: () => new CookProgramRepository()
            );

            ServiceContainer.AddService<ICookProgramService, CookProgramService>(
                createFunction: () => new CookProgramService(ServiceContainer.Get<ICookProgramRepository>())
            );
        }
    }
}
