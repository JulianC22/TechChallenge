namespace TechChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            //Set the values for x1, x2 and x3 of all the coordinates points
            Console.WriteLine("Enter the coordinates of the first point:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the third point:");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            //Calculate the sides value (a), (b) and (c) from the Pythagorean theorem with square roots

            double a = Math.Sqrt(Math.Pow(x2 + x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            //Return the length of the triangle's sides 

            Console.WriteLine($"The length of the sides of the triangle are: {a}, {b}, {c}");

            //Boolean that evaluate if the triangle is equilateral or not

            bool isEquilateral = false;

            if (a == b)
            {
                if (b == c)
                {
                    isEquilateral = true;
                }
            }

            Console.WriteLine($"Is it an equilateral triangle? {(isEquilateral ? "Yes" : "Not")}");


            //Test if the triangle is Isosceles
            bool isIsosceles = false;


            if (a == b) { isIsosceles = true; }
            if (b == c) { isIsosceles = true; }
            if (c == a) { isIsosceles = true; }
            
            Console.WriteLine($"Is it an isosceles triangle? {(isIsosceles ? "Yes" : "No")}");

            //Print the perimeter value
            double perimeter = a + b + c;
            Console.WriteLine($"The perimeter of the triangle is: {perimeter}");

            //Counting even numbers from zero to the perimeter value
            Console.WriteLine("Even numbers from 0 to the perimeter:");
            for (int i = 0; i <= perimeter; i = i + 2)
            {
                Console.WriteLine(i + " ");
            }

            //Evaluation of the right triangle with booleans before the tolerance value
            bool isRight = false;

            if (a * a + b * b == c * c) { isRight = true; }
            if (b * b + c * c == a * a) { isRight = true; }
            if (c * c + a * a == b * b) { isRight = true; }

            Console.WriteLine($"Is it a right triangle? {isRight}");

            //Assignment tolerance value by the user
            Console.WriteLine("\nEnter tolerance value ");
            double tolerance = double.Parse(Console.ReadLine());

            //Second evaluation if it is a right triangle after the assignement of tolerance value
            bool isRight2 = false;

            double op1 = Math.Abs(c * c - (a * a + b * b));
            double op2 = Math.Abs(a * a - (b * b + c * c));
            double op3 = Math.Abs(b * b - (c * c + a * a));

            if (op1 <= tolerance) { isRight2 = true; }
            if (op2 <= tolerance) { isRight2 = true; }
            if (op3 <= tolerance) { isRight2 = true; }

            Console.WriteLine($"Is it a right triangle? {isRight2}");
            Console.ReadKey();
        }
    }
}

