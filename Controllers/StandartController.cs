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
    [Route("api/Standart")]
    public class StandartController : ControllerBase
    {
        private readonly StandartService service;

        public StandartController(StoreDataContext context, IRepository repository)
        {
            service = new StandartService(context,repository);
        }

        [HttpGet]
        public  ActionResult<IEnumerable<Standart>> GetStandarts()
        {   var Standarts =  service.GetStandarts();
            return Ok(Standarts);
        }
        
        
        [HttpPost]
        public  ActionResult<Standart> NewStandart([FromBody] Standart Standart)
        {
            var r =  service.newStandart(Standart);
            return new ObjectResult(r.id) { StatusCode = StatusCodes.Status201Created };
        }
    }
}