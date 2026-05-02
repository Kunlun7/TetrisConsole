using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsole
{
	class APoint
	{
		public int x;
		public int y;
		public char c;

		public APoint() {}

		public APoint(int _x, int _y, char _c) {

			x = _x;
			y = _y;
			c = _c;		
		}

		public APoint(APoint p) {

			x = p.x;
			y = p.y;
			c = p.c;		
		}


		public void Draw()
		{

			Console.SetCursorPosition(x, y);
			Console.Write(c);
		}

		internal void Clear()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(' ');
		}

		internal void Move(EDirection dir)
		{
			switch (dir) {

				case EDirection.Down:
					y += 1;
					break;

				case EDirection.Left:
					x -= 1;
					break;

				case EDirection.Right:
					x += 1;
					break;

			}
		}
	}
}
