namespace SistemaGestionEscolar.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public string Numero { get; set; }     
        public int Capacidad { get; set; }     
        public string Edificio { get; set; } 
        public string Piso { get; set; } 
    }
}