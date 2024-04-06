using Beheer.Handlers;
using Dto.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IGetProjectsHandler _getProjectsHandler;
        public ProjectsController(IGetProjectsHandler getProjectsHandler)
        {
            _getProjectsHandler = getProjectsHandler;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectsDto>>> getProjectsAsync()
        {
            var result = await _getProjectsHandler.HandleAsync();

            if (result == null)
            {
                return NotFound("Geen projects gevonden");
            }
            return Ok(result);
        }
    } 
}
