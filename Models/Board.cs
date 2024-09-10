namespace SurfsUp.Models
{
    public class Board
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Thickness { get; set; }

        public double Volume { get; set; }

        public string Type { get; set; }

        public int Price { get; set; }

        public string Equipment { get; set; }

        public int Id { get; }
        public string Image { get; }

        public Board(string name, double length, double width, double thickness, double volume, string type, int price, string equipment, int id, string image)
        {
            Name = name;
            Length = length;
            Width = width;
            Thickness = thickness;
            Volume = volume;
            Type = type;
            Price = price;
            Equipment = equipment;
            Id = id;
            Image = image;
        }

        public override string ToString() => $"Name: {Name}";

    }
}
