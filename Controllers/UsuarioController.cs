using ASFASD.Models;
using ASFASD.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASFASD.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class UsuarioController : ControllerBase
    {
        public UsuarioController()
        {
        }

        // GET all action
        [HttpGet]
        public ActionResult<List<Usuario>> GetAll() => UsuarioService.GetAll();
        //GET ID
        [HttpGet("{id}")]
        public ActionResult<Usuario> Get(int id)
        {
            var usuario = UsuarioService.Get(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return usuario;
        }
        //POST
        [HttpPost("{id}")]
        public IActionResult Create(Usuario usuario)
        {
            UsuarioService.Add(usuario);
            return CreatedAtAction(nameof(Get), new { id = usuario.id }, usuario);
        }
        //PUT
        [HttpPut("{id}")]
        public IActionResult Update(int id, Usuario usuario)
        {
            if (id != usuario.id)
                return BadRequest();

            var existingUser = UsuarioService.Get(id);
            if (existingUser is null)
            {
                return NotFound();
            }
            UsuarioService.Update(usuario);
            return NoContent();
        }
        //Delete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var usuario = UsuarioService.Get(id);
            if (usuario is null)
            {
                return NotFound();
            }
            UsuarioService.Delete(id);
            return NoContent();
        }
    }
}