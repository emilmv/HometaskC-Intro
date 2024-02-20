// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region Task4

//int[] arr = { 111, 222, 1111, 2222, 11111, 22222, 111111 };

//int sumOfThreeDigits = 0;
//int sumOfFourDigits = 0;
//int sumOfFiveDigits = 0;
//int sumOfSixDigits = 0;
//int multOfThreeDigits = 1;
//int multOfFourDigits = 1;
//double result = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > 99 && arr[i] < 1000)
//    {
//        sumOfThreeDigits += arr[i];
//        multOfThreeDigits *= arr[i];
//    }
//    if (arr[i] > 999 && arr[i] < 10000)
//    {
//        sumOfFourDigits += arr[i];
//        multOfFourDigits *= arr[i];
//    }
//    if (arr[i] > 9999 && arr[i] < 100000)
//        sumOfFiveDigits += arr[i];

//    if (arr[i] > 99999 && arr[i] < 1000000)
//        sumOfSixDigits += arr[i];
//}
//result = sumOfThreeDigits + multOfFourDigits;
//result *= 10;
//result += 7;
//result += sumOfFiveDigits;
//result -= (multOfThreeDigits * 10 + 1);
//result += sumOfSixDigits;
//result -= (sumOfThreeDigits + sumOfFourDigits);
//result *= 0.18;
//result *= 0.03;
//result *= 0.01;
//result += sumOfFiveDigits;

//Console.WriteLine(result);

// result = 34660.542156

#endregion

#region Task4V2

//int[] arr = { 111, 222, 1111, 2222, 11111, 22222, 111111 };

//double result = 0;
//int sumOfThreedigits = 0;
//int sumOfFourDigits = 0;
//int sumOfFiveDigits = 0;
//int sumOfSixDigits = 0;
//int multOfThreeDigits = 1;
//int multOfFourDigits = 1;
//int count = 0;

//foreach (var i in arr)
//{
//    if (i / 10 < 100)
//    {
//        sumOfThreedigits += i;
//        multOfThreeDigits *= i;
//    }
//    if (i / 10 < 1000 && i / 10 > 99)
//    {
//        sumOfFourDigits += i;
//        multOfFourDigits *= i;
//    }
//    if (i / 10 < 10000 && i / 10 > 999)
//        sumOfFiveDigits += i;
//    if (i / 10 < 100000 && i / 10 > 9999)
//        sumOfSixDigits += i;
//}
//result = sumOfThreedigits + multOfFourDigits;
//result *= 10;
//result += 7;
//result += sumOfFiveDigits;
//result -= (multOfThreeDigits * 10 + 1);
//result += sumOfSixDigits;
//result -= (sumOfThreedigits + sumOfFourDigits);
//result *= 0.18;
//result *= 0.03;
//result *= 0.01;
//result += sumOfFiveDigits;

//Console.WriteLine(result);

#endregion

#region Task4v3

//int[] arr = { 111, 222, 1111, 2222, 11111, 22222, 111111 };

//int sumOfThree = 0;
//int sumOfFour = 0;
//int sumOfFive = 0;
//int sumOfSix = 0;
//int multOfThree = 1;
//int multOfFour = 1;
//double result = 0;


//foreach (int i in arr)
//{
//    int digitCount = 0;
//    int temp = i;
//    while (temp > 0)
//    {
//        digitCount++;
//        temp /= 10;
//    }
//    if (digitCount == 3)
//    {
//        sumOfThree += i;
//        multOfThree *= i;
//    }
//    if(digitCount == 4)
//    {
//        sumOfFour += i;
//        multOfFour *= i;
//    }
//    if(digitCount == 5)
//        sumOfFive += i;
//    if(digitCount == 6)
//        sumOfSix += i;
//}
//result = sumOfThree + multOfFour;
//result *= 10;
//result += 7;
//result += sumOfFive;
//result -= (multOfThree * 10 + 1);
//result += sumOfSix;
//result -= (sumOfThree + sumOfFour);
//result *= 0.18;
//result *= 0.03;
//result *= 0.01;
//result += sumOfFive;

//Console.WriteLine(result);

#endregion