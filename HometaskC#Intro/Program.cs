// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region Task4

int[] arr = { 111, 222, 1111, 2222, 11111, 22222, 111111 };

int sumOfThreeDigits = 0;
int sumOfFourDigits = 0;
int sumOfFiveDigits = 0;
int sumOfSixDigits = 0;
int multOfThreeDigits = 1;
int multOfFourDigits = 1;
double result = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 99 && arr[i] < 1000)
    {
        sumOfThreeDigits += arr[i];
        multOfThreeDigits *= arr[i];
    }
    if (arr[i] > 999 && arr[i] < 10000)
    {
        sumOfFourDigits += arr[i];
        multOfFourDigits*= arr[i];
    }
    if (arr[i] > 9999 && arr[i] < 100000)
    {
        sumOfFiveDigits += arr[i];
    }
    if (arr[i] > 99999 && arr[i] < 1000000)
    {
        sumOfSixDigits += arr[i];
    }

}
result = sumOfThreeDigits + multOfFourDigits;
result *= 10;
result += 7;
result += sumOfFiveDigits;
result -= (multOfThreeDigits * 10 + 1);
result += sumOfSixDigits;
result -= (sumOfThreeDigits + sumOfFourDigits);
result *= 0.18;
result *= 0.03;
result *= 0.01;
result += sumOfFiveDigits;

Console.WriteLine(result);

#endregion