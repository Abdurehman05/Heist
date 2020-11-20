using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            TeamMember hMember = new TeamMember();
            Console.WriteLine("Enter a team member's name");
            hMember.Name = Console.ReadLine();


            Console.WriteLine("Enter team member's skill level");
            int enteredSkillLevel = int.Parse(Console.ReadLine());

            if (enteredSkillLevel > 0)
            {
                hMember.SkillLevel = enteredSkillLevel;

            }
            else
            {
                Console.WriteLine("Enter Positive intiger number");

            }

            Console.WriteLine("Enter a team member's courage factor");
            double enteredCourageFactor = double.Parse(Console.ReadLine());

            if (enteredCourageFactor >= 0.0 && enteredCourageFactor <= 2.0)
            {
                hMember.CourageFactor = enteredCourageFactor;

            }
            else
            {
                Console.WriteLine("Enter numbers between 0.0 and 2.0");

            }

            Console.WriteLine($@"
                    Name: {hMember.Name}
             Skill Level: {hMember.SkillLevel}
          Courage Factor: {hMember.CourageFactor}

            ");
        }
    }
}

