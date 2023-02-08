namespace ConsoleAppTask47
{
	internal class Program
	{
		static void createArray(double[,] array, int M, int N)
		{
			Random rnd = new Random();
			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					array[i, j] = rnd.Next(100, 1000) / 10.0;
				}
			}
			
		}

		static void printArray(double[,] array, int M, int N)
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

		static void Main(string[] args)
		{
			int M, N;

			Console.Write("Введите число строк массива: ");
			while(!int.TryParse(Console.ReadLine(), out M))
			{
				Console.WriteLine("\nНеверный ввод, введите число строк массива: ");
			}

			Console.Write("Введите число столбцов массива: ");
			while (!int.TryParse(Console.ReadLine(), out N))
			{
				Console.WriteLine("\nНеверный ввод, введите число столбцов массива: ");
			}

			double[,] array = new double[M, N];

			createArray(array, M, N);
			printArray(array, M, N);

			Console.ReadLine();
		}
	}
}
