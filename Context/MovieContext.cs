using Microsoft.EntityFrameworkCore;
using ApiPrueba.Models;

namespace ApiPrueba.Context
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options):base (options)
        {
        }
        DbSet<Pelicula> Peliculas {get;set;} =null;
    }
}