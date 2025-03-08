using System.Collections.Generic;
using System.Threading.Tasks;
using GestionDeTareas.API.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using GestionDeTareas.API.Data;

namespace GestionDeTareas.API.Controllers
{
    [ApiController]
    [Route("api/tasktypes")]
    public class TaskTypesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public TaskTypesController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var tasks = _context.TaskTypes.ToList();

            return Ok(tasks);
        }
    }
}
