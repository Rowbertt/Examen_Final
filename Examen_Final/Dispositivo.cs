namespace Examen_Final
{
    public class Dispositivo
    {
        public string NumeroSerie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }


        public Dispositivo() 
        {
            NumeroSerie = string.Empty;
            Marca = string.Empty;   
            Modelo = string.Empty;

        }
    }
}
