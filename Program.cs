using System;
using System.Threading;
using System.Timers;

namespace TetrisConsole
{
	class Program
	{
		static int TimerInterval = 800;
		static System.Timers.Timer GameTimer;

		static AFigure curFigure;
		static AFigureGenerator FigGen;

		static private Object _lockObject = new object();

		static void Main(string[] args)
		{
			AsField.Init();

			FigGen = new AFigureGenerator(AsField.Width / 2, 0, AsDrawer.FigureChar);

			curFigure = FigGen.NewFigure();
			SetTimer();

			while (true)
			{
				// если нажата клавиша в консоли
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					Monitor.Enter(_lockObject);
					EMoveResult result = HandleKey(curFigure, key.Key);
					ProcessResult(result, ref curFigure);
					Monitor.Exit(_lockObject);
				}

			}

			Console.ReadLine();
		}


		private static void SetTimer()
		{
			GameTimer = new System.Timers.Timer(TimerInterval);
			GameTimer.Elapsed += OnTimedEvent;
			GameTimer.AutoReset = true;
			GameTimer.Enabled = true;
		}

		private static void OnTimedEvent(object sender, ElapsedEventArgs e)
		{
			Monitor.Enter(_lockObject);
			var res = curFigure.TryMove(EDirection.Down);
			ProcessResult(res, ref curFigure);
			Monitor.Exit(_lockObject);
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
