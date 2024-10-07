namespace BlazorAppAntiquariato.Models
{
    public class Stand
    {
        public int idStand { get; set; }
        public string? nome { get; set; }
        public string? cognome { get; set; }
        public char zona { get; set; }
        public byte superficie { get; set; }
        public bool isCoperto { get; set; }
        public DateTime dataInizio { get; set; }
    }
}
