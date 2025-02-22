
using GestionDeTareas.API.Models;
using Microsoft.EntityFrameworkCore;



namespace GestionDeTareas.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Tasks> Tasks { get; set; } 
        public DbSet<TaskPriorities> TaskPriorities { get; set; }
        public DbSet<TaskTypes> TaskTypes { get; set; }
        public DbSet<Models.TaskStatus> TaskStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Datos iniciales de prueba
            modelBuilder.Entity<TaskPriorities>().HasData(
                new TaskPriorities{ Id = 1, Name = "Baja" },
                new TaskPriorities { Id = 2, Name= "Media" },
                new TaskPriorities { Id = 3, Name = "Alta" }
            );

            modelBuilder.Entity<TaskTypes>().HasData(
                new TaskTypes { Id = 1, Name = "Trabajo" },
                new TaskTypes { Id = 2, Name = "Personal" },
                new TaskTypes { Id = 3, Name = "Estudio" }
            );

            modelBuilder.Entity<Models.TaskStatus>().HasData(
                new Models.TaskStatus { Id = 1, Name = "Pendiente"},
                new Models.TaskStatus { Id = 2, Name = "Pausado" },
                new Models.TaskStatus { Id = 3, Name = "Finalizado" }
                );



            base.OnModelCreating(modelBuilder);
        }


    }
}
