using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Panos";
            Console.WriteLine(message);

            int MyFirstValue = 43;
            double MySecondValue = 22.54;
            var  sum = MyFirstValue + MySecondValue;

            Console.WriteLine(sum);

            var sumstringNumber = message +"  "+ MyFirstValue +"  "+ MySecondValue;//τα αντιμετωπίζει όλα ως string
            Console.WriteLine(sumstringNumber);

            bool myFirstBoolean = 3 + 2 == 5;
            Console.WriteLine(myFirstBoolean);

            bool mySecondBoolean = 3 + 7 > 10;
            Console.WriteLine(mySecondBoolean);

            bool bothAreTrue = myFirstBoolean && mySecondBoolean;
            Console.WriteLine($"bothAreTrue evaluates {bothAreTrue}");

            bool oneIsTrue = myFirstBoolean || mySecondBoolean;
            Console.WriteLine($"one is True evaluates {oneIsTrue}");

            bool reverseMyFirstBoolean = !myFirstBoolean;
            Console.WriteLine($" MyFirstBoolean evaluates {myFirstBoolean} but reverseΜyFirstBoolean evaluates {reverseMyFirstBoolean}");

            int myAge = 21;
            double myHourlySalary = 16.00;
            var myName = "Panos";

            //Print My data
            Console.WriteLine($"myAge : {myAge}, myHourlySalary: {myHourlySalary}, myName: {myName}");
            myAge = myAge + 1;
            myHourlySalary = myHourlySalary - 10;
            Console.WriteLine($"myAge : {myAge}, myHourlySalary: {myHourlySalary}, myName: {myName}");



        }
    }
}
