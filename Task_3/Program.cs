// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number=> ");
int number = Convert.ToInt32(Console.ReadLine());
//int numberSecond = numberFirst *(-1);
if(number >0){
for (int i = 1; i <= number; i++ ){
    if(i%2 == 0){
        Console.Write($"{i} ");
    }
}
}else{
    for (int i = number; i <= 1; i++ ){
    if(i%2 == 0){
        Console.Write($"{i} ");
    }
}
}
