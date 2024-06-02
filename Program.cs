using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


namespace ConsoleDZ2
{

    internal class Program
    {
        static void Matrixout(int[,] Matrix, double chislo)
        {
            double[,] Mat = new double[Matrix.GetLength(0), Matrix.GetLength(1)];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Mat[i, j] = Matrix[i, j] * chislo;
                    Console.Write(Mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Matrixout1(int[,] Matrix, int[,] Matrix1)
        {
            double[,] Mat = new double[Matrix.GetLength(0), Matrix.GetLength(1)];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Mat[i, j] = Matrix[i, j] + Matrix1[i, j];
                    Console.Write(Mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Matrixout2(int[,] Matrix, int[,] Matrix1)
        {
            double[,] Mat = new double[Matrix.GetLength(0), Matrix.GetLength(1)];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Mat[i, j] = Matrix[i, j] * Matrix1[i, j];
                    Console.Write(Mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
           Console.WriteLine("Задача 1");
            int[] A;
            A = new int[5];
            Console.WriteLine("Введите 5 чисел для заполнения одномерного массива");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine()); // Заполнение
            }
            foreach (int element in A) { Console.Write(element); } // Вывод
            Console.ReadLine();
            int sum = 0;// Ищем минимальный, максимальный элемент, сумму и произведение
            int pow = 1;
            int min = A[0];
            int max = A[0];
            int sumX = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                pow *= A[i];
                if (A[i] < min)
                    min = A[i];
                if (A[i] > max)
                    max = A[i];
                if (A[i] % 2 == 0)
                    sumX += A[i];
            }
            Console.WriteLine("Максимальный элемент: " + max);
            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Произведение: " + pow);
            Console.WriteLine("Сумма четных элементов: " + sumX);


            int[,] B = new int[3, 4]; // Двумерный массив. Заполняем, выводим

            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    B[i, k] = random.Next(20);
                    Console.Write(B[i, k] + " ");
                }
                Console.WriteLine();
            }
            int max1 = B[0, 0]; // Ищем минимальный, максимальный элемент, сумму и произведение
            int min1 = B[0, 0];
            int sum1 = 0;
            uint pow1 = 1;
            int sumY = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (max1 < B[i, k]) max1 = B[i, k];
                    if (min1 > B[i, k]) min1 = B[i, k];
                    sum1 += B[i, k];
                    pow1 *= (uint) B[i, k];
                    if (k % 2 != 0)
                        sumY += B[i, k];
                }

            }
            Console.WriteLine("Максимальный элемент: " + max1);
            Console.WriteLine("Минимальный элемент: " + min1);
            Console.WriteLine("Сумма: " + sum1);
            Console.WriteLine("Произведение: " + pow1);
            Console.WriteLine("Сумма элементов нечетных столбцов: " + sumY);



            Console.WriteLine("Задача 2");
            int[,] F = new int[5, 5]; // Двумерный массив. Заполняем, выводим
            Random random1 = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int t = 0; t < 5; t++)
                {
                    F[i, t] = random1.Next(-100, 100);
                    Console.Write(F[i, t] + " ");
                }
                Console.WriteLine();
            }
            int[] arr; // Заталкиваем в одномерный массив
            arr = new int[25];

            int z = 0;
            for (int i = 0; i < 5; i++)
                for (int t = 0; t < 5; t++)
                {
                    arr[z] = F[i, t];
                    z++;
                }
            foreach (var item in arr)
            Console.Write($"{item} "); // Выводим на экран
            Console.WriteLine();
            int index = Array.IndexOf(arr, arr.Min()); // Индекс минимального эл-та
            int index1 = Array.IndexOf(arr, arr.Max()); // Индекс максимального эл-та
            if (index < index1)
            {
                int[] L = arr[(index + 1)..index1];
                Console.WriteLine($"Сумма между минимальным и максимальным значением  { L.Sum()}");
            }
            else
            {
                int[] L = arr[(index1 + 1)..index];
                Console.WriteLine($"Сумма между минимальным и максимальным значением  {L.Sum()}");
            }
           
            Console.WriteLine("Задача 3");

            Console.WriteLine("Введите строку: " );
            string m = Console.ReadLine();
            int nomer; // Номер в алфавите
            int d; // Смещение
            string s; //Результат
            int j; // Переменная для циклов

            char[] massage = m.ToCharArray(); // Превращаем строку в массив символов.

            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            for (int i = 0; i < massage.Length; i++) // Перебираем каждый символ сообщения
            {
                for (j = 0; j < alfavit.Length; j++)// Ищем индекс буквы
                {
                    if (massage[i] == alfavit[j])
                    {
                        break;
                    }
                }
                if (j != 33) // Если j равно 33, значит символ не из алфавита
                {
                    nomer = j; // Индекс буквы
                    d = nomer +3; // Делаем смещение. При декодировании меняем знак на противоположный
                    if (d > 32)
                    {
                        d = d - 33;
                    }
                    massage[i] = alfavit[d]; // Меняем букву
                }
            }
            s = new string(massage); // Собираем символы обратно в строку.
            Console.WriteLine($"Зашифрованная строка: {s}") ; // Выводим

            
            Console.WriteLine("Задача 4");
            int[,] S = new int[5, 5]; // Двумерный массив. Заполняем, выводим
            Random random2 = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int t = 0; t < 5; t++)
                {
                    S[i, t] = random2.Next(0, 9);
                    Console.Write(S[i, t] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Умножение матрицы на число");
            Matrixout(S, 3);
            Console.WriteLine("--------------------");
            Console.WriteLine("Вторая матрица");
            int[,] P = new int[5, 5]; // Двумерный массив. Заполняем, выводим
            Random random3 = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int t = 0; t < 5; t++)
                {
                    P[i, t] = random3.Next(0, 9);
                    Console.Write(P[i, t] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Сложение матриц");
            Matrixout1(S,P);
            Console.WriteLine("--------------------");
            Console.WriteLine("Умножение матриц");
            Matrixout2(S, P);
            Console.WriteLine("--------------------");
            
            
            Console.WriteLine("Задача 5");
            Console.WriteLine("Введите математическое выражение");
            string str = Console.ReadLine();
            object value = new DataTable().Compute(str, null);
            string res = value.ToString();
            Console.WriteLine("Результат: " + res); ;


            Console.WriteLine("Задача 6");
            string str1 = "пришла весна. по мокрым улицам журчали торопливые ручьи. " +
                "все стало ярче, чем зимой: и дома, и заборы, и одежда людей, и небо, и солнышко. " +
                "от солнца майского жмуришь глаза, так оно ярко. и по-особому оно ласково греет, точно гладит всех.";
            string str2;
            string[] strArr = new string[100];
                for (int i = 0; i < strArr.Length; i++)
                {
                int found = str1.IndexOf(".");
                str2 = str1.Substring(0, found + 1); // вытаскиваем строку с точкой
                string str3 = str2[0].ToString ().ToUpper(); // создаем строку 1 символ. Переводим в верх регистр
                str2 = str2.Remove(0, 1); // удаляем первый символ
                str2 = str2.Insert(0, str3); // добавляем символ в верх регистре
                strArr[i] = str2; // пишем в массив стринг
                if (str1.Length == str2.Length)
                { break; }  
                else
                str1 = str1.Remove (0, found + 2); // удаляем подстроку и пустой пробел после точки
                }
            Console.WriteLine(string.Join(" ", strArr));

            Console.WriteLine("Задача 7");
            Console.WriteLine("Исходное стихотворение:");
            string ks = "\nКак на Петино рожденье\r\nИспекли мы каравай,\r\nВот такой вышины,\r\nВот такой низины,\r\nВот такой ужины,\r\nВот такой ширины.\r\nкаравай, каравай,\r\nКого любишь, выбирай!\r\n";
            Console.WriteLine(ks);
            Console.Write("\nНедопустимое слово: ");
            Console.WriteLine("каравай");
            string word = "каравай"; // Запретное слово            
            int count1 = -1; // Счётчик вхождения запретного слова до замены (-1 для первой итерации цикла while)
            int count2 = -1; // Счётчик вхождения запретного слова после замены
            int pos = 0; // Индекс первого вхождения запретного слова в строку
            while (pos != -1) // Пока в строке не будет найдено ни одного запретного слова (метод IndexOf = -1 если ничего не найдено)
            {
                pos = ks.IndexOf(word, pos + 1);
                count1++;
            }
            string change = ""; // Замена запретного слова
            foreach (char el in word) // Цикл формирования запретного слова
                change += '*';
            ks = ks.Replace(word, change);
            pos = 0;
            while (pos != -1) // Пока в строке не будет найдено ни одного запретного слова (метод IndexOf = -1 если ничего не найдено)
            {
                pos = ks.IndexOf(word, pos + 1);
                count2++;
            }
            Console.WriteLine("\nСтихотворение после замены запретного слова:");
            Console.WriteLine(ks);
            Console.WriteLine("Слово заменено " + (count1 - count2) + " раза");

        }
    }
}
    

