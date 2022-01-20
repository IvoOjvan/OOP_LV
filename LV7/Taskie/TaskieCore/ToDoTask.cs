using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskieCore
{
    public class ToDoTask
    {
        private string description;
        private int priorityLevel;

        public string Description 
        {
            get { return description; }
            private set { this.description = value; }
        }
        public int PriorityLevel 
        {
            get { return priorityLevel; }
            private set 
            {
                if(value >= 1 && value <= 3) 
                {
                    this.priorityLevel = value;
                }
            }
        }

        public ToDoTask() : this("Task", 1) { }
        public ToDoTask(string description, int priorityLevel) 
        {
            this.Description = description;
            this.PriorityLevel = priorityLevel;
        }

        public override string ToString()
        {
            return $"{Description}\nPriority level: {PriorityLevel}";
        }

    }
}
