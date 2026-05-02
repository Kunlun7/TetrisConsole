using System;
using System.Threading;

namespace TetrisConsole
{
	class Program
	{
		static AFigureGenerator FigGen;

		static void Main(string[] args)
		{
			Console.SetWindowSize(AsField.Width, AsField.Height);
			Console.SetBufferSize(AsField.Width, AsField.Height);

			//AsField.SetWidth(20);

			FigGen = new AFigureGenerator(AsField.Width / 2, 0, AsDrawer.FigureChar);

			AFigure curFigure = FigGen.NewFigure();

			while (true)
			{
				// если нажата клавиша в консоли
				if (Console.KeyAvailable)
				{

					ConsoleKeyInfo key = Console.ReadKey();
					EMoveResult result = HandleKey(curFigure, key.Key);
					ProcessResult(result, ref curFigure);
				}

			}

			Console.ReadLine();
		}

		private static bool ProcessResult(EMoveResult result, ref AFigure curFigure)
		{
			if (result == EMoveResult.BorderBottom || result == EMoveResult.Heap)
			{
				AsField.AddFigure(curFigure);
				AsField.TryDeleteLines();
				curFigure = FigGen.NewFigure();
				return true;
			}

			return false;
		}

		private static EMoveResult HandleKey(AFigure curFigure, ConsoleKey key)
		{
			switch (key)
			{
				case ConsoleKey.LeftArrow:
					return curFigure.TryMove(EDirection.Left);

				case ConsoleKey.RightArrow:
					return curFigure.TryMove(EDirection.Right);

				case ConsoleKey.DownArrow:
					return curFigure.TryMove(EDirection.Down);

				case ConsoleKey.UpArrow:
					return curFigure.TryRotate();
			}

			return EMoveResult.Success;

		}

	}
}
