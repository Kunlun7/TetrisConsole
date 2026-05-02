using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsole
{
	class AStick : AFigure
	{

		public AStick(int x, int y, char c)
		{

			Points[0] = new APoint(x, y, c);
			Points[1] = new APoint(x, y + 1, c);
			Points[2] = new APoint(x, y + 2, c);
			Points[3] = new APoint(x, y + 3, c);
		}


	}
}
