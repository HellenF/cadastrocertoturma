using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cadastrocertoturma.Data;
using cadastrocertoturma.Models;
using System;
using Microsoft.AspNetCore.Authorization;

namespace escola.Controllers
{
    [ApiController]
    [Route("v1/Turmas")]
    public class CategoryController : Controller
    {
        [HttpGet]
        [Route("")]
        [AllowAnonymous]
        
        public async Task<ActionResult<List<Turma>>> Get([FromServices] DataContext context)
        {
            var Turma = await context.Turma.AsNoTracking().ToListAsync();
            return Turma;
        }



        [HttpPost]
        [Route("")]
        // [Authorize(Roles = "employee")]
        [AllowAnonymous]
        public async Task<ActionResult<Turma>> Post(
            [FromServices] DataContext context,
            [FromBody]Turma model)
        {
            // Verifica se os dados são válidos
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                context.Turma.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Não foi possível criar a turma" });

            }
        }

       
    }
}