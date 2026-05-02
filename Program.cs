using System;
using System.Threading;

namespace TetrisConsole
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.SetWindowSize(AsField.Width, AsField.Height);
			Console.SetBufferSize(AsField.Width, AsField.Height);

			//AsField.SetWidth(20);

			AFigureGenerator FigGen = new AFigureGenerator(20, 0, '*');

			AFigure curFigure = FigGen.NewFigure();

			while (true)
			{
				// если нажата клавиша в консоли
				if (Console.KeyAvailable)
				{

					ConsoleKeyInfo key = Console.ReadKey();
					HandleKey(curFigure, key);
				}

			}

			Console.ReadLine();
		}

		private static void HandleKey(AFigure curFigure, ConsoleKeyInfo key)
		{
			switch (key.Key)
			{
				case ConsoleKey.LeftArrow:

					curFigure.TryMove(EDirection.Left);
					break;

				case ConsoleKey.RightArrow:

					curFigure.TryMove(EDirection.Right);
					break;

				case ConsoleKey.DownArrow:

					curFigure.TryMove(EDirection.Down);
					break;

				case ConsoleKey.UpArrow:

					curFigure.Clear();
					curFigure.TryRotate();
					curFigure.Draw();
					break;

			}

		}

	}
}
