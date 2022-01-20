using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskieCore
{
    public interface ITaskDao
    {
        void AddTask(ToDoTask task);
        IEnumerable<ToDoTask> GetTasks();
        void DeleteTask(ToDoTask task);
        void DeleteTasks(string description);
    }
}
