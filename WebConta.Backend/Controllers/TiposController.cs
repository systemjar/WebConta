using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebConta.Backend.Data;
using WebConta.Shared.Entities;

namespace WebConta.Backend.Controllers
{
    //Data Notation para que funcione como controlador
    [ApiController]
    [Route("api/[controller]")]
    //[Route("api/tipos")]
    public class TiposController : ControllerBase
    {
        //Campo para que se pueda usar en todo el controlador
        private readonly DataContext _context;

        public TiposController(DataContext context)
        {
            _context = context;
        }

        //Metodo que regresa un ActionResult, pero como el metodo es Async entonces regresa un Task y hay que poner un await

        //Para eliminar un registro
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var tipo = await _context.Tipos.FirstOrDefaultAsync(x => x.Id == id);
            if (tipo == null)
            {
                return NotFound();
            }

            _context.Remove(tipo);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        //Para obtener un listad ode todos los tipos
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Tipos.ToListAsync());
        }

        //Sobrecarga del metodo Get para obtener solo un resultado
        //Hay tres formas de pasar parametros
        // 1. Por ruta, 2. Por Query String, 3. Por void
        [HttpGet("{id})")] //Parametro id para saber cual es
        public async Task<IActionResult> GetAsync(int id)
        {
            var tipo = await _context.Tipos.FirstOrDefaultAsync(x => x.Id == id);
            if (tipo == null)
            {
                return NotFound();
            }

            return Ok(tipo);
        }

        //Para grabar un nuevo registro
        [HttpPost]
        public async Task<IActionResult> PostAsync(Tipo tipo)
        {
            _context.Add(tipo);
            await _context.SaveChangesAsync();
            return Ok(tipo);  //Ok es la respuesta del http y regresamos el objeto para saber como quedo al agregarlo
        }

        //Para modificar en la base de datos
        [HttpPut]
        public async Task<IActionResult> PutAsync(Tipo tipo)
        {
            _context.Update(tipo);
            await _context.SaveChangesAsync();
            return NoContent(); //No regesa nada porque ya lo logro actualizar
        }
    }
}