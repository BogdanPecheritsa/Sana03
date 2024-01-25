using Sana03;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int N;
bool f;
do
{
    Console.Write("Введіть кількість елементів масиву: ");
    f = int.TryParse(Console.ReadLine(), out N);
    if (f == false)
        Console.WriteLine("Помилка! Введіть число!");
} while (!f);

MyArray myArray = new MyArray(N);

Console.WriteLine($"\nСума від’ємних елементів масиву: {myArray.SumNegative()}");
Console.WriteLine($"Мінімальний елемент масиву: {myArray.MinElement()}");
Console.WriteLine($"Індекс максимального елемента масиву: {myArray.MaxIndex()}");
Console.WriteLine($"Максимальний за модулем елемент масиву: {myArray.MaxAbs()}");
Console.WriteLine($"Сума індексів додатних елементів: {myArray.SumPositiveIndices()}");
Console.WriteLine($"Кількість цілих чисел у масиві: {myArray.CountIntegers()}");