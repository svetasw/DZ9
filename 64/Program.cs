int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());;
    return userNumber;
}

string StringRecursion(int number)
{
   if (number == 1) return number.ToString();
   
   return number + " " + StringRecursion(number - 1);
}

int userNumber = GetNumber("Enter number: ");
Console.WriteLine();
Console.Write(StringRecursion(number: userNumber));