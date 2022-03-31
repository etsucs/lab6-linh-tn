/**       
 *--------------------------------------------------------------------
 * 	   File name: Homework6
 * 	Project name: Lab6
 *--------------------------------------------------------------------
 * Author’s name and email:	 Tue Dang Linh	Linhtn@etsu.edu		
 *          Course-Section: 002
 *           Creation Date:	 March 24, 2022		
 * -------------------------------------------------------------------
 */

ShowCharacter("House" , 3);


static void ShowCharacter(String word, int position)
{
    int humanPosition = position - 1;
    System.Console.WriteLine(word.ToUpper()[humanPosition]);
}

System.Console.Write("Enter the intem's wholesale cost: ");
var cost = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter in the markup percentage: ");
var percentage = Convert.ToDouble(Console.ReadLine());

CalculateRetail(cost ,percentage);

static void CalculateRetail(double cost, double markup)
{
    var percentage = markup / 100 + 1;
    var retailPrice = cost * percentage;
    System.Console.WriteLine($"The retail price is {Math.Round(retailPrice), 2}.");
}

for (int i = 80; i <= 100; i++)
{
    System.Console.WriteLine(Celsius(i));
}


static double Celsius(double fTemp)
{
    var cTemp = (5.0/9.0) * (fTemp-32);
    return cTemp;
}

System.Console.Write("Enter a number: ");
int numberEntered = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsPrime(numberEntered));


static bool IsPrime(int number)
{
    if(number <= 1) return false;
    if(number == 2) return true;
    if(number % 2 == 0) return false;

    for(int i = 3; i<number; i+=2)
    {
        if(number % i ==0) return false;
    }
    return true;
}