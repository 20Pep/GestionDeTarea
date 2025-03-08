using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDeTareas.API.Models
{
    public class TaskTypes
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public HashSet<Tasks> tasks = new HashSet<Tasks>();
    }
}
