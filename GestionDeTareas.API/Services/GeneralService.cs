using GestionDeTareas.API.Data;
using GestionDeTareas.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionDeTareas.API.Services
{
    public class GeneralService : IGeneralService
    {
        private readonly AppDbContext _context;

        public GeneralService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TaskPriorities>> GetTaskPrioritiesAsync()
        {
            return await _context.TaskPriorities.ToListAsync();
        }

        public async Task<IEnumerable<TaskTypes>> GetTaskTypesAsync()
        {
            return await _context.TaskTypes.ToListAsync();
        }

        public async Task<IEnumerable<Models.TaskStatus>> GetTaskStatusAsync()
        {
            return await _context.TaskStatus.ToListAsync();
        }
    }

}
