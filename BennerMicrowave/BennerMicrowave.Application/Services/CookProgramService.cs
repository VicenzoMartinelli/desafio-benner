using BennerMicrowave.Domain.Entities;
using BennerMicrowave.Domain.Events;
using BennerMicrowave.Domain.Interfaces;
using BennerMicrowave.Domain.Services;
using System;
using System.Collections.Generic;

namespace BennerMicrowave.Application.Services
{
    public class CookProgramService : ICookProgramService
    {
        public event EventHandler<ValidationFailsEventArgs> ValidationFails;

        private readonly ICookProgramRepository _repository;
        public CookProgramService(ICookProgramRepository repository)
        {
            _repository = repository;
        }

        public bool Add(CookProgram cookProgram)
        {
            if (!cookProgram.IsValid)
            {
                ValidationFails(this, new ValidationFailsEventArgs(cookProgram.ValidationMessage));
                return false;
            }

            _repository.Add(cookProgram);
            return true;
        }

        public IEnumerable<CookProgram> GetCookPrograms()
        {
            return _repository.Query();
        }

        public IEnumerable<CookProgram> GetCookProgramsByEntry(string entry)
        {
            return _repository.QueryProgramsByEntry(entry);
        }
    }
}
