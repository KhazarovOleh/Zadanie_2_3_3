using System;
/*Дано натуральное число. Определить, является ли сумма
его максимальной и минимальной цифр кратной числу а*/

class Zadanie_2_3_3
    {
        static void Main(string[] args)
        {
         Console.Write("Введите натуральное число (с количеством цифр не больше 100): ");
         double k = Convert.ToDouble(Console.ReadLine());
         Console.Write("Введите число, для проверки кратности: ");
         double a = Convert.ToDouble(Console.ReadLine());
         double num;
         int max = 0, min = 9, len = 0;
         int[] mas = new int[100];

            for (int i = 0, j = 10; k > 0; i++)
            {
                num = k % j;
                mas[i] = (int)num;
                k -= num;
                k /= j;
                len++;
            }

            for (int i = 0; i < len; i++)
            {
                if (mas[i] > max)
                    max = mas[i];

                if (mas[i] < min)
                    min = mas[i];
            }

            Console.WriteLine("Максимальная цифра в значении - " + max +" и минимальная цифра в значении - " + min);
                   
            if ((min + max) % a == 0)
            {
                Console.WriteLine("Сумма максимального и минимального числа введенного значения кратна - "+a);
            }
            else
            {
                Console.WriteLine("Сумма максимального и минимального числа введенного значения не кратна - "+a);
            }
        }
    }

