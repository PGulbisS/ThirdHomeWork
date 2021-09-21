using System;


namespace ThirdHomework
{
    public class Product
    {
        private int _lenght;
        public int Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                _lenght = (value);

            }
        }
        private int _height;
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = (value);

            }
        }
        private int _width;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = (value);
            }
        }
        private double _weight;
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = (value);
            }
        }
    }
}
