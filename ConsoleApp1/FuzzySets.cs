//////////////////////////////////////////////////////////////////////////////////////
// Лабораторная работа по дисциплине ЛОИС
// Выполнена студентами группы 921704 БГУИР
// Середов А. С.
// Вариант 23 - Реализовать прямой нечеткий логический вывод, используея импликацию Лукасевича
//// 20.12.2022
//// Использованные материалы:
//// Рутковская Д., Пилиньский М., Рутковский Л. Нейронные сети, генетические алгоритмы и нечеткие системы: Пер. с польск. И. Д. Рудинского. — М.: Горячая линия — Телеком, 2006. — 452 с.: ил.
//// Zadeh L. A. Fuzzy Sets, Information and Control, 1965, vol. 8, s. 338-353

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace FuzzySets
{
    internal class FuzzySets
    {
        public static double tNorm(double v1, double v2)
        {
            return v1 > v2 ? v2 : v1;
        }

        public static double impl(double v1, double v2)//Лукасевича 
        {
            return 1 > 1 - v1 + v2 ? 1 - v1 + v2 : 1;
        }

        public static double[,] computeImpl(double[] s1, double[] s2)//callculate each alement each impl was presented in the form of matrix
        {
            var result = new double[s1.Length, s2.Length];

            Console.Write("Stage Impl Matrix:");
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    result[i, j] = impl(s1[i], s2[j]);

                    Console.Write(result[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            return result;
        }

        public static double[] conclusion(double[] s1, double[,] s2)//закл преобр
        {
            int rows = s2.GetUpperBound(0) + 1;    
            int columns = s2.Length / rows;

            var result = new double[rows];

            double[] lenght;

            for (int i = 0; i < rows; i++)
            {
                lenght = new double[columns];

                for (int j = 0; j < columns; j++)
                {
                    lenght[j] = (tNorm(s1[j], s2[i,j]));
                }

                result[i] = lenght.Max();
            }

            return result;
        }
    }
}
