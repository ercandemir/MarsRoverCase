using HBCaseMarsRover.Business;
using HBCaseMarsRover.Model;
using System;

namespace HBCaseMarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter upper-right coordinates of the plateau: ");
            string plateauInfo = Console.ReadLine();

            Console.Write("Enter first robot's coordinate and direction: ");
            string firstRobotInfo = Console.ReadLine();

            Console.Write("Enter first robot's letter commands: ");
            string firstRobotCommands = Console.ReadLine();

            Console.Write("Enter second robot's coordinate and direction: ");
            string secondRobotInfo = Console.ReadLine();

            Console.Write("Enter second robot's letter commands: ");
            string secondRobotCommands = Console.ReadLine();

            Plateau plateau = new Plateau(plateauInfo);
            Robot roboPrime1 = new Robot(firstRobotInfo);
            Robot roboPrime2 = new Robot(secondRobotInfo);

            MarsRoverBusiness marsRover = new MarsRoverBusiness();
            marsRover.CalculateNewLocation(plateau, roboPrime1, firstRobotCommands);
            Console.WriteLine(roboPrime1.GetLocation());

            marsRover.CalculateNewLocation(plateau, roboPrime2, secondRobotCommands);
            Console.WriteLine(roboPrime2.GetLocation());

            Console.ReadKey();
        }
    }
}
