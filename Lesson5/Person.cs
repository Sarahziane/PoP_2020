using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
  public  class Person
    {
        private string name;
        private int age;
        private string email;

        public string Name
        {
            get { return this.name; }
            set {


                this.name = value; }
        }
        public string Email
        {
            get { return this.email; }
            set {
                if(value !=null && !value.Contains("@"))
                {
                    throw new ArgumentOutOfRangeException("Invalid email")
                }
                this.email = value; }
        }
        public int Age
        {
            get { return this.age; }
            set {

                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 100");
                }
                this.age = value; }
        }

        public Person()
        {
            this.email = email;
            this.age = age;
            this.name = name;

        }

        public override string ToString()
        {
            return $"\nPerson 1 :\n\nName : {Name}\nAge : {Age}\nEmail : {Email} ";

        }

    }
}
