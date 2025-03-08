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
        public int Id {  get; set; }
        public string Name { get; set; } = null!;
        public HashSet<Tasks> tasks = new HashSet<Tasks>();
    }
}
