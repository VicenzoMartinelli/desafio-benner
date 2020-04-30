using BennerMicrowave.Domain.Entities;
using BennerMicrowave.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BennerMicrowave.Data.Repositories
{
    public class CookProgramRepository : ICookProgramRepository
    {
        private static readonly List<CookProgram> _cookPrograms = new List<CookProgram>()
        {
            new CookProgram("Frango", "Para frango e carnes brancas", new TimeSpan(0, 0, 60), 9, 'f', new string[] { "Frango", "Carne branca" }),
            new CookProgram("Arroz", "Para arroz e grãos cozidos", new TimeSpan(0, 0, 45), 5, 'A', new string[] { "Arroz" }),
            new CookProgram("Feijão", "Para legumes", new TimeSpan(0, 0, 60), 7, '*', new string[] { "Feijão" }),
            new CookProgram("Sopa", "Para ensopados", new TimeSpan(0, 0, 60), 7, 'x', new string[] { "Sopa" }),
            new CookProgram("Leite", "Para leite", new TimeSpan(0, 0, 60), 5, '=', new string[] { "Leite" })
        };

        public void Add(CookProgram cookProgram)
        {
            _cookPrograms.Add(cookProgram);
        }

        public IEnumerable<CookProgram> Query(params Func<CookProgram, bool>[] predicates)
        {
            IEnumerable<CookProgram> query = _cookPrograms;

            predicates.ToList().ForEach(pred =>
            {
                query = query.Where(pred);
            });

            return query.OrderBy(c => c.Name);
        }

        public IEnumerable<CookProgram> QueryProgramsByEntry(string entry)
        {
            return _cookPrograms
                .Where(c => c.AcceptedEntries.Any(ae => ae.ToLower().Equals(entry.ToLower().Trim())))
                .OrderBy(c => c.Name);
        }
    }
}
