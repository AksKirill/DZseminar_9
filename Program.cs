 // Задача 47 Задайте массив MxN со случайными чмслами

// Console.Write("Введите, количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите, количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// double[,] Arr = new double[rows, colums];

// for (int i = 0; i < rows; i++)
// {
//     Console.Write("Строка массива {0}: ", i+1);
//     for (int j = 0; j < colums; j++)
//     {
//         Arr[i, j] = new Random().Next(-500, 500);
//         Console.Write(" {0}", Arr[i,j]);
//     }
//      Console.WriteLine();
// }

////////////////////////////////////////////////////////////////////////
//  // Задача 50 Задается адрес в массиве, требуется вывести число из массива или указание, что его нет
// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// double[,] Arr = new double[rows, colums];

// for (int i = 0; i < rows; i++)
// {
//     Console.Write("Строка массива {0}: ", i+1);
//     for (int j = 0; j < colums; j++)
//     {
//         Arr[i, j] = new Random().Next(-500, 500);
//         Console.Write(" {0}", Arr[i,j]);
//     }
//      Console.WriteLine();
// }

// Console.Write("Введите, номер строки искомого элемента массива: ");
// int indexX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите, номер столбца искомого элемента массива: ");
// int indexY = Convert.ToInt32(Console.ReadLine());
// if (indexX<=Arr.GetLength(0)&&indexY<=Arr.GetLength(1)) {
//     Console.WriteLine("Искомый элемент массива: " +Arr[indexX-1,indexY-1]); 
//     }
//     else {
//     Console.WriteLine("Элемента [" +indexX +", " +indexY +"] в массиве нет!");
//     }

///////////////////////////////////////////////////////////////////////
//  // Задача 52 Посчитать среднеарифметическое каждого столбца задаваемого массива
// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// double[,] Arr = new double[rows, colums];

// for (int i = 0; i < rows; i++)
// {
//     Console.Write("Строка массива {0}: ", i+1);
//     for (int j = 0; j < colums; j++)
//     {
//         Arr[i, j] = new Random().Next(-500, 500);
//         Console.Write(" {0}", Arr[i,j]);
//     }
//      Console.WriteLine();
// }

// Console.Write("Ср. значение столбцов: ");
// for (int j = 0; j < colums; j++)
// {
//     double Sum=0;
//     for (int i = 0; i < rows; i++)
//     {
//     Sum = Sum+Arr[i,j];
//     }
//     Console.Write(" {0}", Sum/Arr.GetLength(0));
// }

/////////////////////////////////////////////////////////////////////
//  // Задача 54 упорядочить по убыванию каждую строкуитать среднеарифметическое каждого столбца задаваемого 2 мерного массива
// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// double[,] Arr = new double[rows, colums];
// int Flag=0; double Temp=0;

// for (int i = 0; i < rows; i++)
// {
//     Console.Write("Строка массива {0}: ", i+1);
//     for (int j = 0; j < colums; j++)
//     {
//         Arr[i, j] = new Random().Next(-500, 500);
//         Console.Write(" {0}", Arr[i,j]);
//     }
//      Console.WriteLine();
// }

// Console.Write("Сортировка в строках по убыванию: ");
// for (int i = 0; i < colums; i++) 
// {

//     for (int j = 0; j < rows-1; j++)
//         {
//         if (Arr[i, j] < Arr[i, j+1])
//             {
//             Temp=Arr[i,j]; Arr[i, j] = Arr[i, j+1]; Arr[i, j+1]=Temp;
//             Flag=1;
//             }
//         }
// if (Flag==1)
// {
//     i=i-1; Flag=0;
// }
// }

// for (int i = 0; i < rows; i++)
// {
//     Console.Write("Строка массива {0}: ", i+1);
//     for (int j = 0; j < colums; j++)
//     {
//              Console.Write(" {0}", Arr[i,j]);
//     }
//      Console.WriteLine();
// }
////////////////////////////////////////////////////////////////////
 // Задача 56 в прямоугольном массиве найти строку с минимальной суммой элементов
// Console.Write("Введите количество строк и столбцов массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// int colums = rows;
// double[,] Arr = new double[rows, colums];


// for (int i = 0; i < rows; i++)
// {
//     Console.Write("Строка массива {0}: ", i+1);
//     for (int j = 0; j < colums; j++)
//     {
//         Arr[i, j] = new Random().Next(-10, 10);
//         Console.Write(" {0}", Arr[i,j]);
//     }
//      Console.WriteLine();
// }
// double Temp=0;
// Console.Write("Ср. значения строк: ");

// for (int i = 0; i < rows; i++)
// {
//     double Sum=0;
//     for (int j = 0; j < colums; j++)
//     {
//     Sum = Sum+Arr[i,j];
//     }
//     if (Temp>Sum)
//         {
//             Temp=Sum;
//         }
//     Console.WriteLine();
//     Console.Write(" {0}", Sum);
// }
// Console.WriteLine();
// Console.Write("Минимум ср. значения строк: ");
// Console.Write(" {0}", Temp);
//////////////////////////////////////////////////////////////////
//  // Задача 58 Найти произведение двух матриц

// Console.Write("Введите, количество строк массива 1: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите, количество столбцов массива 1: ");
// int colums1 = Convert.ToInt32(Console.ReadLine());
// double[,] Arr1 = new double[rows1, colums1];

// Console.Write("Введите, количество строк массива 2: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите, количество столбцов массива 2: ");
// int colums2 = Convert.ToInt32(Console.ReadLine());
// double[,] Arr2 = new double[rows2, colums2];
// double[,] Arr3 = new double[rows1, colums2];
// if (colums1!=rows2)
// {
//     Console.Write("Можно перемножать только матрицу с числом столбцов равным числу строк второй матрицы!");
//     return;
// }
// for (int i = 0; i < rows1; i++)
// {
//     Console.Write("Строка 1-го массива {0}: ", i+1);
//     for (int j = 0; j < colums1; j++)
//     {
//         Arr1[i, j] = new Random().Next(-10, 10);
//         Console.Write(" {0}", Arr1[i,j]);
//     }
//      Console.WriteLine();
// }
//   Console.WriteLine();

//   for (int i = 0; i < rows2; i++)
// {
//     Console.Write("Строка 2-го массива {0}: ", i+1);
//     for (int j = 0; j < colums2; j++)
//     {
//         Arr2[i, j] = new Random().Next(-10, 10);
//         Console.Write(" {0}", Arr2[i,j]);
//     }
//      Console.WriteLine();
// }
//      Console.WriteLine();
// for (int i = 0; i < rows1; i++)
// {
//     Console.Write("Строка массива перемножения {0}: ", i+1);
//     for (int j = 0; j < colums2; j++)
//     {
//         for (int k = 0; k < rows2; k++)
//         {
//             Arr3[i, j] += Arr1[i,k]*Arr2[k, j];
//         }
//         Console.Write(" {0}", Arr3[i,j]);
//     }
//     Console.WriteLine();
// }
// // ////////////////////////////////////////////////////////////////////////
//  // Задача 60 Сформируйте 3 мерный массив и выведите его построчно

// Console.Write("Введите, количество строк 3 мерного массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите, количество столбцов 3 мерного массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Введите глубину 3 мерного массива: ");
// // int deep = Convert.ToInt32(Console.ReadLine());
// int [,,] Arr = new int[rows, colums,5];

// for (int i = 0; i < rows; i++)
// {
//     // Console.Write("Строка i массива {0}: ", i+1);
//     for (int j = 0; j < colums; j++)
//     {
//         // Console.Write("Столбец j массива {0}: ", j+1);
//          for (int k = 0; k < colums; k++)
//         {
//             Console.Write(" Элемент ({0}", i+1);
//             Console.Write(";{0}", j+1);
//             Console.Write(";{0}):", k+1);
//             Arr[i,j,k] = new Random().Next(-10, 10);
//             Console.Write("{0}", Arr[i,j,k]);
//         }
//           Console.WriteLine();
//     }
//      Console.WriteLine();
// }
 

// ////////////////////////////////////////////////////////////////////////
// ////////////////////////////////////////////////////////////////////////
 // Задача 62 Запонить спирально массив 4 на 4

//  int[,] Arr = new int[4, 4];

//  int k=0; int l=0;int m=0;int n=3;
//  GetArray();

//  k=1; l=3;m=3;n=3;
//  GetArray();


//   k=3; l=2; m=3; n=0;
//  GetArray1();

//   k=2; l=0; m=1;n=0;
//  GetArray1();

//  k=1; l=1;m=1;n=2;
//  GetArray();

//  k=2; l=2;m=2;n=1;
//  GetArray1();

// void GetArray()
// {
// for (int i=k; i<m+1;i=i+1)
//     {
//      for (int j = l; j < n+1; j=j+1)
//         {
//             Console.Write("Введите элемент массива ({0},", i+1);
//             Console.Write("{0}):  ", j+1);
//             Arr[i,j]= Convert.ToInt32(Console.ReadLine());
//         }
//     }
// }

// void GetArray1()
// {
// for (int i=k; i>m-1;i=i-1)
//     {
//      for (int j = l; j>n-1; j=j-1)
//         {
//             Console.Write("Введите элемент массива ({0},", i+1);
//             Console.Write("{0}):  ", j+1);
//             Arr[i,j]= Convert.ToInt32(Console.ReadLine());
//         }
//     }
// }

//     for (int i=0;i<4;i++)
//     {
//         Console.Write("Строка массива {0}: ", i+1);
//         for (int j=0;j<4;j++)
//         {    
//             Console. Write(" {0} ", Arr[i, j]);
//         }
//          Console. WriteLine();
//     }
