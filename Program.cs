using System;
using Ex2.Entities;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                int side = 0;
                while(side < 1 || side > 20){
                    Console.Write("Insert a number between 1 and 20 to define the side of a square to be showed: ");
                    side = int.Parse(Console.ReadLine());
                }

                Square square = new Square(side);

                square.printDraw();

                char op = '\0';
                while(op != 'y' && op != 'n'){
                    Console.Write("Do you wanna exit? (y/n): ");
                    op = char.Parse(Console.ReadLine());
                }
                if(op == 'y') break;

            }

        }
    }
}
