namespace Examen_Final
{
    public class Laptop : Dispositivo
    {
        public int MemoriaRAM { get; set; } 
        public int Almacenamiento { get; set; }

        public Laptop() 
        {
            MemoriaRAM = 0;
            Almacenamiento = 0;
        }
    }
}
