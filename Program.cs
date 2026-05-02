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

			APoint p1 = new APoint(3, 4, '*');
			p1.Draw();

			APoint p2 = new APoint () { x = 5, y = 6, c = '*'};
			p2.Draw();

			ASquare sq1 = new ASquare(7, 4, '#');
			sq1.Draw();
			Thread.Sleep(500);
			sq1.Clear();
			sq1.Move(EDirection.Right);
			sq1.Draw();



			//AFigure[] fig = new AFigure[2];
			//fig[0] = new ASquare(2, 5, '#');
			//fig[1] = new AStick(8, 5, '#');

			//foreach (AFigure f in fig) {

			//	f.Draw();
			//}

			Console.ReadLine();
		}

	}
}
