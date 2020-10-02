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
    [Route("api/application")]
    public class ApplicationController : ControllerBase
    {
        private readonly ApplicationService service;

        public ApplicationController(StoreDataContext context, IRepository repository)
        {
            service = new ApplicationService(context,repository);
        }

        
        [HttpGet]
        public  ActionResult<IEnumerable<Application>> GetApplications()
        {   var Applications =  service.GetApplications();
            return Ok(Applications);
        }
        
        
        [HttpPost]
        public  ActionResult<Application> NewApplication([FromBody] Application Application)
        {
            var r =  service.newApplication(Application);
            return new ObjectResult(r.id) { StatusCode = StatusCodes.Status201Created };
        }
    }
}