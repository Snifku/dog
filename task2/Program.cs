using System;

namespace task2
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string color;
            string regNumber;
            int fuelTank;
            int odometer;

            public Car(string _mark, string _model, string _color, string _regNumber)
            {
                mark = _mark;
                model = _model;
                color = _color;

                if(_regNumber.Length != 6)
                {
                    regNumber = "undefined";
                }else
                {
                    regNumber = _regNumber;
                }

                fuelTank = 60;
                odometer = 0;
            }

            public string Model
            {
                get { return model; }
            }
            
            public string Mark
            {
                get { return mark; }
            }

            public string Color
            {
                get { return color; }
            }

            public string RegNumber
            {
                get { return regNumber; }
            }

            public int FuelTank
            {
                get { return fuelTank; }
            }

            public int Odometer
            {
                get { return odometer; }
            }

            public void Drive()
            {
                odometer += 100;
                fuelTank -= 12;
            }

            public void ShowCarDetails()
            {
                Console.WriteLine($"Model: {model};\n Mark: {mark};\n Color: {color};\n RegNumber: {regNumber};\n FuelTank: {fuelTank}\n Odometer: {odometer};");
            }
        }
        static void Main(string[] args)
        {
            Car newCar = new Car("Toyota", "Supra", "Orange", "666WTF");
            Console.WriteLine("2jz 4.0litres");

            while(newCar.FuelTank != 0)
            {
                newCar.Drive();
            }

            Console.WriteLine("The ride is over!!!");
            newCar.ShowCarDetails();
        }
    }
}
