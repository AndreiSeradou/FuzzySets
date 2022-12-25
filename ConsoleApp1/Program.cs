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

using ConsoleApp1;


/*
 Для реализации метода прямого нечеткого логического вывода нам понадобится выбрать оператор импликации и T-норму.
T-NORM min(a,b)
𝑖𝑚𝑝𝑙(a,b)= Cxy=min(1, 1–a+b)
*/
//Входные данные будут содержать знания (нечеткие множества) и правила (импликации), например
// -->
double[] arr1 = { 1, 1, 0, 0.5};
double[] arr2 = { 1, 0, 0.5, 1 };
double[] arr3 = { 0, 1, 0, 0.5};
double[] arr4 = { 0.5, 0.5, 0, 0 };
// <--

double[] input1 = { };
double[] input2 = { };

char[] symbolArr = { 'A', 'B', 'C', };

double[] result;

int size = symbolArr.Length;
int variable;
char symbol = 'a';
char outSymbol = 'c';

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < symbolArr.Length; j++)
    {
        if (symbolArr[i] != symbolArr[j])
        {
            Console.WriteLine(symbolArr[i] + "->" + symbolArr[j]);
        }
    }
}

Console.WriteLine("Inter number of variable:");

variable = Convert.ToInt32(Console.ReadLine());

switch (variable)
{
    case 1:
        symbol = 'a';
        outSymbol = 'b';
        input1 = arr1;
        input2= arr2;
        Console.WriteLine("A -> B to : ");
        break;

    case 2:
        symbol = 'a';
        outSymbol = 'c';
        input1 = arr1;
        input2 = arr3;
        Console.WriteLine("A -> C to : ");
        break;
    case 3:
        symbol = 'b';
        outSymbol = 'a';
        input1 = arr2;
        input2 = arr1;
        Console.WriteLine("B -> A to : ");
        break;
    case 4:
        symbol = 'b';
        outSymbol = 'c';
        input1 = arr2;
        input2 = arr3;
        Console.WriteLine("B -> C to : ");
        break;

    case 5:
        symbol = 'c';
        outSymbol = 'a';
        input1 = arr3;
        input2 = arr1;
        Console.WriteLine("C -> A to : ");
        break;
    case 6:
        symbol = 'c';
        outSymbol = 'b';
        input1 = arr3;
        input2 = arr2;
        Console.WriteLine("C -> B to : ");
        break;
}

for (int i = 0; i < arr4.Length; i++)
{
    Console.WriteLine($"Input value {i + 1}: ");

    arr4[i] = Convert.ToDouble(Console.ReadLine());
}

Console.Write("Incoming parameters :");

Printer.printIncomingParameters(arr4, symbol);

result = FuzzySets.FuzzySets.conclusion(arr3, FuzzySets.FuzzySets.computeImpl(input1, input2));

Console.Write("Result :");

Printer.printIncomingParameters(result, outSymbol);