using System;
using System.Media;

class Program
{
    class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            // Console.WriteLine("In the constructor");
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetDiameter()
        {
            return 2 * radius;
        }

        public double GetCircumference()
        {
            return Math.PI * 2 * radius;
        }

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public void Display()
        {
            Console.WriteLine($"Area is : {GetArea()}");
            Console.WriteLine($"Radius is : {GetRadius()}");
            Console.WriteLine($"Diameter is : {GetDiameter()}");
            Console.WriteLine($"Circumference is : {GetCircumference()}");
        }
    }

    // static int AddNumbers(int n1, int n2)
    // {
    //     // int total = n1 + n2;
    //     // int total2 = n1 * n2;
    //     // return total;
    // }
    static void Main(string[] args)
    {
        int x = 10;

        Circle myCircle = new Circle(x);
        Circle myCircle2 = new Circle(x + 10);

        myCircle.Display();
        myCircle.SetRadius(x + 10);
        myCircle.Display();


        // Console.WriteLine(myCircle.GetArea());
        // Console.WriteLine(myCircle2.GetArea());

        // Console.WriteLine(myCircle.GetCircumference());
        // Console.WriteLine(myCircle.GetDiameter());
        // Console.WriteLine(myCircle.GetRadius());


        // double x = 123.149;
        // int y = 254;

        // Console.WriteLine(x.ToString("0.00"));
        // Console.WriteLine(y.ToString("X"));


        // int total = AddNumbers(20, 30);
        // Console.WriteLine(total);

        // Console.WriteLine("Hello Sandbox World!");

        // the for loop will give i the value of 0 then it will check if i is less then 10 and if it is it will write the line after it writes the line it increments by 1 using the ++ and the loop starts over with the new i variable being increased by 1.
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // int age = -1;

        // while (age < 0 || age > 125)
        // {
        //     Console.Write("Please enter your age (0-125): ");
        //     age = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Your age is: {age}");
        // }

        // int age;
        // do
        // {
        //     Console.Write("Please enter your age (0-125): ");
        //     age = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Your age is: {age}");
        // } while (age < 0 || age > 125);

        // List<string> myColors = new List<string>();

        // myColors.Add("Blue");
        // myColors.Add("Green");
        // myColors.Add("Red");

        // foreach (string color in myColors)
        // {
        //     Console.WriteLine(color);
        // }
    }
}