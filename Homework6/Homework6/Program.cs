

using System.Numerics;
/**       
*--------------------------------------------------------------------
* 	   File name: Homework6.cs
* 	Project name: Homework6
*--------------------------------------------------------------------
* Author’s name and email:	 Josh Poteet, poteetjd@etsu.edu				
*          Course-Section: CSCI-1250_077
*           Creation Date:	 10/24/22	
* -------------------------------------------------------------------
*/
class Homework6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ShowCharacter, with the input New York, 2:");
        ShowCharacter("New York", 2);
        Console.WriteLine("CalculateRetail, with the input 5, 100:");
        Console.WriteLine(CalculateRetail(5, 100) + "\n");
        Console.WriteLine("Farenheit 80 - 100 converted to celcius:");
        for(int i = 80; i < 100; i++)
        {
            Console.WriteLine(Celcius(i));
        }
        Console.WriteLine("IsPrime, with the 1000th prime number, 7919, as input:");
        Console.WriteLine(IsPrime(7919));
    }

    public static void ShowCharacter(string str, int num)
    {
        Console.WriteLine(str.Substring((num-1), num-1));
    }

    public static double CalculateRetail(double cost, double markup)
    {
        markup = Math.Round((markup / 100), 2);
        cost = Math.Round(cost, 2);
        cost = Math.Round((cost + (cost * markup)), 2);

        return cost;
    }

    public static double Celcius(int temp)
    {
        double temptemp =  (temp - 32) * 5 / 9 ;

        return temptemp;
    }

    public static bool IsPrime(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
