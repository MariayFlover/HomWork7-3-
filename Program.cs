//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.   0,5 7 -2 -0,2   1 -3,3 8 -9,9    8 7,8 -7,1 9

/*
int[,] CreateRandom2dArray(int rows, int columns)
{
int[,] newArray = new int[rows, columns];
 for(int i = 0; i < rows; i++)
  {
  for(int j = 0; j < columns; j++)
    {
      newArray[i, j] = new Random().Next(-10,10);
    }
  }
return newArray;
}

void Show2dArray(int[,]array)

{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
              Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
        Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m =Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int n =Convert.ToInt32(Console.ReadLine());

int[,] Array = CreateRandom2dArray(m, n);
Show2dArray(Array);
*/



//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:1 4 7 2    5 9 2 3    8 4 2 4         17 -> такого числа в массиве нет
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) 
{
int[,] newArray = new int[rows, columns];
 for(int i = 0; i < rows; i++)
  {
  for(int j = 0; j < columns; j++)
    {
      newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
return newArray;
}

void Element(int[,] array , int num)
{ 
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        
        if(num == array[i,j]) 
          {
            Console.WriteLine(array[i,j]);
          } 
          else  
           {
              Console.WriteLine("такого элемента нет");
           }
        }   
              
}

void Show2dArray(int[,]array)

{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
              Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
        Console.WriteLine();
}

int[,] Array = CreateRandom2dArray(5, 5, 1, 9);
Show2dArray(Array);
Console.Write("Input element array: ");
int n =Convert.ToInt32(Console.ReadLine());
Element(Array,n);
*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) 
{
int[,] newArray = new int[rows, columns];
 for(int i = 0; i < rows; i++)
  {
  for(int j = 0; j < columns; j++)
    {
      newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
return newArray;
}

void Flower (int[,] array)
{
   int result=0;
  for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        
    {
        result = result + array[i,j];
    }
    result=result/array.GetLength(1);
    }
}

void Show2dArray(int[,]array)

{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
              Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
        Console.WriteLine();
}

int[,] Array = CreateRandom2dArray(5, 5, 1, 9);
Show2dArray(Array);
Flower(Array);

