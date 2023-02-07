using System.ComponentModel.DataAnnotations;

namespace sqllitecodefirst.Entities
{

    //model  sinifi
    public class Athlete
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public int Age { get; set; }

        [Required]
        [MaxLength(100)]
        public string Sport { get; set; }
    }
}
