using System.Collections.Generic;
using System.Threading.Tasks;
using GestionDeTareas.API.Services;
using GestionDeTareas.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionDeTareas.API.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {
        private readonly TasksService _tasksService;
        public TaskController(TasksService taskservice)
        {
            _tasksService = taskservice;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tasks>>> GetTasks()
        {
            var tasks = await _tasksService.GetTasksAsync();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tasks>> GetTask(int id)
        {
            var task = await _tasksService.GetTaskByIdAsync(id);
            if (task == null)
                return NotFound();

            return Ok(task);
        }


        [HttpPost]
        public async Task<ActionResult<Tasks>> CreateTask(Tasks task)
        {
            var newTask = await _tasksService.CreateTaskAsync(task);
            return CreatedAtAction(nameof(GetTask), new { id = newTask.Id }, newTask);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, Tasks task)
        {
            if (id != task.Id)
                return BadRequest();

            var updated = await _tasksService.UpdateTaskAsync(task);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var deleted = await _tasksService.DeleteTaskAsync(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }



    }
}
