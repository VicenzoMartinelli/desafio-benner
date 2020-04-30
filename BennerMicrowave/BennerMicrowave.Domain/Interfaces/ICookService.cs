using BennerMicrowave.Domain.Entities;
using BennerMicrowave.Domain.Events;
using System;

namespace BennerMicrowave.Domain.Interfaces
{
    public interface ICookService
    {
        event EventHandler<CookFractionElapsedArgs> CookFractionTimeElapsedEventHandler;
        event EventHandler<CookFinishedEventArgs> CookFinishedEventHandler;
        void Start(CookParams @params);
        void Stop();
        void Pause();
        void Continue();
    }
}
