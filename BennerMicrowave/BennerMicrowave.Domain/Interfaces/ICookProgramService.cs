using BennerMicrowave.Domain.Entities;
using BennerMicrowave.Domain.Events;
using System;
using System.Collections.Generic;

namespace BennerMicrowave.Domain.Services
{
    public interface ICookProgramService
    {
        event EventHandler<ValidationFailsEventArgs> ValidationFails;

        bool Add(CookProgram cookProgram);
        IEnumerable<CookProgram> GetCookPrograms();
        IEnumerable<CookProgram> GetCookProgramsByEntry(string entry);
    }
}
