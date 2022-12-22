Console.WriteLine("This program solves Ackermann's function.");
Console.WriteLine();
int numberM = EnterUserData("Enter the start number M:");
int numberN = EnterUserData("Enter the end number N:");
if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Please enter positive numbers m and n.");
    return;
}
int result = AckermannFunction(numberM, numberN);
Console.WriteLine(result);

int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberM > 0 && numberN == 0)
    {
        return AckermannFunction(numberM - 1, 1);
    }
    else if (numberM > 0 && numberN > 0)
    {
        return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    }
    return AckermannFunction(numberM, numberN);
}

int EnterUserData(string nameUserData)
{
    Console.Write($"{nameUserData}");
    return Convert.ToInt32(Console.ReadLine());
}