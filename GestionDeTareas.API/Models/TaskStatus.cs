using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDeTareas.API.Models
{
    public class TaskStatus
    {
        [Key]
        [Column("id_tskSt")]
        public int Id { get; set; }
        [Required]
        [Column("name_tskSt")]
        public string Name { get; set; } 

        public virtual ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
    }
}
