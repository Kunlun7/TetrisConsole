using System;
using System.Threading;

namespace TetrisConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			int winWidth = 40;
			int winHeight = 30;
			Console.SetWindowSize(winWidth, winHeight);
			Console.SetBufferSize(winWidth, winHeight);

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

					curFigure.Move(EDirection.Left);
					break;

				case ConsoleKey.RightArrow:

					curFigure.Move(EDirection.Right);
					break;

				case ConsoleKey.DownArrow:

					curFigure.Move(EDirection.Down);
					break;

			}

		}

	}
}
