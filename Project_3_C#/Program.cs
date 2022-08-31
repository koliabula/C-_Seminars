// See https://aka.ms/new-console-template for more information
//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	
Console.WriteLine("Введите число от 1 до 7 :_ ");

int number = Convert.ToInt32(Console.ReadLine());

if(number > 0 & number < 8){

    if (number == 1) {
    Console.WriteLine("Понедельник");
    }
    
    if (number == 2) {
    Console.WriteLine("вторник");
    }


    if (number == 3) {
    Console.WriteLine("среда");
    }


    if (number == 4) {
    Console.WriteLine("четверг");
    }


    if (number == 5) {
    Console.WriteLine("Пятница");
    }


    if (number == 6) {
    Console.WriteLine("Ура!!!! Суббота");   
    }   


    if (number == 7) {
    Console.WriteLine("Воскресение");
    }

}
else {Console.WriteLine("Ввели не то число))))");}

