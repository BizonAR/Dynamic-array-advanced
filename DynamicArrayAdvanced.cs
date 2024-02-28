using System;
using System.Collections.Generic;

namespace DynamicArrayAdvanced
{
	internal class DynamicArrayAdvanced
	{
		static void Main(string[] args)
		{
			const string CommandExit = "1";
			const string CommandSum = "2";

			List<int> numbers = new List<int>();

			bool isProgramActive = true;

			Console.WriteLine("Добро пожаловать в приложение сумма чисел!");

			while (isProgramActive)
			{
				Console.WriteLine("Вы можете вводить числа и потом посчитать их сумму\n");
				Console.WriteLine("Список команд \n" +
					 $"{CommandExit} - выход из программы\n" +
					 $"{CommandSum} - сумма введённых чисел");

				Console.Write("Введите команду или число: ");
				string input = Console.ReadLine();

				Console.WriteLine();

				switch (input)
				{
					case CommandExit:
						isProgramActive = false;
						break;

					case CommandSum:
						CalculateSum(numbers);
						break;

					default:
						AddNumber(input, numbers);
						break;
				}

				Console.Clear();
			}

			Console.WriteLine("Программа завершена.");
		}

		static void CalculateSum(List<int> numbers)
		{
			int sum = 0;

			for (int i = 0; i < numbers.Count; i++)
				sum += numbers[i];

			Console.WriteLine($"Полученная сумма: {sum}\n");
			Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
			Console.ReadKey();
		}

		static void AddNumber(string input, List<int> numbers)
		{
			if (int.TryParse(input, out int number))
			{
				numbers.Add(number);
			}
			else
			{
				Console.WriteLine("Некорректный ввод. Введите число или команду.\n");
				Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
				Console.ReadKey();
			}
		}
	}
}
