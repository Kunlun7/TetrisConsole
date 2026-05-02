using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsole
{
	class APoint
	{
		public int X { get; set; }
		public int Y;
		public char C;

		public APoint() {}

		public APoint(int _x, int _y, char _c) {

			X = _x;
			Y = _y;
			C = _c;		
		}

		public APoint(APoint p) {

			X = p.X;
			Y = p.Y;
			C = p.C;		
		}


		public void Draw()
		{

			Console.SetCursorPosition(X, Y);
			Console.Write(C);
		}

		internal void Clear()
		{
			Console.SetCursorPosition(X, Y);
			Console.Write(' ');
		}

		internal void Move(EDirection dir)
		{
			switch (dir) {

				case EDirection.Down:
					Y += 1;
					break;

				case EDirection.Left:
					X -= 1;
					break;

				case EDirection.Right:
					X += 1;
					break;

			}
		}
	}
}
