using BennerMicrowave.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BennerMicrowave.Domain.Interfaces
{
    public interface ICookProgramRepository
    {
        void Add(CookProgram cookProgram);
        IEnumerable<CookProgram> Query(params Func<CookProgram, bool>[] predicates);
        IEnumerable<CookProgram> QueryProgramsByEntry(string entry);
    }
}
