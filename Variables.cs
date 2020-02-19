using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Monday
{
    class Variables
    {
        static void Main(string[] args)
        {
            //Adding // at the start of a line creates a single-line comment that will be ignored
            //by the compiler.

            //The Main() is where a C# console application stats to execute. It is referred to 
            //as the "entry-point" of the application.

            //In Visual Studio the solution is the collection / portfolio of projects.
            //The projects act as a roadmap explaining how various pieces of the solution relate to each other. 
            //The projects each contain classes to contain the code to be executed.

            //.Net supports 3 different types of applications:
            //1. Web Applications - These are applications run over a web browser
            //2. Windows Applications - These are application run on a Windows machine
            //3. Web Services - These are incomplete applications built to be consumed into other applications.

            //There are 3 steps to running an application:
            //1. Save (CTRL + S)
            //2. Build (CTRL + SHIFT + B)
            //3. Run (CTRL + F5)
            //CTRL + F5 does all three steps at once.

            Console.WriteLine("Hello, world!");

            /*
             * A variable is a container used to store information. This requires a datatype and a name
             * because C# is a type-safe language. The information stored within a variable can be changed, 
             * however the variable's datatype and name cannot be changed.
             * 
             * Declaration, Initialization, and Assignments:
             * 
             * Declaration means to create the variable. This requires a datatype and a name.
             * 
             * Initialization is giving the variable a value for the first time.
             * 
             * Assignment is giving the variable a value at any time (this includes for the first time).
             */

            int number; //Declaration

            number = 1; //Initialization

            number = 2; //Assignment or sometimes reassignment 

            //When displaying information you can use either the literal value or the variable,
            //which will display its value:

            Console.WriteLine(number);

            string firstName = "Camden"; //Declaration and Initialization

            Console.WriteLine(firstName);

            firstName = "Phil"; //Reassignment

            Console.WriteLine(firstName);

            Console.WriteLine(17 + 25);

            Console.WriteLine("17" + 25); //Concatenation is adding text to other things

            int sportingKCScore = 4;

            Console.WriteLine("Sporting KC scored " + sportingKCScore + " goals in their last match.");

            //MINI LAB! Write a sentence to the screen using both of the below variables
            //with concatenation:

            string kcFootballTeam = "Chiefs";
            int kcPoints = 31;

            Console.WriteLine(kcFootballTeam + " scored " + kcPoints + ".");

            //Constants are like variables but their value never changes. They must be assigned a value at declaration. 

            const int MEANING_OF_LIFE = 42;

            Console.WriteLine(MEANING_OF_LIFE);

        }//end Main()
    }//end class
}//end namespace
