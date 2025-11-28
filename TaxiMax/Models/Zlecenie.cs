namespace TaxiMax.Models
{
    public class Zlecenie 
    {
        public int Id { get; set; }
        public required string Imie { get; set; }
        public required string Nazwisko { get; set; }
        public required string AdresOdbioru { get; set; }
        public required string AdresDostarczenia { get; set; }
        public required DateTime DataZlecenia { get; set; }
        public required string NumerTelefonu { get; set; }
        public string? Uwagi { get; set; }
        public string? Status { get; set; } 
        public string? wykonawca { get; set; }
    }
}
