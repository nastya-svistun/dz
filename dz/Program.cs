// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.Write("введите число: ");
// string? number = Console.ReadLine();

// void CheckNum(string number){
//   if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"ваше число: {number} - не палиндром.");
// }




// if (number!.Length == 5){
//   CheckNum(number);
// }
// else Console.WriteLine($"введите правильное число");





// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// double DistKoord (double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double dist = Math.Sqrt((Math.Pow(x2 - x1,2)) + (Math.Pow(y2 - y1,2)) + (Math.Pow(z2 - z1,2)));
//     double result = dist;
//     return result;
// }



// Console.Write("введите первую координату (x1): ");
// double x1 = Convert.ToDouble(Console.ReadLine()); 

// Console.Write("введите вторую координату (y1): ");
// double y1 = Convert.ToDouble(Console.ReadLine()); 

// Console.Write("введите первую координату (x2): ");
// double x2 = Convert.ToDouble(Console.ReadLine()); 

// Console.Write("введите вторую координату (y2): ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("введите первую координату (z1): ");
// double z1 = Convert.ToDouble(Console.ReadLine()); 

// Console.Write("введите вторую координату (z1): ");
// double z2 = Convert.ToDouble(Console.ReadLine()); 

// Console.Write($"расстояние равно: {Math.Round(DistKoord(x1, y1, x2, y2, z1, z2),3)}  ");





// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



// Console.Write("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int n = 1;
// double res = 0;
// while (n <= num)
// {
//     res = (Math.Pow(n,3));
//     Console.Write($" {res}");
//     n++;
// }