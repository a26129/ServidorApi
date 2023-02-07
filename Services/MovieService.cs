using ApiPrueba.Models;

namespace ApiPrueba.Services{
    public static class MovieService{
    static List<Pelicula> Peliculas {get;}
    static int id = 4;
    static MovieService(){
        Peliculas = new List<Pelicula>
        {
            new Pelicula {id = 1,nombre = "NombrePelicula1",director = "director1",fechaPublicacion=DateTime.Today},
            new Pelicula {id = 2,nombre = "NombrePelicula2",director = "director2",fechaPublicacion=DateTime.Today},
            new Pelicula {id = 3,nombre = "NombrePelicula3",director = "director3",fechaPublicacion=DateTime.Today}
        };
    }

    public static List<Pelicula> GetAll() => Peliculas;

    public static Pelicula Get(int id)=>Peliculas.FirstOrDefault(pelicula => pelicula.id == id);
    public static void Add(Pelicula pelicula){
        Peliculas.Add(pelicula);
        id++;;
    }
    public static void Delete(int id){
        var peliculaDelete = Get(id);
        if(peliculaDelete!=null)
        {
            Peliculas.Remove(peliculaDelete);
        }
    }
    public static void Update(Pelicula pelicula){
       var index = Peliculas.FindIndex(peliculaAux => peliculaAux.id == pelicula.id);
       if(index != -1){
            Peliculas[index] = pelicula;
       }
    }
    }
}

