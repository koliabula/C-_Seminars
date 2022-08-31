/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.*/

//сделал только для положительных чисел

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int N = number;
int i = 2;

if (N >= i){
    Console.Write($"чётные числа от 1 до {N}: ");
    while (i < N - 1) {
        Console.Write(i + ", ");
        i += 2;
    }
    while (i <= N) {                 //второй цикл - что бы после последнего числа поставить точку)))
        Console.Write(i + ".");
        i += 2;
    }
}
else {
    Console.WriteLine("Таких чисел нет");
}