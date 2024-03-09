namespace ConsoleApp1.Models
{
    internal class Rectangular : Figure
    {
        public Rectangular(int width, int length)
        {
            _width = width;
            _length = length;
        }

        private int _width;
        private int _length;
        public int Width { get => _width; 
            set 
            {
                if (value < 0) return;
                _width = value;
            } 
        }
        public int Length { get => _length;
            set 
            {
                if (value < 0) return;
                _length = value;
            } 
        }

        public override int CalcArea()
        {
            return _width * _length;
        }
    }
}
