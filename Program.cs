using Sana03;

int N;
bool f;
do
{
    Console.Write("Enter the number of array elements: ");
    f = int.TryParse(Console.ReadLine(), out N);
    if (f == false)
        Console.WriteLine("Error! Enter a number!");
} while (!f);

int[] generatedArray = new MyArray(N).arr;
Console.WriteLine("\nGenerated array elements:");
foreach (int num in generatedArray)
{
    Console.Write($"{num} ");
}
Console.WriteLine();

MyArray myArray = new MyArray(N);

Console.WriteLine($"\nThe sum of the negative elements of the array: {myArray.SumNegative()}");
Console.WriteLine($"Minimum array element: {myArray.MinElement()}");
Console.WriteLine($"The index of the maximum element of the array: {myArray.MaxIndex()}");
Console.WriteLine($"The maximum array element by modulus: {myArray.MaxAbs()}");
Console.WriteLine($"The sum of indices of positive elements: {myArray.SumPositiveIndices()}");
Console.WriteLine($"The number of integers in the array: {myArray.CountIntegers()}");