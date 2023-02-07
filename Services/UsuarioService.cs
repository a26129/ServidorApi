using ApiPrueba.Models ;

namespace ApiPrueba.Services{
    public static class UsuarioService{
    static List<Usuario> Usuarios {get;}
    static int id = 0;
    static UsuarioService(){
        Usuarios = new List<Usuario>
        {
            new Usuario{nombre="daniel",apellido="apellido",email="daniel@alonso.es",password="contraseña"}
        };
    }

    public static List<Usuario> GetAll() => Usuarios;
    public static Usuario Get(int id)=>Usuarios.FirstOrDefault(usuarioAux => usuarioAux.id == id);

    public static void Add(Usuario usuario){
        Usuarios.Add(usuario);
        id++;;
    }
    public static void Delete(int id){
        var usuarioBorrar = Get(id);
        if(usuarioBorrar!=null)
        {
            Usuarios.Remove(usuarioBorrar);
        }
    }
    public static void Update(Usuario usuario){
       var index = Usuarios.FindIndex(usuarioActualizar => usuarioActualizar.id == usuario.id);
       if(index != -1){
            Usuarios[index] = usuario;
       }
    }
}
}
