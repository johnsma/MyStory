using System;
using System.Diagnostics;

namespace myStory
{
    class Program
    {
        static void Main(string[] args)
        {

             ProcessStartInfo theEnd = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
             theEnd.Arguments = "http://alphanewsmn.com/fourth-july-two-americas/";

             ProcessStartInfo theFight = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
             theFight.Arguments = "https://www.theodysseyonline.com/beginners-guide-comic-books";

            Console.WriteLine("A battle is about to take place between good and evil and it involves four warriors.");
            
                        
            //superhuman
            Console.Write("Please enter the name for the super human:  ");
            String huname = Console.ReadLine();

            SuperHuman fighter = new SuperHuman(huname, 600);


            //superhero
            Console.WriteLine("Thank you for entering super human {0}. Maxine is the super hero.", huname);
            
                  
            //supervillain
            Console.WriteLine("Please enter the name for the super villain:   ");
            String villname = Console.ReadLine();
            

            SuperVillain fighter1 = new SuperVillain(villname, 800, 400, 10, 200);
            

            //antihero
            Console.WriteLine("You are terrific for entering super villain {0}. Please enter the name for the antihero: ", fighter1._name);
            string antiname = Console.ReadLine();

            AntiHero fighter2 = new AntiHero(antiname, 400, 10, 1500);


            Console.WriteLine("The battle begin in Wreak Valley with super hero Maxine and super human {0}, the good guys, against super villain {1} and antihero {2} as the evil guys.", huname, villname, antiname);
            Console.ReadKey();
            

            Console.WriteLine("The super villain {0} and antihero {1} started fighting with super human {2} and super hero Maxine.", villname, antiname, huname);

            
            Console.WriteLine("Bam, bang, bloop, clash, clunk, kapow, clonk, ouch, owww, plop, powie, rip, splats, swoosh, whack, wham, pop, and zap. Both sides are lossing strength. What will be the outcome? Who can tell? We will let the smoke settle to get an assessment.");

            Process.Start(theFight);

            Console.Write("Enter the total health from 1 to 10 for super villain {0} and antihero {1}: ", villname, antiname);
            string input = Console.ReadLine();


            // change string to integer
            int inputint = int.Parse(input);

            Console.WriteLine("Super villain {0} and antihero {1} are dead and super human {2} and super hero Maxine won the battle.", villname, antiname, huname );
            Console.ReadKey();

            Process.Start(theEnd);


        }

    }
}   

