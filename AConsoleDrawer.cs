using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsole
{
	class AConsoleDrawer : IDrawer
	{
		public const char FigureChar = 'O';
		public const char FieldChar = '.';

		public void ClearPoint(int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(FigureChar);
			Console.SetCursorPosition(0, 0);
		}

		public void DrawPoint(int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(FieldChar);
			Console.SetCursorPosition(0, 0);
		}
	}
}
