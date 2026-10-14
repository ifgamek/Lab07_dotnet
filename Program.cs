// // // // // // // // // //задание 1.1

// // // // // // // //     string[] days = { "пн", "вт", "ср", "чт", "пт", "сб", "вс" };

// // // // // // // //     for (int i = days.Length-1; i >= 0 ; i-- )
// // // // // // // //     {
// // // // // // // //         Console.WriteLine($"{i+1}: {days[i]}");
// // // // // // // //     }


// // // // // // // //задание 1.2
// // // // // // // using System.Data.Common;

// // // // // // // double[] doubles = { 1.2, 0.0, -2.0, 2.0, 13.0, 5.9, -1.9 };
// // // // // // // foreach (double i in doubles)
// // // // // // // {
// // // // // // //     Console.Write(i + " ");
// // // // // // // }

// // // // // // // задание 2

// // // // // // int[] prices = { 120, 45, 300, 80, 15, 210 };
// // // // // // int sum = 0;
// // // // // // int sr_price = 0;
// // // // // // int count = 0;
// // // // // // for (int i = 0; i < prices.Length; i++)
// // // // // // {
// // // // // //     sum += prices[i];
// // // // // //     if (prices[i] > 100)
// // // // // //     {
// // // // // //         count += 1;
// // // // // //     }
// // // // // // }
// // // // // // sr_price = sum / prices.Length;
// // // // // // Console.WriteLine($"сумма {sum} ,товаров дороже 100 {count} , средняя цена {sr_price}");

// // // // // // задние 3
// // // // // int[] prices = { 120, 45, 300, 80, 15, 210 };
// // // // // int a = prices[0];
// // // // // int id = prices.Max();
// // // // // for (int i = 0; i < prices.Length; i++)
// // // // // {
// // // // //     if (a > prices[i])
// // // // //     {
// // // // //         a = prices[i];
// // // // //     }
// // // // // }
// // // // // Console.WriteLine($"минимум {a}, самый дорогой товар под индексом {prices.IndexOf(id)}");



// // // // // задание 4
// // // // int[] balance = { 100, -50, 20, -5, 0, 75 };
// // // // for (int i = 0; i < balance.Length; i++)
// // // // {
// // // //     if (balance[i] < 0)
// // // //     {
// // // //         balance[i] = 0;
// // // //     }
// // // //     Console.Write(balance[i] + " ");
// // // // }

// // // //задание 5
// // // int[] list = new int[5];
// // // int count_2 = 0;
// // // for (int i = list.Length - 1; i >= 0; i--)
// // // {
// // //     Console.WriteLine("Введите число\n");
// // //     list[i] = int.Parse(Console.ReadLine());


// // //     if (list[i] % 2 == 0)
// // //     {
// // //         count_2 += 1;
// // //     }

// // // }
// // // Console.WriteLine("массив");
// // // foreach (int i in list)
// // // {
// // //     Console.Write(i + " ");
// // // }

// // // Console.WriteLine($"\n четных чисел {count_2}");

// // //задание 6

// // string[] names = { "Анна", "Игорь",
// // "Мария", "Олег", "Ольга" };

// // Console.WriteLine("введите имя с большой буквы!");
// // string name = Console.ReadLine();

// // for (int i = 0; i < names.Length; i++)
// // {
// //     if (names[i] == name)
// //     {
// //         Console.WriteLine($"Индекс имени {i}");
// //         return;
// //     }
// // }
// // Console.WriteLine("имя не найдено");


// //итоговая задача
// using System.Diagnostics.CodeAnalysis;
// using Microsoft.Win32.SafeHandles;

// int[] grades = { 2, 3, 4, 5, 2, 3, 4, 5 };
// int min = grades[0];
// int max = grades[0];
// int count_2 = 0;
// int count_5 = 0;
// int sum = 0;
// foreach (int i in grades)
// {
//     Console.Write(i + " ");
//     if (min > i)
//     {
//         min = i;
//     }
//     if (max < i)
//     {
//         max = i;
//     }
//     if (i == 2)
//     {
//         count_2 += 1;
//     }
//     if (i == 5)
//     {
//         count_5 += 1;
//     }
//     sum += i;
// }
// double sr_arith = (double)sum / (double)grades.Length;
// Console.WriteLine($"\nнаименьшая оценка {min}, максимальная оценка {max}, средняя оценка {sr_arith}");
// if (sr_arith >= 4.5)
// {
//     Console.WriteLine("\nОтличник");
// }
// if (sr_arith >= 3.5)
// {
//     Console.WriteLine("\nХорошист");
// }
// else
// {
//     Console.WriteLine("\nЕсть над чем работать");
// }

//доп задание
int[] arr = { 1, 2, 3, 4, 5, 6 };
for (int i = arr.Length-1; i >= 0; i--)
{
    Console.Write(arr[i] + " ");
}