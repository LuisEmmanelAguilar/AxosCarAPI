using System.ComponentModel.DataAnnotations;

namespace AxosCarAPI.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }
    }
}
