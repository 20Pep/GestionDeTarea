using GestionDeTareas.API.Data;
using GestionDeTareas.API.Models;
using GestionDeTareas.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestionDeTareas.API.Controllers
{
    [ApiController]
    [Route("api/general")]
    public class GeneralController : ControllerBase
    {
        private readonly IGeneralService _generalService;

        public GeneralController(IGeneralService generalService)
        {
            _generalService = generalService;
        }

        [HttpGet("taskpriorities")]
        public async Task<ActionResult<IEnumerable<TaskPriorities>>> GetTaskPriorities()
        {
            return Ok(await _generalService.GetTaskPrioritiesAsync());
        }

        [HttpGet("tasktypes")]
        public async Task<ActionResult<IEnumerable<TaskTypes>>> GetTaskTypes()
        {
            return Ok(await _generalService.GetTaskTypesAsync());
        }

        [HttpGet("taskstatus")]
        public async Task<ActionResult<IEnumerable<Models.TaskStatus>>> GetTaskStatus()
        {
            return Ok(await _generalService.GetTaskStatusAsync());
        }
    }


}
