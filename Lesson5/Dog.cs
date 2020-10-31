using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
   public class Dog
    {
        private string name;
        private string breed;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public Dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;

        }

        public void Bark()
        {
            Console.WriteLine("\nWoof !");
        }

    }
}
