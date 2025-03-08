using System.Collections.Generic;
using System.Threading.Tasks;
using GestionDeTareas.API.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using GestionDeTareas.API.Data;

namespace GestionDeTareas.API.Controllers
{
    [ApiController]
    [Route("api/taskstatus")]
    public class TaskStatusController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TaskStatusController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var status = _context.TaskStatus.ToList();

            return Ok(status);
        }
    }
}
