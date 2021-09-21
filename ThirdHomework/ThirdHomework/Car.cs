using System;


namespace ThirdHomework
{
    public class Car
    {

        public string Model { get; set; }
        private string _licensePlate;
        public string LicensePlate
        {
            get
            {
                return _licensePlate;
            }
            set
            {
                _licensePlate = (value);
            }
        }
        private int _topSpeed;
        public int TopSpeed
        {
            get
            {
                return _topSpeed;
            }
            set
            {
                _topSpeed = (value);
            }
        }

        public string GetDescription()
        {
            string Description = "Hi There, I am " + " " + Model + " " + "my license plate is " + " " + LicensePlate + " " + "and my top speed can reach " + " " + TopSpeed + " " + "KM per hour";
            return Description;
        }
    }
}
