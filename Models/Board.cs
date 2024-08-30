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

        public override string ToString() => $"Name: {Name}";

    }
}
