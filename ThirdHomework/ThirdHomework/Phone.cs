using System;


namespace ThirdHomework
{
    public class Phone
    {

        private string _type;
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = (value);

            }
        }
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

        public string Specification()
        {
            string specification = "Hi there, I am " + " " + Type + " " + "and these are my specifics" + " " + Lenght + " " + Width + " " + Height;
            return specification;
        }
    }
}
