using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Padronize.Data;
using Padronize.Models;
using Padronize.Repositories;
using Padronize.Services;

namespace Padronize.Controllers
{
    [ApiController]
     [Route("api/project")]
    public class ProjectController : ControllerBase
    {
        private readonly ProjectService service;

        public ProjectController(StoreDataContext context, IRepository repository)
        {
            service = new ProjectService(context,repository);
        }

       
        [HttpGet]
        public ActionResult<IEnumerable<Project>> GetProjects()
        {   var projects = service.GetProjects();
            return Ok(projects);
        }

         [HttpGet("{id}")]
        public ActionResult<IEnumerable<Project>> GetProjectId(int id)
        {   var projects = service.GetProjectId(id);
            return Ok(projects);
        }
        
      
        [HttpPost]
        public ActionResult<Project> PostPost([FromBody] Project project)
        {
            var r =  service.newProject(project);
            return new ObjectResult(r.id) { StatusCode = StatusCodes.Status201Created };
        }
    }
}