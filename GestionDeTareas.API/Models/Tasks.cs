using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GestionDeTareas.API.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;
  
        public string? Description { get; set; }

        public DateTime? StartDate { get; set; } = DateTime.Now;


        public DateTime? EndDate { get; set; }

        [ForeignKey("TaskPriorities")]
        public int PrioritiesId { get; set; }

        [ForeignKey("TaskTypes")]
        public int TypeId { get; set; }

        [ForeignKey("TaskStatus")]
  
        public int StatusId { get; set; }

        public TaskPriorities? priorities { get; set; }
        public TaskTypes? type { get; set; }

        public TaskStatus? status { get; set; }
    }
}
