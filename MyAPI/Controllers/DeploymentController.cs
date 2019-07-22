using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyAPI.Models;
using Microsoft.AspNetCore.Cors;


namespace MyAPI.Controllers
{
    [EnableCors("AllowMyOrigin")]
    [Route("api/Deployment")]
    [ApiController]
    public class DeploymentController : ControllerBase
    {
        private readonly DeploymentGroupContext _context;
        public DeploymentController(DeploymentGroupContext context){
            _context = context;
            if(_context.groups.Count() == 0 ){
                //if no items, create an item
                _context.groups.Add(new DeploymentGroup());
                _context.SaveChanges();
            }
        }

        //Get: api/Deployment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeploymentGroup>>> Get(){
            return await _context.groups.ToListAsync();
        }

        



    }
}