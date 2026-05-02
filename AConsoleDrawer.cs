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

		public void DrawPoint(int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(FigureChar);
			Console.SetCursorPosition(0, 0);
		}

		public void ClearPoint(int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(FieldChar);
			Console.SetCursorPosition(0, 0);
		}

		public void InitField()
		{
			Console.SetWindowSize(AsField.Width, AsField.Height + 1);
			Console.SetBufferSize(AsField.Width, AsField.Height + 1);
			Console.CursorVisible = false;
			AsField.Redraw();
		}

		public void WriteGameOver()
		{
			Console.SetCursorPosition(AsField.Width / 2 - 9, AsField.Height / 2 - 1);
			Console.Write("                  ");
			Console.SetCursorPosition(AsField.Width / 2 - 9, AsField.Height / 2);
			Console.Write(" G A M E  O V E R ");
			Console.SetCursorPosition(AsField.Width / 2 - 9, AsField.Height / 2 + 1);
			Console.Write("                  ");
		}

	}
}
