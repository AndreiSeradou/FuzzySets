//////////////////////////////////////////////////////////////////////////////////////
// Лабораторная работа по дисциплине ЛОИС
// Выполнена студентами группы 921704 БГУИР
// Середов А. С.
// Вариант 23 - Реализовать прямой нечеткий логический вывод, используея импликацию Лукасевича
//// 20.12.2022
//// Использованные материалы:
//// Рутковская Д., Пилиньский М., Рутковский Л. Нейронные сети, генетические алгоритмы и нечеткие системы: Пер. с польск. И. Д. Рудинского. — М.: Горячая линия — Телеком, 2006. — 45 с.: ил.
//// Zadeh L. A. Fuzzy Sets, Information and Control, 1965, vol. 8, s. 338-353

using ConsoleApp1;

double[] arr1 = { 1, 1, 0, 0.5};
double[] arr2 = { 1, 0, 0.5, 1 };
double[] arr3 = { 0, 1, 0, 0.5};
double[] arr4 = { 0.5, 0.5, 0, 0 };

double[] result;
char symbol = 'a';

Console.Write("A -> B to : ");

Printer.printIncomingParameters(arr3, symbol);

result = FuzzySets.FuzzySets.conclusion(arr3, FuzzySets.FuzzySets.computeImpl(arr1, arr2));

symbol = 'b';

Printer.printIncomingParameters(result, symbol);