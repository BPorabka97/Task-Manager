using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagerMVC.Models;

namespace TaskManagerMVC.Repositories
{
    public interface ITaskRepository
    {
        TaskModel Get(int taskID);
        IQueryable<TaskModel> GetAllActive();
        IQueryable<TaskModel> GetAllDone();
        void Add(TaskModel task);
        void Update(int taskID, TaskModel tasks);
        void Delete(int taskID);
    }
}
