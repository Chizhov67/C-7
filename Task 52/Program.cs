namespace ConsoleAppTask52
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
					array[i, j] = rnd.Next(1, 10);
				}
			}

		}

		static void enterArray(int[,] array, int M, int N) //Если вводить массив руками
		{
			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					Console.Write($"Введите элемент в {i+1} строке и {j+1} столбце : ");
					while(!int.TryParse(Console.ReadLine(), out array[i, j]))
					{
						Console.Write($"\nНеверный ввод, введите элемент в {i+1} строке и {j+1} столбце : ");
					}
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

		static void avgArithmetic(int[,] array, double[] avgArray, int M, int N)
		{
			for (int j = 0; j < N; j++)
			{
				double sum = 0;
				for (int i = 0; i < M; i++)
				{
					sum += array[i, j];
				}

				avgArray[j] = Math.Round(sum / M, 2);
			}
		}

		static void Main(string[] args)
		{
			int M, N;
			

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
			double[] avgArray = new double[N];

			enterArray(array, M, N);
			printArray(array, M, N);
			avgArithmetic(array, avgArray, M, N);

			for (int i = 0; i < N; i++)
			{
				Console.Write(avgArray[i] + " ");
			}


			Console.ReadLine();
		}
	}
}

