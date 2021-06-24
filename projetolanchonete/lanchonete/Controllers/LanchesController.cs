using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lanchonete.Data;
using lanchonete.Models;

namespace lanchonete.Controllers
{
    [ApiController]
    [Route("lanchonete/lanches")]

    public class LanchesController : ControllerBase
    {
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Lanches>>> Get([FromServices] DataContext context)
        {
            var lanches = await context.Lanche.ToListAsync();
            return lanches;
        }

        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Lanches>> Post(
            [FromServices] DataContext context,
            [FromBody] Lanches model
        )
        {
            if(ModelState.IsValid){
                context.Lanche.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else{
                return BadRequest(ModelState);
            }
        }
    }
}