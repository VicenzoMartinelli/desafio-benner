using BennerMicrowave.Domain.Entities;
using BennerMicrowave.Domain.Events;
using System;

namespace BennerMicrowave.Domain.Interfaces
{
    public interface ICookService
    {
        event EventHandler<CookFractionElapsedArgs> CookFractionTimeElapsedEventHandler;
        event EventHandler CookEndEventHandler;
        void Start(CookParams @params);
        void Stop();
    }
}
