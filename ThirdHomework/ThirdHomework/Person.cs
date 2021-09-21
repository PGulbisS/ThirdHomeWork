using System;


namespace ThirdHomework
{
    public class Person
    {


        public string Name { get; set; }
        public string Surname { get; set; }

        private int _birthdate;
        public int BirthDate
        {
            get
            {
                return _birthdate;
            }
            set
            {
                _birthdate = (value);
            }
        }

        private string _hobby;
        public string Hobby
        {
            get
            {
                return _hobby;
            }
            set
            {
                _hobby = (value);
            }
        }
        public bool IsMale { get; set; }

        public string GetGreeting()
        {
            string greeting = "Hello my name is" + " " + Name + " " + Surname + " " + "and I was born in" + " " + BirthDate;
            return greeting;

        }
    }
}
