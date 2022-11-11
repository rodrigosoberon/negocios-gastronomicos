using System;
namespace BE
{
    public class Bitacora
    {
        public Bitacora() { }
        public int IdBitacora { get; set; }
        public string Descripcion { get; set; }
        public string Criticidad { get; set; }
        public int Usuario { get; set; } = 0;
        public DateTime Fecha { get; set; }
        public int DVH { get; set; } = 1;
    }
}
