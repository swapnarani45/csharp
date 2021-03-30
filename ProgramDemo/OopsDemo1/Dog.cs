using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo1
{
    class Dog : Mammal
    {
        private String breed;
        public Dog(String breed, int age) : base(age)
        {
            this.breed = breed;
        }
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public void WagTail()
        {
            Console.WriteLine("Tail Wagging ...");
            Console.ReadKey();
        }
    }
}
