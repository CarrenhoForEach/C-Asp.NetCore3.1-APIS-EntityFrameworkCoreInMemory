using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lanchonete.Data;
using lanchonete.Models;

namespace lanchonete.Controllers
{
    [ApiController]
    [Route("lanchonete/ingredientes")]

    public class IngredientesController : ControllerBase
    {
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Ingredientes>>> Get([FromServices] DataContext context)
        {
            var ingredientes = await context.Ingrediente.Include(x => x.Lanches).ToListAsync();
            return ingredientes;
        }

        [HttpGet]
        [Route("{id:int}")]

        public async Task<ActionResult<Ingredientes>> GetById([FromServices] DataContext context, int id)
        {
            var ingredientes = await context.Ingrediente.Include(x => x.Lanches)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
            return ingredientes;
        }

        [HttpGet]
        [Route("Lanches/{id:int}")]

        public async Task<ActionResult<List<Ingredientes>>> GetByLanches([FromServices] DataContext context, int id)
        {
            var ingredientes = await context.Ingrediente
            .Include(x => x.Lanches)
            .AsNoTracking()
            .Where(x => x.LanchesId == id)
            .ToListAsync();
            return ingredientes;
        }

        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Ingredientes>> Post(
            [FromServices] DataContext context,
            [FromBody] Ingredientes model
        )
        {
            if(ModelState.IsValid)
            {
                context.Ingrediente.Add(model);
                await context.SaveChangesAsync();
                return model;

            }else{
                return BadRequest(ModelState);
            }
        }
    }
}