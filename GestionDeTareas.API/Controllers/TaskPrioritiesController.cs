using System.Collections.Generic;
using System.Threading.Tasks;
using GestionDeTareas.API.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using GestionDeTareas.API.Data;

namespace GestionDeTareas.API.Controllers
{
    [ApiController]
    [Route("api/taskpriorities")]
    public class TaskPrioritiesController : ControllerBase
    {
        public readonly AppDbContext _context;
        public TaskPrioritiesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var priorities = _context.TaskPriorities.ToList();

            return Ok(priorities);
        }
    }
}
