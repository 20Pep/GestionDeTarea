using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDeTareas.API.Models
{
    public class Tasks
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_Tsk")]
        public int Id { get; set; }
        [Required]
        [Column("name_Tsk")]
        public string Name { get; set; }
        [Required]
        [Column("description_Tsk")]        
        public string Description { get; set; }

        [Column("startDate_Tsk")]
        public DateTime? StartDate { get; set; } = DateTime.Now;

        [Column("endDate_Tsk")]
        public DateTime? EndDate { get; set; }
        [ForeignKey("TaskPriorities")]
        [Column("id_TskPr_Tsk")]
        public int PrioritiesId { get; set; }
        [ForeignKey("TaskTypes")]
        [Column("id_TskTy_Tsk")]
        public int TypeId { get; set; }
        [ForeignKey("TaskStatus")]
        [Column("id_TskSt_Tsk")]
        public int StatusId { get; set; }

        public virtual TaskPriorities TaskPriorities { get; set; }
        public virtual TaskTypes TaskTypes { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }
    }
}
