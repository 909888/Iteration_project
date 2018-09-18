using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_project
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////// example 1 

            //string[] userInput = { "Hello, ", "Hi, ", "Hola, " };

            //Console.WriteLine("What is your name?");
            //string userName = (Console.ReadLine());


            //for (int i =0; i < userInput.Length; i++)
            //{
            //    Console.WriteLine(userInput[i] + userName);
            //}
            //Console.ReadLine();




            /////////////////// example 2 

            //int number = 0;

            //while (number < 10)
            //{
            //    Console.WriteLine("The number is " + number);
            //}




            /////////////////// example 3 

            //int number = 0;

            //while (number < 10)
            //{
            //    Console.WriteLine("The number is " + number);
            //    number++;
            //}
            //Console.ReadLine();




            /////////////////// example 4  


            //int[] testScores = { 100, 95, 90, 85, 80, 75, 70, 65, 60, 55, 50 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] < 70)
            //    {
            //        Console.WriteLine("Failed test scores: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();




            /////////////////// example 5  

            //int[] testScores = { 100, 95, 90, 85, 80, 75, 70, 65, 60, 55, 50 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] <= 70)
            //    {
            //        Console.WriteLine("Barely passed and failed test scores: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();



            /////////////////// example 6  


            //List<string> greetIngs = new List<string>();

            //greetIngs.Add("Hello"); //0
            //greetIngs.Add("Hola");  //1
            //greetIngs.Add("Guten tag"); //2
            //greetIngs.Add("Hi"); //3
            //greetIngs.Add("Yo"); //4

            //Console.WriteLine("What are some ways to greet someone?");
            //string userInput = Console.ReadLine();


            //if (userInput == greetIngs[0])
            //{
            //    Console.WriteLine("Yes, thats one way to say greet people!");
            //}
            //else if (userInput == greetIngs[1])
            //{
            //    Console.WriteLine("Nice, your Spanish teacher would be proud!");
            //}
            //else if (userInput == greetIngs[2])
            //{
            //    Console.WriteLine("You speak german? Thats cool!");
            //}
            //else if (userInput == greetIngs[3])
            //{
            //    Console.WriteLine("Sure, a really simple greet");
            //}
            //else if (userInput == greetIngs[4])
            //{
            //    Console.WriteLine("Yo! a very popular acknowledgment amongs young folk!");
            //}
            //Console.ReadLine();



            /////////////////// example 7  


            //List<string> greetIngs = new List<string>();

            //greetIngs.Add("Hello"); //0
            //greetIngs.Add("Hola");  //1
            //greetIngs.Add("Guten tag"); //2
            //greetIngs.Add("Hi"); //3
            //greetIngs.Add("Yo"); //4

            //Console.WriteLine("What are some ways to greet someone?");
            //string userInput = Console.ReadLine();


            //if (userInput == greetIngs[0])
            //{
            //    Console.WriteLine("Yes, thats one way to say hello!");
            //}
            //else if (userInput == greetIngs[1])
            //{
            //    Console.WriteLine("Nice, your Spanish teacher would be proud!");
            //}
            //else if (userInput == greetIngs[2])
            //{
            //    Console.WriteLine("You speak german? Thats cool!");
            //}
            //else if (userInput == greetIngs[3])
            //{
            //    Console.WriteLine("Sure, a really simple greet");
            //}
            //else if (userInput == greetIngs[4])
            //{
            //    Console.WriteLine("Yo! a very popular acknowledgment amongs young folk!");
            //}
            //else
            //{
            //    Console.WriteLine("No! thats not a way to greet someone! By my terms!");
            //}
            //Console.ReadLine();



            /////////////////// example 8  


            //List<string> greetIngs = new List<string>();

            //greetIngs.Add("Hello"); //0
            //greetIngs.Add("Hola");  //1
            //greetIngs.Add("Guten tag"); //2
            //greetIngs.Add("Hi"); //3
            //greetIngs.Add("Yo"); //4

            //Console.WriteLine("What are some ways to greet someone?");
            //string userInput = Console.ReadLine();
            //string i = greetIngs[0];



            //do
            //{
            //    if (userInput == greetIngs[0])
            //    {
            //        Console.WriteLine("Yes, thats one way to say hello!");
            //        Console.WriteLine("You guessed it the first time! goodbye");
            //        break;

            //    }
            //    else if (userInput == greetIngs[1])
            //    {
            //        Console.WriteLine("Nice, your Spanish teacher would be proud!");
            //    }
            //    else if (userInput == greetIngs[2])
            //    {
            //        Console.WriteLine("You speak german? Thats cool!");
            //    }
            //    else if (userInput == greetIngs[3])
            //    {
            //        Console.WriteLine("Yo! a very popular acknowledgment amongs young folk!");
            //    }
            //    else if (userInput == greetIngs[4])
            //    {
            //        Console.WriteLine("Sure, a really simple greet");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No! thats not a way to greet someone! By my terms anyways!");
            //    }


            //} while (userInput == i);

            //Console.ReadLine();



            /////////////////// example 9  and 10


            //List<string> greetIngs = new List<string>();

            //greetIngs.Add("Hello"); //0
            //greetIngs.Add("Hola");  //1
            //greetIngs.Add("Yo"); //2
            //greetIngs.Add("Hi"); //3
            //greetIngs.Add("Yo"); //4

            //Console.WriteLine("What are some ways to greet someone?");
            //string userInput = Console.ReadLine();
            //string i = greetIngs[0];
            //int multYos = greetIngs.IndexOf("Yo");



            //if (userInput == greetIngs[0])
            //{
            //    Console.WriteLine("Yes, thats one way to say hello!");
            //}
            //else if (userInput == greetIngs[1])
            //{
            //    Console.WriteLine("Nice, your Spanish teacher would be proud!");
            //}
            //else if (userInput == greetIngs[2])
            //{
            //    Console.WriteLine("Yo! a very popular acknowledgment amongs young folk!");
            //    Console.WriteLine("Also, this appears {0} times in the list", multYos);
            //}
            //else if (userInput == greetIngs[3])
            //{
            //    Console.WriteLine("Sure, a really simple greet");
            //}
            ////else if (userInput == greetIngs[4])
            ////{
            ////    Console.WriteLine("Yo! a very popular acknowledgment amongs young folk!");
            ////}
            //else
            //{
            //    Console.WriteLine("No! thats not a way to greet someone! By my terms!");
            //}
            //Console.ReadLine();



            /////////////////// example 11 dont do this again!



            //List<string> namesPeople = new List<string>();

            //namesPeople.Add("Kyle"); //0
            //namesPeople.Add("Butters");  //1
            //namesPeople.Add("Kenny"); //2
            //namesPeople.Add("Eric"); //3
            //namesPeople.Add("Butters"); //4
            //namesPeople.Add("Stan"); //5

            //int multYos = namesPeople.IndexOf("Butters");

            //foreach (string name in namesPeople)
            //{
            //    if (name == "Kyle")
            //    {
            //        Console.WriteLine(namesPeople[0]);
            //        Console.WriteLine("It appears once");
            //    }
            //    else if (name == "Butters")
            //    {
            //        Console.WriteLine(namesPeople[1]);
            //        Console.WriteLine("It appears once");
            //    }
            //    else if (name == "Kenny")
            //    {
            //        Console.WriteLine(namesPeople[2]);
            //        Console.WriteLine("It appears once");
            //    }
            //    else if (name == "Eric")
            //    {
            //        Console.WriteLine(namesPeople[3]);
            //        Console.WriteLine("It appears once");
            //    }
            //    else if (name == "Butters" )
            //    {
            //        Console.WriteLine(namesPeople[4]);
            //        Console.WriteLine("This the {0} nd time the name as appeared", multYos);
            //    }
            //    else if (name == "Stan")
            //    {
            //        Console.WriteLine(namesPeople[5]);
            //        Console.WriteLine("It appears once");
            //    }
            //}
            //Console.ReadLine();



            /////////////////// example 11


            //List<string> namesPeople = new List<string>();
            //List<string> namesPeople2 = new List<string>();



            /*namesPeople.Add("Kyle");*/ //0
            /*namesPeople.Add("Clyde");*/  //1
            /*namesPeople.Add("Kenny");*/ //2
            /*namesPeople.Add("Eric");*/ //3
            /*namesPeople.Add("Butters"); //4
            /*namesPeople.Add("Butters");*/ //5
            /*namesPeople.Add("Stan");*/ //6

            //namesPeople2.Add("");
            //namesPeople2.Add("");
            //namesPeople2.Add("");
            //namesPeople2.Add("");
            //namesPeople2.Add("");
            //namesPeople2.Add("");


            //foreach (string name in namesPeople)
            //{

            //    if (namesPeople2.Contains(name))
            //    {   
            //        Console.WriteLine("{0} appears already ",name);
                    
            //    }
            //    else
            //    {
            //        namesPeople2.Add(name);
            //        Console.WriteLine(name);
            //    }




            //} Console.ReadLine();






        }
    }
}
