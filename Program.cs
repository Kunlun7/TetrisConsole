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

			int x1 = 3;
			int y1 = 4;
			char c1 = '*';
			Draw(x1, y1, c1);


			int x2 = 5;
			int y2 = 6;
			char c2 = '*';
			Draw(x2, y2, c2);



			Console.ReadLine();
		}

		static public void Draw(int x, int y, char c)
		{

			Console.SetCursorPosition(x, y);
			Console.Write(c);
		}

	}
}
