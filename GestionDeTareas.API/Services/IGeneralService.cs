using GestionDeTareas.API.Models;

namespace GestionDeTareas.API.Services
{
    public interface IGeneralService
    {
        Task<IEnumerable<TaskPriorities>> GetTaskPrioritiesAsync();
        Task<IEnumerable<TaskTypes>> GetTaskTypesAsync();
        Task<IEnumerable<Models.TaskStatus>> GetTaskStatusAsync();
    }
}
