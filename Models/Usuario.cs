namespace ApiPrueba.Models{
    public class Usuario
    { 
        [key]
        public int id {get;set;}
        public string nombre{get;set;}
        public string apellido {get;set;}
        public string email{get;set;}
        public string password{get;set;}
    }
}