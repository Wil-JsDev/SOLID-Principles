namespace SOLID.OCP.Models
{
    public class Circle : IShapes
    {
        private float _height { get; set; }
        private float _width { get; set; }

        public Circle(float height, float width)
        {
            _height = height;
            _width = width;
        }

        public void Add()
        {
            Console.WriteLine("Hi");
        }
        public double CalculateArea()
        {
           return _width * _height;
        }
    }
}
