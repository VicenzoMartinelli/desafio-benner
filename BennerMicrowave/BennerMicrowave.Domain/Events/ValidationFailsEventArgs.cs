using System;

namespace BennerMicrowave.Domain.Events
{
    public class ValidationFailsEventArgs : EventArgs
    {
        public string Feedback { get; set; }

        public ValidationFailsEventArgs(string feedback)
        {
            this.Feedback = feedback;
        }
    }
}
