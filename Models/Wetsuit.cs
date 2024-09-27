using SurfsUp.Models.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurfsUp.Models
{
    public enum WetsuitSize
    {
        Small,  // 0
        Medium, // 1
        Large,  // 2
        XLarge  // 3
    }

    [Table("Wetsuits", Schema = "SurfsUp")]
    public class Wetsuit
    {
        public int WetsuitId { get; set; }
        [Required]
        //[Wetsuit_EnsureCorrectSizing]
        public WetsuitSize? Size { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string ImagePath { get; set; }
        [Required]
        public double Thickness { get; set; }

        public Wetsuit() 
        {
        
        }

        public Wetsuit(WetsuitSize size, double price, string name, string gender, string imagePath, double thickness) 
        {
            Size = size;
            Price = price;
            Name = name;
            Gender = gender;
            ImagePath = imagePath;
            Thickness = thickness;
        }

    }
}
