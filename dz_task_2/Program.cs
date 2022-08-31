Console.Write("Введите число 1 :_ ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 :_ ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2){
    Console.WriteLine($"Число {number1} Больше числа " +number2 );
}

if (number1 < number2){
    Console.WriteLine($"Число {number2} Больше числа " + number1 );
}

if (number1 == number2){
    Console.WriteLine($"Число {number1} равно числу " +  number1 );
}

