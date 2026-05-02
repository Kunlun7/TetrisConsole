using System;

namespace TetrisConsole
{
	internal class AFigureGenerator
	{
		private int _x;
		private int _y;
		private Random _rand = new Random();

		public AFigureGenerator(int x, int y)
		{
			_x = x;
			_y = y;
		}

		public AFigure NewFigure()
		{
			AFigure f = null;

			switch (_rand.Next(0, 2))
			{
				case 0:
					f = new ASquare(_x, _y);
					break;

				case 1:
					f = new AStick(_x, _y);
					break;

				case 2:
					break;

				case 3:
					break;

			};

			f.Draw();

			return f;
		}
	}
}