using System.Collections.Generic;
using System.Threading.Tasks;
using GestionDeTareas.API.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using GestionDeTareas.API.Models.DTOs.Tasks;
using GestionDeTareas.API.Data;

namespace GestionDeTareas.API.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase {

        public readonly AppDbContext _context;

        public TaskController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var tasks = _context.Tasks.ToList();
            
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var task = _context.Tasks.Find(id);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }
    }
}
