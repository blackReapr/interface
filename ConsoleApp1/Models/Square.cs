namespace ConsoleApp1.Models
{
    internal class Square : Figure
    {
        public Square(int side)
        {
            Side = side;
        }
        private int _side;
        public int Side
        {
            get => _side;
            set
            {
                if (value < 0) return;
                _side = value;
            }
        }

        public override int CalcArea()
        {
            return _side * _side;
        }
    }
}
