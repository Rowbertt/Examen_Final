namespace Examen_Final
{
    public class Tablet : Dispositivo
    {
        public double TamanioPantalla { get; set; } 
        public bool SoporteStylus { get; set; }

        public Tablet() 
        {
            TamanioPantalla = 0;
            SoporteStylus = false;
        }
    }
}
