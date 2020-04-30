using System;

namespace BennerMicrowave.Domain.Events
{
    public class CookFinishedEventArgs : EventArgs
    {
        public string Feedback { get; set; }

        public CookFinishedEventArgs(string feedback)
        {
            this.Feedback = feedback;
        }
    }
}
