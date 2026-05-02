using System;

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

			ASquare sq1 = new ASquare(2, 5, '#');
			sq1.Draw();

			AStick st1 = new AStick(8, 5, '#');
			st1.Draw();


			Console.ReadLine();
		}

	}
}
