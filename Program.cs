/*
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//14212 -> нет 
//12821 -> да 
//23432 -> да 
Console.Write("Введите пятизначное число: "); 
    string number = Console.ReadLine(); 
        void CheckingNumber(string number)
        { 
            if (number[0] == number[4] || number[1] == number[3])
                 { 
                    Console.WriteLine($"Ваше число: {number} - палиндром."); 
                      } 
                        else Console.WriteLine($"Ваше число: {number} - НЕ палиндром."); 
                            } 
if (number!.Length == 5)
    { 
        CheckingNumber(number); 
            } 
else Console.WriteLine($"Введи правильное число"); 

*/



/*
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
//A (3,6,8); B (2,1,-7), -> 15.84 
//A (7,-5, 0); B (1,-1,9) -> 11.53 

Console.WriteLine("Вводим координаты X точки a"); 
    double xa = Convert.ToDouble (Console.ReadLine()!); 
Console.WriteLine("Вводим координаты Y точки a"); 
    double ya = Convert.ToDouble (Console.ReadLine()!); 
Console.WriteLine("Вводим координаты Z точки a"); 
    double za = Convert.ToDouble (Console.ReadLine()!); 
Console.WriteLine("Вводим координаты X точки b"); 
    double xb = Convert.ToDouble (Console.ReadLine()!); 
Console.WriteLine("Вводим координаты Y точки b"); 
    double yb = Convert.ToDouble (Console.ReadLine()!); 
Console.WriteLine("Вводим координаты Z точки b"); 
    double zb = Convert.ToDouble (Console.ReadLine()!); 
        double d = Math.Sqrt (Math.Pow (xb-xa,2) + Math.Pow (yb-ya,2) + Math.Pow (zb-za,2)); 
Console.WriteLine($"d={d:f2}"); 
*/


/*
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
//3 -> 1, 8, 27 
//5 -> 1, 8, 27, 64, 125 
Console.WriteLine("Введи число N:"); 
    int n=Convert.ToInt32 (Console.ReadLine()!); 
        for (int i=1; i<=n; i++)
        { 
            Console.Write(Math.Pow (i,3)); 
                    if (i<n) Console.Write(","); 
            } 
*/