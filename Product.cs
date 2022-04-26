using System;
namespace HomeWork3
{
    public class Product
    {
        public Product(double width, double height, double length, double weight)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        public double Length { get; }
        public double Height { get; }
        public double Width { get; }
        public double Weight { get; }
        public string Name { get; set; }

        public string PrintProductDescription()
        {
            return $"The product {Name} has dimensions of: {Width}x{Length}x{Height}mm and a weight of {Weight}g.";
        }
    }
}

