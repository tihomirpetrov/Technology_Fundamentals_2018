namespace BandRegister.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Band
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Members { get; set; }

        public double Honorarium { get; set; }

        public string Genre { get; set; }

    }
}
