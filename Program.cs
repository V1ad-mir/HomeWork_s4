          // Задача 25:

// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


                  // ВАРИАНТ 1 

// Console.WriteLine("Введите число A");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int result=1;
// for (int i = 0; i < numberB; i++)
// {
//  result=result*numberA;
// }
// Console.WriteLine("A в натуральной степени B (через цикл): "+result);



                  // ВАРИАНТ 2

// Console.WriteLine("Введите через пробел числа A и B");
// int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();    
// Console.WriteLine("A в натуральной степени B (через Math.Pow): " +Math.Pow(array[0],array[1]));

// Console.ReadLine()-метод позволяет получить введенную строку.
// Split(' ')- метод разбивает строку на подстроки на основе указанных символов-разделителей.
// предложение select просто создает последовательность с тем же типом объектов, что и у объектов, которые содержатся в источнике данных
// Предложение select может использоваться для преобразования исходных данныхв последовательности новых типов
// Parse Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком.
// ToArray Операция ToArray создает массив из входной последовательности
// P.S по отднльности +/- понятно, а вот в связке не совсем. Если не сложно, можете дать пояснение по данной конструкции.Или посоветуйте где почитать.




//                          Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numberX=number;
// int sum = 0;
// while (number>0)
// {
//    sum=sum+number%10;
//    number=number/10;
// }
// Console.Write("Сумма цифр входящих в число: ");
// Console.ForegroundColor = ConsoleColor.Green;
// Console.Write(numberX);
// Console.ResetColor();
// Console.Write(" равна: ");
// Console.ForegroundColor = ConsoleColor.DarkYellow;
// Console.WriteLine(sum);
// Console.ResetColor();



//                            Задача 29:
//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



Console.WriteLine("Введите длинну массива ");
int Dlinna = Convert.ToInt32(Console.ReadLine());
int[] array= new int [Dlinna];
int j=0;
Console.WriteLine("Массив будет заданн в ручную(yes/no)");
string answer = Console.ReadLine();
switch (answer)
  {
    case "yes":
    {
     for (int i = 0; i < array.Length; i++)
    {
     Console.WriteLine("Введите "+(++j)+"й элемент массива");
     array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
     for (int i = 0; i < array.Length; i++)
     {
    Console.Write(array[i]+" ");
     }
    break;
    } 
  
    case "no": 
    {
    Console.WriteLine("Введите первое число входящее в интервал, для генерации случайных чисел ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите последнее число входящее в интервал, для генерации случайных чисел ");
    int number2 = Convert.ToInt32(Console.ReadLine())+1;
    for (int i = 0; i < array.Length; i++)
    {
    array[i]=new Random().Next(number1,number2);
    Console.Write(array[i]+" ");
    }
    break;
    }
    default:
    {
    Console.WriteLine("Вы сами не знаете чего хотите ;-)");
    break;  
    }
  }
