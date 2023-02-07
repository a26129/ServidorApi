using ASFASD.Models;
using ASFASD.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASFASD.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        public MovieController()
        {
        }

        // GET all action
        [HttpGet]
        public ActionResult<List<Pelicula>> GetAll() => MovieService.GetAll();

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<Pelicula> Get(int id)
        {
            var pelicula = MovieService.Get(id);
            if (pelicula == null)
            {
                return NotFound();
            }
            return pelicula;
        }
        // POST action
        [HttpPost]
        public IActionResult Create(Pelicula pelicula)
        {
            MovieService.Add(pelicula);
            return CreatedAtAction(nameof(Get), new { id = pelicula.id }, pelicula);
        }
        // PUT action
        [HttpPut("{id}")]
        public IActionResult Update(int id, Pelicula pelicula)
        {
            if (id != pelicula.id)
                return BadRequest();

            var existingPelicula = MovieService.Get(id);
            if (existingPelicula is null)
            {
                return NotFound();
            }
            MovieService.Update(pelicula);
            return NoContent();
        }
        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pelicula = MovieService.Get(id);
            if (pelicula is null)
            {
                return NotFound();
            }
            MovieService.Delete(id);
            return NoContent();
        }
    }
}