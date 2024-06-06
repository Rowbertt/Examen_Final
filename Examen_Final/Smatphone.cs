namespace Examen_Final
{
    public class Smatphone : Dispositivo
    {
        public string SistemaOperativo { get; set; }
        public int NumeroCamaras { get; set; }


        public Smatphone() 
        {
            SistemaOperativo = "1";
            NumeroCamaras = 1;
        }
    }
}
