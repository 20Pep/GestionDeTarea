using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestionDeTareas.API.Data;
using GestionDeTareas.API.Models;


namespace GestionDeTareas.API.Services
{
    public class TasksService
    {
        private readonly AppDbContext _context;

        public TasksService(AppDbContext context) {
            _context = context; 
        }

        public async Task<IEnumerable<Tasks>> GetTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<Tasks?> GetTaskByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task<Tasks> CreateTaskAsync(Tasks task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<bool> UpdateTaskAsync(Tasks task)
        {
            if (!_context.Tasks.Any(t => t.Id == task.Id))
                return false;

            _context.Entry(task).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteTaskAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
                return false;

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
