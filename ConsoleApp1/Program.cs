using ConsoleApp1.Models;


bool running = true;
while (running)
{
    ShowMenu();
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter the side: ");
            int side = Convert.ToInt32(Console.ReadLine());
            Square square = new(side);
            Console.WriteLine(square.CalcArea());
            break;
        case 2:
            Console.WriteLine("Enter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Rectangular rectangular = new(width, length);
            Console.WriteLine(rectangular.CalcArea());
            break;
        case 0:
            running = false;
            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }
}

void ShowMenu()
{
    Console.WriteLine("1. Square");
    Console.WriteLine("2. Rectangular");
    Console.WriteLine("0. Quit");
}