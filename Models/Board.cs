using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace SurfsUp.Models
{
    [Table("Boards",Schema="SurfsUp")]
    public class Board
    {
        public int BoardId { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Thickness { get; set; }
        public double Volume { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        [AllowNull]
        public string Equipment { get; set; }
        public string ImagePath { get; set; }
        public bool IsBooked { get; set; } //delete it
        
        public Board() { }
        public Board(string name, double length, double width, double thickness, double volume, string type, int price, string equipment, int id, string imagePath, bool isBooked)
        {
            Name = name;
            Length = length;
            Width = width;
            Thickness = thickness;
            Volume = volume;
            Type = type;
            Price = price;
            Equipment = equipment;
            BoardId = id;
            ImagePath = imagePath;
            IsBooked = isBooked;
        }

    }
}
