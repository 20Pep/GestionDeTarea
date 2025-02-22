using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDeTareas.API.Models
{
    public class TaskTypes
    {
        [Key]
        [Column("id_tskTy")]
        public int Id { get; set; }
        [Required]
        [Column("name_tskTy")]
        public string Name { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
    }
}
