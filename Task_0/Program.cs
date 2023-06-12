//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number=> ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number=> ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
int maxNumber = numberFirst;
if(maxNumber > numberSecond){
    Console.WriteLine($"Maximum number {maxNumber} minimum number {numberSecond}");
}
else{
    maxNumber = numberSecond;
Console.WriteLine($"Maximum number {maxNumber} minimum number {numberFirst}");
}