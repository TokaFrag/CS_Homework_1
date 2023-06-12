//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number=> ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number=> ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number=> ");
int numberThird = Convert.ToInt32(Console.ReadLine());
int maxNumber = numberFirst;
if(maxNumber < numberSecond){
    maxNumber = numberSecond;
}
if(maxNumber < numberThird){
maxNumber = numberThird;
}
Console.WriteLine($"Maximum number {maxNumber}");
