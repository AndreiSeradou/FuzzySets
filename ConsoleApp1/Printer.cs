//////////////////////////////////////////////////////////////////////////////////////
// Лабораторная работа по дисциплине ЛОИС
// Выполнена студентами группы 921703 БГУИР
// Середов А. С.
// Вариант 23 - Реализовать прямой нечеткий логический вывод, используея импликацию Лукасевича
// Ссылка на гит проекта https://github.com/AndreiSeradou/FuzzySets
//// 20.12.2022
//// Использованные материалы:
//// Рутковская Д., Пилиньский М., Рутковский Л. Нейронные сети, генетические алгоритмы и нечеткие системы: Пер. с польск. И. Д. Рудинского. — М.: Горячая линия — Телеком, 2006. — 45 с.: ил.
//// Zadeh L. A. Fuzzy Sets, Information and Control, 1965, vol. 8, s. 338-353

namespace ConsoleApp1
{
    internal static class Printer
    {
        public static void printIncomingParameters(double[] arrA, char symbol)
        {
            Console.Write("{");

            for (int i = 0; i < arrA.Length; i++)
            {
                if (i + 1 != arrA.Length)
                {
                    Console.Write($"({symbol}{i} {arrA[i]}), ");
                }
                else
                {
                    Console.Write($"({symbol}{i} {arrA[i]})");
                }
            }
            
            Console.Write("}");

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
