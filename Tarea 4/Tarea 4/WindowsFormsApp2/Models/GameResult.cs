using System;

namespace WindowsFormsApp2.Models
{
    [Serializable]
    public class GameResult
    {
        public int Id { get; set; }
        public int Primera { get; set; }
        public int Segunda { get; set; }
        public int Tercera { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
