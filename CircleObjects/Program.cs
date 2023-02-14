// Circle Objects
// Jeff Santucci
// 02/09/2023

using CircleObjects;

bool isValidDecimal;
bool tryAgain;
double circum;
int counter = 0;


do
{
    Console.WriteLine("Please enter the radius for the circle dimensions you wish to see: ");
    isValidDecimal = double.TryParse(Console.ReadLine(), out double radius);

    if (!isValidDecimal)
    {
        Console.WriteLine("You have entered and invalid decimal number");
        tryAgain = true;
    }
    else
    {
        Circle circle = new Circle(radius);  // Instatiating the class
        Console.WriteLine($"Circumference is: {circle.CalculateCircumference()}");
        Console.WriteLine($"Area is: {circle.CalculateArea()}");
        counter = counter + 1;
    }
    Console.WriteLine("Continue? (y/n)");
    string cont = Console.ReadLine();

    if (cont == "y")
    {
        tryAgain = true;
    }
    else
    {
        Console.WriteLine("Goodbye. You created " + counter + " Circle object(s).");
        tryAgain = false;
    }
} while (tryAgain);