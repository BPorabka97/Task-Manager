using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagerMVC.Models;

namespace TaskManagerMVC.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagerContext _context;
        public TaskRepository(TaskManagerContext context)
        {
            _context = context;
        }
        public TaskModel Get(int taskID)
            => _context.Tasks.SingleOrDefault(x => x.TaskID == taskID);

        public IQueryable<TaskModel> GetAllActive()
            => _context.Tasks.Where(x => x.Done == false);

        public IQueryable<TaskModel> GetAllDone()
            => _context.Tasks.Where(x => x.Done == true);

        public void Add(TaskModel task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void Update(int taskID, TaskModel task)
        {
            var result = _context.Tasks.SingleOrDefault(x => x.TaskID == taskID);
            if (result !=null)
            {
                result.Name = task.Name;
                result.Description = task.Description;
                result.Done = task.Done;

                _context.SaveChanges();
            }
        }

        public void Delete(int taskID)
        {
            var result = _context.Tasks.SingleOrDefault(x => x.TaskID == taskID);
            if (result !=null)
            {
                _context.Tasks.Remove(result);
                _context.SaveChanges();
            }
        }

    }
}
