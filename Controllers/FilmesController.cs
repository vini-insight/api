using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Controllers
{
    [Controller]
    [Route("[controller]")]
    public class FilmesController : ControllerBase
    {
        private DataContext _context { get; set; }
        public FilmesController(DataContext context)
        {
            this._context = context;
        }

        // PARTE 1 // https://medium.com/@gedanmagalhaes/criando-uma-api-rest-com-asp-net-core-3-1-entity-framework-mysql-423c00e3b58e
        // PARTE 2 // https://medium.com/@gedanmagalhaes/criando-uma-api-rest-com-asp-net-core-3-1-entity-framework-mysql-parte-2-e969e82e5d2f

        // EXEMPLO DO POST: https://github.com/GedanMagal/Api-Ef/blob/master/Controllers/ProductController.cs


        // ORIGINAL DO TUTORIAL: 

        // [HttpGet("GetFilmes")]
        // public async Task<ActionResult> GetFilmes()
        // {
        //     // return Ok("estou funfando");
        //     var filmes = await _context.Filmes.ToListAsync();
        //     return Ok(filmes);
        // }
        
        [HttpGet]
        public IActionResult Get()
        {
            // return Ok("estou funfando");
            var filmes = _context.Filmes;
            return Ok(filmes);

        } 

        // ORIGINAL DO TUTORIAL: 
        // [HttpPost]
        // public async Task<ActionResult<Filme>> Post([FromServices]DataContext context, [FromBody]Filme model)
        // {

        //     if (ModelState.IsValid)
        //     {
        //         _context.Filmes.Add(model);
        //         await context.SaveChangesAsync();
        //         return model;
        //     }
        //     else
        //     {
        //         return BadRequest(ModelState);
        //     }
        // }

        [HttpPost]
        public IActionResult Post([FromBody]Filme f)
        {

            if (ModelState.IsValid)
            {
                _context.Filmes.Add(f);                
                _context.SaveChanges();                
                return Ok(f);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}