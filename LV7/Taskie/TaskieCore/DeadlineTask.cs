using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskieCore
{
    public class DeadlineTask : ToDoTask
    {
        public DateTime Deadline { get; private set; }

        public DeadlineTask(string description, int priorityLevel, DateTime deadline) 
            : base(description, priorityLevel)
        {
            Deadline = deadline;
        }

        public DeadlineTask() : base()
        {
            Deadline = DateTime.Now;
        }

        public TimeSpan CalculateTimeAwait() 
        {
            TimeSpan timeRemaining = Deadline - DateTime.Now;
            if (timeRemaining.TotalMinutes < 0)
            {
                return new TimeSpan(0);
            }
            else 
            {
                return timeRemaining;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nDeadline: {Deadline.ToShortDateString()}";
        }
    }
}
