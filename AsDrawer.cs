using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsole
{
	public static class AsDrawer
	{
		public const char FigureChar = '*';
		public const char FieldChar = '.';

		public static void DrawPoint(int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(FigureChar);
			Console.SetCursorPosition(0, 0);
		}

		public static void ClearPoint(int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(FieldChar);
			Console.SetCursorPosition(0, 0);
		}
	}
}
