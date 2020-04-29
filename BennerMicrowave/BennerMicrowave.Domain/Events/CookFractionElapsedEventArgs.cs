using System;

namespace BennerMicrowave.Domain.Events
{
    public class CookFractionElapsedArgs : EventArgs
    {
        public string Feedback { get; set; }
        public TimeSpan TimeLeft { get; set; }

        public CookFractionElapsedArgs(string feedback, TimeSpan timeLeft)
        {
            this.Feedback = feedback;
            this.TimeLeft = timeLeft;
        }
    }
}
