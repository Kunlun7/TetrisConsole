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

			//APoint p1 = new APoint(3, 4, '*');
			//p1.Draw();

			//APoint p2 = new APoint() { x = 5, y = 6, c = '*' };
			//p2.Draw();

			AFigureGenerator FigGen = new AFigureGenerator(20, 0, '*');

			AFigure f = null;

			while (true)
			{

				FigureFall(ref f, FigGen);

				f.Draw();

			}

			Console.ReadLine();
		}

		static void FigureFall(ref AFigure fig, AFigureGenerator figgen) {

			fig = figgen.NewFigure();

			for (int i = 0; i < 15; i++)
			{

				fig.Clear();
				fig.Move(EDirection.Down);
				fig.Draw();
				Thread.Sleep(200);
			}

		}

	}
}
