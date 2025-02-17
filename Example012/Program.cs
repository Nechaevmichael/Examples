﻿// // Вид 1. Методы, которые ничего не принимают и ничего не возвращают.

// void Method1()
// {
//     Console.WriteLine("Автор - Нехаев Михаил Анатольевич");
// }
// //Method1();

// // Вид 2. Методы, которые ничего не возвращают, но принимиют.

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
        
//         i++;
//     }
// }
// Method21(msg: "Текст сообщения", count: 5);

// // Вид 3. Методы, которые возвращают и ничего не принимают.

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// // Вид 4. Методы, которые принимают и возвращают.

// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty;
// //     while (i < count)
// //     {
// //         result += text;
// //         i++;
// //     }
// //     return result;
// // }

// string Method4(int count, string text)
// {
    
//     string result = String.Empty;
//     for(int i = 0; i < count; i++) 
//     {
//         result += text;
//     }
//     return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// for(int i = 2; i < 10; i++)
// {
//     for(int j = 2; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// Задача. Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К",
// а больше "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result += $"{newValue}";
//         else result += $"{text[i]}"; 
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 2};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = arr[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);