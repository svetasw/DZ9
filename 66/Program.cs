int numberM = EnterUserData("Enter the start number M:");
int numberN = EnterUserData("Enter the end number N:");
int temp = 0;
if (numberM > numberN)
{
    temp = numberM;
    numberM = numberN;
    numberN = temp;
}
Console.WriteLine();
Console.Write($"Sum of all numbers from {numberM} to {numberN} = {SumFunction(numberM, numberN)}");
Console.WriteLine();

int SumFunction(int startValue, int endValue)
{
    if (startValue == endValue)
    {
        return startValue;
    }
    return SumFunction(startValue, endValue - 1) + endValue;
}

int EnterUserData(string nameUserData)
{
    Console.Write($"{nameUserData}");
    return Convert.ToInt32(Console.ReadLine());
}