using GestionDeTareas.API.Data;
using GestionDeTareas.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace GestionDeTareas.API.Models
{
    public class TaskPriorities
    {
        [Key]
        [Column("id_tskPr")]
        public int Id {  get; set; }
        [Required]
        [Column("name_tskPr")]
        public string Name { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
    }
}
