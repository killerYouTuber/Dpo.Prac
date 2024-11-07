using System;
using System.Collections.Generic;

namespace Dpo.Prac1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите предложение (до 70 символов):");
            string input = Console.ReadLine();

            // Проверка длины предложения
            if (input.Length > 70)
            {
                Console.WriteLine("Ошибка: предложение не должно превышать 70 символов.");
                Console.ReadLine();
                return;
            }

            // Словарь для подсчета частоты гласных
            Dictionary<char, int> vowelFrequency = new Dictionary<char, int>
        {
            {'а', 0}, {'е', 0}, {'ё', 0}, {'и', 0}, {'о', 0}, {'у', 0}, {'ы', 0}, {'э', 0}, {'ю', 0}, {'я', 0}
        };

            // Подсчет гласных
            foreach (char c in input.ToLower())
            {
                if (vowelFrequency.ContainsKey(c))
                {
                    vowelFrequency[c]++;
                }
            }

            // Поиск наиболее часто встречающейся гласной
            char mostFrequentVowel = '\0';
            int maxFrequency = 0;

            foreach (var pair in vowelFrequency)
            {
                if (pair.Value > maxFrequency)
                {
                    maxFrequency = pair.Value;
                    mostFrequentVowel = pair.Key;
                }
            }

            if (mostFrequentVowel != '\0')
            {
                Console.WriteLine($"Наиболее часто встречающаяся гласная: '{mostFrequentVowel}' ({maxFrequency} раз)");
            }
            else
            {
                Console.WriteLine("Гласные не найдены в предложении.");
            }
            Console.ReadLine();
        }
    }
}
