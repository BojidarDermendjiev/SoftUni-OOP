using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Invalid input!");
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid input!");
                age = value;
            }
        }
        public virtual string Gender
        {
            get { return gender; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Invalid input!");
                gender = value;
            }
        }
        public Animal()
        { }

        public virtual string ProduceSound()
        => null;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name}").AppendLine($"{Name} {Age} {Gender}").AppendLine(ProduceSound());
            return sb.ToString().Trim();
        }
    }
}