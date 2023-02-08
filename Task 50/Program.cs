namespace ConsoleAppTask50
{
	internal class Program
	{
		static void createArray(int[,] array, int M, int N)
		{
			Random rnd = new Random();
			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					array[i, j] = rnd.Next(100, 1000);
				}
			}

		}

		static void printArray(int[,] array, int M, int N)
		{
			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					Console.Write(array[i, j] + " ");
				}
				Console.WriteLine();
			}
		}

		static void valueElement(int[] position, int[,] array)
		{
			if (position[0] < array.GetLength(0) && position[1] < array.GetLength(1))
			{
				Console.WriteLine($"Число в строке {position[0]} столбце {position[1]} = {array[position[0],position[1]]}");
			}

			else
			{
				Console.WriteLine("такого числа в массиве нет");
			}
		}

		static void Main(string[] args)
		{
			int M, N;
			int [] position = new int[2];

			Console.Write("Введите число строк массива: ");
			while (!int.TryParse(Console.ReadLine(), out M))
			{
				Console.WriteLine("\nНеверный ввод, введите число строк массива: ");
			}

			Console.Write("Введите число столбцов массива: ");
			while (!int.TryParse(Console.ReadLine(), out N))
			{
				Console.WriteLine("\nНеверный ввод, введите число столбцов массива: ");
			}

			int[,] array = new int[M, N];

			createArray(array, M, N);
			printArray(array, M, N);

			Console.Write("Введите номер строки в котором нужно найти число: ");
			while (!int.TryParse(Console.ReadLine(), out position[0]))
			{
				Console.WriteLine("\nНеверный ввод, введите номер строки в котором нужно найти число: : ");
			}

			Console.Write("Введите номер столбца в котором нужно найти число: ");
			while (!int.TryParse(Console.ReadLine(), out position[1]))
			{
				Console.WriteLine("\nНеверный ввод, введите номер столбца в котором нужно найти число: : ");
			}

			valueElement(position, array);

			Console.ReadLine();
		}
	}
}

