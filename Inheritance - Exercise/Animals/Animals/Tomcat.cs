using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string TOMCAT_GENDER = "Male";

        public override string Gender { get { return TOMCAT_GENDER; } }

        public Tomcat(string name, int age)
            : base(name, age, TOMCAT_GENDER)
        { }

        public override string ProduceSound()
            => "MEOW";
    }
}