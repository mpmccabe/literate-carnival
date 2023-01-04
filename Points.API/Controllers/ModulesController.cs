using Microsoft.AspNetCore.Mvc;
using Points.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Points.API.Controllers
{
    [Route("api/modules")]
    [ApiController]
    public class ModulesController : ControllerBase
    {
        private readonly IModuleRepository _moduleRepository;
        public ModulesController(IModuleRepository modulesRepository)
        {
            _moduleRepository = modulesRepository;
        }

        [HttpGet]
        public IActionResult GetAllModules()
        {
            return Ok(_moduleRepository.GetAllModules());
        }
    }
}
