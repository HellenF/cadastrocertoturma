using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cadastrocertoturma.Data;
using cadastrocertoturma.Models;
using Microsoft.AspNetCore.Authorization;


namespace escola.Controllers
{
    [Route("v1/Alunos")]
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Aluno>>> Get([FromServices] DataContext context)
        {
            
            var alunos = await context.Alunos.(x => Turmas)
                .AsNoTracking()
                .ToListAsync();
            
            return alunos;
        }
        [HttpPost]
        [Route("")]
       
        public async Task<ActionResult<Aluno>> Post(
            [FromServices] DataContext context,
            [FromBody]Aluno model)
        {
            if (ModelState.IsValid)
            {
                context.Alunos.(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}