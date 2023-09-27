using DL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private DL.ModelContext _context;

        public UsuarioController(DL.ModelContext context) 
        { 
            _context = context;
        }

        [HttpGet]
        public async Task<List<Usuario>> Listar()
        {
            return await _context.Usuarios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> BuscarPorId(decimal id)
        {
            var retorno = await _context.Usuarios.FirstOrDefaultAsync(x => x.Idusuario == id);

            if (retorno != null)
                return retorno;
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> Guardar(Usuario c)
        {
            try
            {
                await _context.Usuarios.AddAsync(c);
                await _context.SaveChangesAsync();
                c.Idusuario = await _context.Usuarios.MaxAsync(u => u.Idusuario);

                return c;
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Se encontró un error");
            }
        }

        [HttpPut]
        public async Task<ActionResult<Usuario>> Actualizar(Usuario c)
        {
            if (c == null || c.Idusuario == 0)
                return BadRequest("Faltan datos");

            Usuario cat = await _context.Usuarios.FirstOrDefaultAsync(x => x.Idusuario == c.Idusuario);

            if (cat == null)
                return NotFound();

            try
            {
                cat.Nombre = c.Nombre;
                _context.Usuarios.Update(cat);
                await _context.SaveChangesAsync();

                return cat;
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Se encontró un error");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Eliminar(decimal id)
        {
            Usuario cat = await _context.Usuarios.FirstOrDefaultAsync(x => x.Idusuario == id);

            if (cat == null)
                return NotFound();

            try
            {
                _context.Usuarios.Remove(cat);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Se encontró un error");
            }
        }
    }
}
