using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskieCore
{
    public class TaskRepository : ITaskDao
    {
        private List<ToDoTask> tasks;

        public TaskRepository() 
        {
            tasks = new List<ToDoTask>();
        }

        public void AddTask(ToDoTask task)
        {
            tasks.Add(task);
        }

        public void DeleteTask(ToDoTask task)
        {
            for (int i = tasks.Count - 1; i >= 0; i--) 
            {
                if (tasks[i].Description == task.Description && tasks[i].PriorityLevel == task.PriorityLevel) 
                {
                    tasks.RemoveAt(i);
                }
            }
        }

        public void DeleteTasks(string description)
        {
            for (int i = tasks.Count - 1; i >= 0; i--)
            {
                if (tasks[i].Description == description)
                {
                    tasks.RemoveAt(i);
                }
            }
        }

        public IEnumerable<ToDoTask> GetTasks()
        {
            List<ToDoTask> copyTasks = new List<ToDoTask>();
            foreach (DeadlineTask task in tasks) 
            {
                copyTasks.Add(new DeadlineTask(task.Description, task.PriorityLevel, task.Deadline));
            }
            return copyTasks;
        }

        public int NumberOfTasks() 
        {
            int count = tasks.Count(it => it.PriorityLevel == 3);
            return count;
        }
    }
}
