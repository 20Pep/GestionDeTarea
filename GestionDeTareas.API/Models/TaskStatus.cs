using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDeTareas.API.Models
{
    public class TaskStatus
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public HashSet<Tasks> tasks = new HashSet<Tasks>();
    }
}
