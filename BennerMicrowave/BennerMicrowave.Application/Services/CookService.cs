using BennerMicrowave.Domain.Entities;
using BennerMicrowave.Domain.Events;
using BennerMicrowave.Domain.Interfaces;
using System;
using System.Timers;

namespace BennerMicrowave.Application.Services
{
    public class CookService : ICookService
    {
        private readonly Timer _executionTimer;

        private CookParams _params;
        private string _feedback;
        private TimeSpan _remainingTime;
        private bool _running;

        public event EventHandler<CookFractionElapsedArgs> CookFractionTimeElapsedEventHandler;
        public event EventHandler<CookFinishedEventArgs> CookFinishedEventHandler;

        public CookService()
        {
            _running = false;
            _executionTimer = new Timer()
            {
                Interval = 1000,
                Enabled = _running
            };
            _executionTimer.Elapsed += this.Tick;
        }

        private void Tick(object sender, ElapsedEventArgs e)
        {
            _feedback += new string(_params.CookChar, _params.Power);
            _remainingTime -= new TimeSpan(0, 0, 1);

            CookFractionTimeElapsedEventHandler(this, new CookFractionElapsedArgs(_feedback, _remainingTime));

            if (_remainingTime.TotalSeconds == 0)
            {
                Stop();
                CookFractionTimeElapsedEventHandler(this, new CookFractionElapsedArgs(_feedback, _remainingTime));
                CookFinishedEventHandler(this, new CookFinishedEventArgs("aquecida"));
            }

        }
        private void Reset()
        {
            _feedback = _params.ThingToCook;
            _remainingTime = _params.Time;
        }

        public bool Running => _running;
        public void Start(CookParams @params)
        {
            _params = @params;

            Reset();
            _executionTimer.Enabled = _running = true;
        }
        public void Stop()
        {
            _remainingTime = _params.Time;
            _executionTimer.Enabled = _running = false;
        }
        public void Pause()
        {
            _executionTimer.Enabled = _running = false;
        }
        public void Continue()
        {
            _executionTimer.Enabled = _running = true;
        }
    }
}
