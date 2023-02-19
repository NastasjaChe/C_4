// Задача 25.Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int number(int A, int B){
  int result = 1;
  for(int i=1; i <= B; i++)
  {
    result = result * A;
  }
    
    return result;
}

  Console.Write("input A: ");
  int numA = Convert.ToInt32(Console.ReadLine());
  Console.Write("input B: ");
  int numB = Convert.ToInt32(Console.ReadLine());
  int num = number(numA, numB);
  Console.WriteLine("result: " + num);
*/
// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
  int SumNum(int numN)
  {
    int size = numN;
    int n = 0;
    int result = 0;

    for (int i = 0; i < size; i++){
      n = numN - numN % 10;
      result = result + (numN - advance);
      numN = numN / 10;
    }
   return result;
  }

Console.Write("input N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNum(numberN);
Console.WriteLine("summa: " + sumNumber);
*/
//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
        return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("input a lenght of new array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(Length, min, max);
ShowArray(myArray);
