namespace TriangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {

            //Set the values for x1, x2 of all the coordinates points
            Console.WriteLine("Enter the coordinates of the first point:");
            double x1 = int.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the third point:");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            //Calculate the value of a, b and c from the Pythagorean theorem

            double a = Math.Sqrt(Math.Pow(x2 + x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            //Return the length of the sides triangle
            
            Console.WriteLine($"The length of the sides of the triangle are: {a}, {b}, {c}");

            bool isEquilateral = false;

            if (a == b)
            {
                if (b == c)
                {
                    isEquilateral = true;
                }
            }

            //Test if the triangle is Equilateral
            
            Console.WriteLine($"Is it an equilateral triangle? {(isEquilateral ? "Yes" : "Not")}");

            bool isIsosceles = false;


            if (a == b) { isIsosceles = true; }
            if (b == c) { isIsosceles = true; }
            if (c == a) { isIsosceles = true; }

            //Test if the triangle is Isosceles
            
            Console.WriteLine($"Is it an isosceles triangle? {(isIsosceles ? "Yes" : "No")}");

            
            //Print the perimeter value
            double perimeter = a + b + c;
            Console.WriteLine($"The perimeter of the triangle is: {perimeter}");

            //Count the pair number
            Console.WriteLine("Even numbers from 0 to the perimeter:");
            for (int i = 0; i <= perimeter; i = i + 2)
            {
                Console.Write(i + " ");
            }

            bool isRight_ = false;

            if (a * a + b * b == c * c) { isRight_ = true; }
            if (b * b + c * c == a * a) { isRight_ = true; }
            if (c * c + a * a == b * b) { isRight_ = true; }

            Console.WriteLine($"Is it a right triangle? {isRight_}");

            Console.WriteLine("\nEnter tolerance value ");
            double tolerance = double.Parse(Console.ReadLine());


            bool isRight = false;

            double op1 = Math.Abs(c * c - (a * a + b * b));
            double op2 = Math.Abs(a * a - (b * b + c * c));
            double op3 = Math.Abs(b * b - (c * c + a * a));

            if (op1 <= tolerance) { isRight = true; }
            if (op2 <= tolerance) { isRight = true; }
            if (op3 <= tolerance) { isRight = true; }

            Console.WriteLine($"Is it a right triangle? {isRight}");
            Console.ReadKey();
        }
    }
}

