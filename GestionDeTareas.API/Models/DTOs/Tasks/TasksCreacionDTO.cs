using System.ComponentModel.DataAnnotations;

namespace GestionDeTareas.API.Models.DTOs.Tasks
{
    public class TasksCreacionDTO
    {

        [StringLength(maximumLength: 150)]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public DateTime? StartDate { get; set; } = DateTime.Now;

        public DateTime? EndDate { get; set; }

        public int PrioritiesId { get; set; }

        public int TypeId { get; set; }

        public int StatusId { get; set; }
    }
}
