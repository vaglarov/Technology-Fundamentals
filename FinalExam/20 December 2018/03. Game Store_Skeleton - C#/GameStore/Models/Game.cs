using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Game
    {
        //        //T•	id – technology-dependent identifier (ObjectID for JavaScript, int for all other technologies)
        //•	name – non-empty text
        //•	dlc – non-empty text
        //•	price – non-null floating-point number
        //•	platform – non empty text

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Dlc { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}
