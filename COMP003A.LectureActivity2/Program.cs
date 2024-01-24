/*
 * Author: Matthew Hudson
 * Course: COMP-003A
 * Purpose: Lecture activitry for variables, type system, Math, and Console properties
 * Refernce: The C# Player's Guide (4e) by RB Whitaker
 */

using System.ComponentModel.Design;
using System.Numerics;
using System.Security;

namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* working with variables*/
            // the following code shows all three primary varaiable-related activities:
            string username; // declaring a variable (1 of 3)
            Console.WriteLine("What is your name?"); // request for user input
            username = Console.ReadLine(); // assinging a value to variable (2 of 3)
            Console.WriteLine("Hi " + username); // retrieving its current value of (3 of 3)


            // another example of the three primary bariable related activities (declaring, asigningm and retrieving)
            string favoriteColor;
            Console.WriteLine("What is your favorite color?");
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is " + favoriteColor);


            /*working with variable integers */
            int score; // decalre a new variable with a data type int
            // score = "Gereneric User'; // will fail to compile because you are assigning a string value to an integet variable
            // score = "0" // will still fail to compile because the "0" is still assigned as a string - englosed in the double quotes
            score = 0; //works
            score = 4; //you can aslo reassign values top the variable as long as they are within scope and not constant
            score = 11;
            score = -1564;

            /* reading from a variable does not change it*/
            int a;
            int b;

            a = 5;
            b = 2;
            Console.WriteLine("The current value of a: " + a);
            Console.WriteLine("The current balue of b: " + b);

            b = a;
            a = -3;
            Console.WriteLine("The new value of a: " + a);

            /* variables are case-sensitive */
            // the baraibles belowe are different despite having similar names
            string exampleVariable;
            string exampleVAriable;
            string exampleVARiable;

            Console.WriteLine("**************************************************");
            /*
             * types of varaibles and values matter in C#/ they are not interchangeable.
             * there are eith types of inter types for storing integers of difereing sizes and ranges: int, short long , byte sbyte, uint, ushort, and ulong.
             * the char type stores single characters/
             * the tring type stores longer text.
             * there are three types for storing real numbers: float, double, and decimal.
             * the bool type stroes truth values (true and false) used in logic.
             * these types are the building blocks of much larger type system.
             * using var for a varaible's type tells the complier to infer its type from the surrounding code, so you do not have to type it out. (But it still has as specific type.)
             * the System.Convert class is useful class to convert from on type to another.
             */

            /* declaring and using variables with integer types*/
            byte aSingleByte = 34;
            Console.WriteLine("aSingleByte: " + aSingleByte);
            aSingleByte = 17;
            Console.WriteLine("aSingleByte: " + aSingleByte);

            short aNumber = 5039;
            Console.WriteLine("aNumber:" + aNumber);
            aNumber = -4354;
            Console.WriteLine("aNumber:" + aNumber);

            long aVeryBigNumber = 39504282569;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);
            aVeryBigNumber = 13;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);

            int anInterger = 2147483647;

            /* declaring, using, and concatenating character ans strings */
            char aLetter = 'A'; // character values are enclose in single quotes
            string message = "Hello World!"; // string values are enclose in double quotes

            Console.WriteLine("Concatenation using + : " + aLetter + "" + message); //used the plus (+) sign in between chracters/strings to concatenate
            Console.WriteLine($"Concatenation using string interpolation : {aLetter}{message} "); // use string interpoilation with dollar-sign ($) before the opening double-quote and enclosing vraibles with curly braces ({variableName})

            /*floating-point types */
            double number1 = 3.5623;
            float number2 = 3.5623f;
            decimal number3 = 3.5623m;
            Console.WriteLine($"Value of number1: {number1}");
            Console.WriteLine($"Value of number2: {number2}");
            Console.WriteLine($"Value of number3: {number3}");
            /*scientifgic notation */
            double avogadrosNumber = 6.022e23;
            Console.WriteLine($"Value of avogadrosNumber: {avogadrosNumber}");

            /* bool type*/
            bool itWorked = true;
            Console.WriteLine($"Value of itWorked: {itWorked}");
            itWorked = false;
            Console.WriteLine($"New value of itWorked: {itWorked}");

            /* convert */
            string inputAgeString;
            int inputAge;
            int currentYear = 2023;

            Console.WriteLine($"Enter age in {currentYear}: ");
            inputAgeString = Console.ReadLine();
            inputAge = Convert.ToInt32(inputAgeString);
            Console.WriteLine($"Your age is {inputAge}");

            Console.WriteLine("**************************************************");
            /*
             * math operations
             * additon: +
             * subtraction: -
             * multiplication: *
             * disvision: /
             * modulo: % (remainder)
             */
            int addition = 2 + 3;
            int subtraction = 5 - 2;
            int multiplacation = 22 * 2;
            int division = 21 / 7;
            int modulo = 77 % 5;
            Console.WriteLine($"Value of addition: {addition}");
            Console.WriteLine($"Value of subtraction: {subtraction}");
            Console.WriteLine($"Value of multiplacation: {multiplacation}");
            Console.WriteLine($"Value of division: {division}");
            Console.WriteLine($"Value of modulo: {modulo}");

            /*
             * arithmetic, compound expression and order of operations
             * Multiplication and division are done first, left to right
             * Adddition and subtraction are done last, the to right
             * Reference: https:// csharpplayersguide.com/articles.operators-table
             */

            int arithmetic1; // declaring the variable aritmetic1.
            arithmetic1 = 9 - 2; // assigning a value to arithmetic 1, using some math.
            Console.WriteLine($"Value of arithmetic1: {arithmetic1}");
            arithmetic1 = 3 + 3; // another assignment/
            Console.WriteLine($"New value of arithmetic1: {arithmetic1}");
            int arithmetic2 = 3 + 1; // declaring arithmetic2 and assigning a blue to arithmrtic 2 all at once.
            Console.WriteLine($"Value of arithmetic2: {arithmetic2}");
            arithmetic2 = 1 + 2; // assinging a second value to arithmetic2.
            Console.WriteLine($"New value of arithmetic2: {arithmetic2}");

            // use multiple sets of parentheses to group operations
            int result = ((2 + 1) * 8 - (3 - 2) * 2) / 4;
            Console.WriteLine($"Value of result: {result}");

            /* compound assingment operator */
            int compoundAssignmentOperator = 0;
            compoundAssignmentOperator += 5; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator +5; (a is 5 after this line runs.)
            compoundAssignmentOperator -= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator - 2; (a is 3 after this line runs.)
            compoundAssignmentOperator *= 4; // This is equivalent of compoundAssignmentOperator = compoundAssignmentOperator * 4; (a is 12 aftrer this line runs.)
            compoundAssignmentOperator /= 2; // This is equivalent of compoundAssignmentOperator = coumpoundAssignmentOperator / 2; (a is 6 after this line runs.)
            compoundAssignmentOperator %= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator % 2; (a is 0 after this line runs.)

            /* incement and decerement operators */
            int incrementDecrementOperators = 0;
            incrementDecrementOperators++; // The equivalent of incementDecerementOperators += 1; or incerementDecerementOperators = incrementDecrementOperators -1;

            Console.WriteLine("***************************************************");
            /* console 2.0 */
            Console.WriteLine("What is your name, human? "); // notive te space at the end.
            string userName = Console.ReadLine(); // reads the entire line
            // result: What is your name, human? jonathan

            Console.WriteLine("Press any key when you're ready to being.");
            Console.ReadKey(); // reads a keystroke

            Console.BackgroundColor = ConsoleColor.Yellow; // changes the console background to yellow
            Console.ForegroundColor = ConsoleColor.Black; // changes the console text to black
            Console.Title = "Hello World!"; // changes the console title

            Console.Beep(440, 1000); // computer beeps

        }
    }
}
