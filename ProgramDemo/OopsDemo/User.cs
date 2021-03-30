using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class User
    {
        private String name;
        private String location;



        private String desig;
        private int age;



        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }



        public String Desig { get { return desig.ToUpper(); } set { desig = value; } }
        public int Age { get { return age; } set { if (value > 20) age = value; } }
        public static void Main()
        {
            User u = new User();
            u.Name = "Swapna";
            u.Location = "Hyd";
            u.Desig = "Developer";
            u.Age =23;
            Console.WriteLine(u.Name + " -> " + u.Location + " -> " + u.Desig + " -> " + u.Age);

            Console.ReadKey();

        }
    }
}
