using System;

namespace Cat
{
    class Program
    {
        class Cat
        {
            string name;
            double hunger;
            string color;

            public Cat(string _color, string _name)
            {
                color = _color;
                name = _name;
                hunger = 0;
            }
            public string Name
            {
                get { return name; }
            }
            public double Hunger
            {
                get { return hunger; }
            }

            public string Color
            {
                get { return Color; }
            }

            public void sleep()
            {
                Console.WriteLine("Cat sleeping!");
                Console.WriteLine("Hunger:" + hunger);
                hunger += 0.2;
            }

            public void Meow()
            {
                Console.WriteLine("meow!!");
                
            }

        }

        
        
        static void Main(string[] args)
        {
            Cat newCat = new Cat("Kitty", "Orange");
            Console.WriteLine(newCat.Hunger);
            while (newCat.Hunger!= 1)
            {
                newCat.sleep();
            }
        }
    }
}
