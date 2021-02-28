using System;

namespace Class_Collection
{
    public class SuperObject
    {
        string _name;
        int _number;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }

        public SuperObject()
        {
        }
        public SuperObject(string name, int number)
        {
            _name = name;
            _number = number;
        }

        public void ShowObject()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Number: {Number}");
        }
    }
}
