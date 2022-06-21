using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FourthProgram_WeatherAPI
{
    public class RainDetection
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public bool IsRaining { get; set; }
        public decimal Amount { get; set; }
        public string City { get; set; }
    }
}
