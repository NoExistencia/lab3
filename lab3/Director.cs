namespace Semana3
{
    public class Director
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public string NombreCompleto { get; set; }
        public Pais Pais { get; set; }
  
    }
}