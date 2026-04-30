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


		public void Draw()
		{

			Console.SetCursorPosition(x, y);
			Console.Write(c);
		}
	}
}
