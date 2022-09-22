namespace HospiEnCasa.App.Dominio
{
    public class Persona
    {
       //Declaracion de propiedades
        public int Id {get; set;}
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NumeroTelefonico { get; set; }
        public Genero Genero { set; get; }

    }
}